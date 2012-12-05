using System;
using System.IO;
using System.Data;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Phongkhamnoisoi{
public class ReportPrinter : IDisposable
{
    private int m_currentPageIndex;
    private IList<Stream> m_streams;
    PrinterSettings ps;
    // Routine to provide to the report renderer, in order to
    //    save an image for each page of the report.
    private Stream CreateStream(string name,
      string fileNameExtension, Encoding encoding,
      string mimeType, bool willSeek)
    {
        Stream stream = new FileStream(@"..\..\" + name +
           "." + fileNameExtension, FileMode.Create);
        m_streams.Add(stream);
        return stream;
    }
    // Export the given report as an EMF (Enhanced Metafile) file.
    private void Export(LocalReport report)
    {
        string deviceInfo =
          "<DeviceInfo>" +
          "  <OutputFormat>EMF</OutputFormat>" +
          "  <PageWidth>8.5in</PageWidth>" +
          "  <PageHeight>11in</PageHeight>" +
          "  <MarginTop>0.25in</MarginTop>" +
          "  <MarginLeft>0.0in</MarginLeft>" +
          "  <MarginRight>0.25in</MarginRight>" +
          "  <MarginBottom>0.1in</MarginBottom>" +
          "</DeviceInfo>";
        //this.ps.
        Warning[] warnings;
        m_streams = new List<Stream>();
        report.Render("Image", deviceInfo, CreateStream,
           out warnings);
        foreach (Stream stream in m_streams)
            stream.Position = 0;
    }
    // Handler for PrintPageEvents
    private void PrintPage(object sender, PrintPageEventArgs ev)
    {
        Metafile pageImage = new
           Metafile(m_streams[m_currentPageIndex]);
        ev.Graphics.DrawImage(pageImage, ev.PageBounds);
        m_currentPageIndex++;
        ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
    }

    private void Print()
    {        
        if (m_streams == null || m_streams.Count == 0)
            return;
        PrintDocument printDoc = new PrintDocument();
        printDoc.PrinterSettings.PrinterName = ps.PrinterName;
        if (!printDoc.PrinterSettings.IsValid)
        {
            string msg = String.Format(
               "Can't find printer \"{0}\".", ps.PrinterName);
            MessageBox.Show(msg, "Print Error");
            return;
        }
        printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
        printDoc.Print();
    }
    // Create a local report for Report.rdlc, load the data,
    //    export the report to an .emf file, and print it.
    public void PrintDataSource(DataTable dt, IEnumerable<ReportParameter> param, System.Drawing.Printing.PrinterSettings ps, ref System.IO.MemoryStream ReportDefinition)
    {
        LocalReport report = new LocalReport();
        this.ps = ps;
        //report.ReportPath = @"Examine.rdlc";
        ReportDefinition.Seek(0, SeekOrigin.Begin);
        report.LoadReportDefinition(ReportDefinition);
        report.DataSources.Add(new ReportDataSource("BossCom_RecordPatient", dt));
        report.SetParameters(param);
        Export(report);
        m_currentPageIndex = 0;
        Print();
    }

    public void Dispose()
    {
        if (m_streams != null)
        {
            foreach (Stream stream in m_streams)
                stream.Close();
            m_streams = null;
        }
    }
}
}