using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Phongkhamnoisoi
{
    public partial class frmPreviewReport : Form
    {
        public frmPreviewReport(ref System.IO.MemoryStream ReportDefinition )
        {
            InitializeComponent(ref ReportDefinition);     
        }
        public void Show_data()
        {   
            this.rv.RefreshReport();
        }

        private void frmPreviewReport_Load(object sender, EventArgs e)
        {

        }
    }
}