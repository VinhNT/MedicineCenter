using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Phongkhamnoisoi
{
    public partial class frmFillingImageConfig : Form
    {
        private String xmlConfigPath = "fillingConfig.xml";
        private int fillTolerance = 30;
        private Color fillColor = new Color();
        
        public frmFillingImageConfig()
        {
            InitializeComponent();
            lstPosition.Items.Clear();
        }

        private void frmFillingImageConfig_Load(object sender, EventArgs e)
        {
            XmlDocument xmlReader = new XmlDocument();
            String strFColor = "FFFFFF";
            byte R, G, B;
            int index;
            try
            {
                xmlReader.Load(xmlConfigPath);
                XmlNodeList xNode = xmlReader.SelectNodes("/xml/fillingconfig");
                if (xNode.Count > 0)
                {
                    fillTolerance = int.Parse(xNode[0]["tolerance"].InnerText);
                    if (strFColor.StartsWith("#")) strFColor = strFColor.Remove(0, 1);
                }
                xNode = xmlReader.SelectNodes("/xml/fillingconfig/fillPoints");
                if (xNode.Count > 0)
                {
                    foreach (XmlNode xn in xNode)
                    {
                        lstPosition.Items.Add(xn.InnerText);                        
                    }
                }
            }
            catch (Exception) { }
            if (strFColor.Length>6) strFColor = strFColor.Substring(0, 5);
            while (strFColor.Length <=5 ) strFColor +="F";
            try
            {                
                R = Byte.Parse(strFColor.Substring(0, 2), System.Globalization.NumberStyles.AllowHexSpecifier);                
                G = Byte.Parse(strFColor.Substring(2, 2), System.Globalization.NumberStyles.AllowHexSpecifier);                
                B = Byte.Parse(strFColor.Substring(4, 2), System.Globalization.NumberStyles.AllowHexSpecifier);
                fillColor = Color.FromArgb(R, G, B);
            }
            catch (Exception) { };
            btnChoseColor.BackColor = fillColor;
            nudTolerances.Value = fillTolerance;
            tbTolerance.Value = fillTolerance;
            lstPosition.MultiColumn = false;
        }
        private void buildXMLConfig()
        {
        }

        private void tbTolerance_Scroll(object sender, EventArgs e)
        {
            nudTolerances.Value = tbTolerance.Value;
        }

        private void nudTolerances_ValueChanged(object sender, EventArgs e)
        {
            tbTolerance.Value = (int) nudTolerances.Value;
        }
    }
}