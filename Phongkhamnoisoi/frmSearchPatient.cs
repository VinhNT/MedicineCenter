using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Phongkhamnoisoi
{
    public partial class frmSearchPatient : Form
    {
    	OleDbConnection refConn;
    	private const string CBO_INDEX_NAME="Tìm kiếm theo tên";    	
    	private const string CBO_INDEX_RECORD_DATE ="Tìm kiếm theo ngày phiếu khám";
    	
    	private const string CBO_AGE_RANGE1 ="Dưới 15 tuổi";    	
    	private const string CBO_AGE_RANGE2 ="Từ 15-30 tuổi";
    	private const string CBO_AGE_RANGE3 ="Từ 30-45 tuổi";
    	private const string CBO_AGE_RANGE4 ="Từ 45-60 tuổi";
    	private const string CBO_AGE_RANGE5 ="Trên 60 tuổi";
    	
        private byte[] intSearchIndex;
        private MemoryStream ms;
        private Image reportImageTitle;
        private string reportTitle;
        
        public frmSearchPatient()
        {
            InitializeComponent();
            this.KeyPreview =true;
            
        }
        
        
        void ChkCareerFilterCheckedChanged(object sender, EventArgs e)
        {
        	cboCareer.Enabled = chkCareerFilter.Checked;
        }
        
        void ChkAgeFilterCheckedChanged(object sender, EventArgs e)
        {
        	cboAge.Enabled = chkAgeFilter.Checked;
        }
        public void setRefFrom(frmPatientRecord refF)
        {
        	this.frm4Ref = refF;
        	this.isSearching =true;
        }
        public void setConnectionRefNLoadData(ref OleDbConnection refCon)
        {        	
        	OleDbCommand myComm;
        	OleDbDataReader myReader;        	
        	this.refConn = refCon;            
        	lstPatientList.Columns.Add("Patient_ProfileDate", "Ngày khám");
            lstPatientList.Columns["Patient_ProfileDate"].Width = 90;
        	lstPatientList.Columns.Add("Patient_Name", "Họ và tên");
        	lstPatientList.Columns.Add("Patient_Address", "Địa chỉ");
        	lstPatientList.Columns.Add("Patient_Age", "Tuổi");
            lstPatientList.Columns["Patient_Age"].Width = 35;
        	lstPatientList.Columns.Add("Patient_Gender", "Giới tính");
            lstPatientList.Columns["Patient_Gender"].Width = 70;
        	lstPatientList.Columns.Add("Patient_Tel", "Điện thoại");
        	lstPatientList.Columns.Add("Patient_Career", "Nghề nghiệp");
        	intSearchIndex = new byte[]{1};
        	lstProfile.View = View.Details;
        	lstProfile.Columns.Clear();
        	lstProfile.Columns.Add("Số bệnh án", (int)(lstProfile.ClientSize.Width*.45));
        	lstProfile.Columns.Add("Ngày khám", (int)(lstProfile.ClientSize.Width*.45));
        	cboSearchIndex.Items.Clear();        	
        	cboSearchIndex.Items.Add(CBO_INDEX_NAME);
            cboSearchIndex.Items.Add(CBO_INDEX_RECORD_DATE);
        	cboAge.Items.Clear();
        	cboAge.Items.Add(CBO_AGE_RANGE1);
        	cboAge.Items.Add(CBO_AGE_RANGE2);
        	cboAge.Items.Add(CBO_AGE_RANGE3);
        	cboAge.Items.Add(CBO_AGE_RANGE4);
        	cboAge.Items.Add(CBO_AGE_RANGE5);
        	cboAge.SelectedIndex =0;
        	cboSearchIndex.SelectedIndex=0;
        	
        	loadPatientData(null);
        	myComm = refConn.CreateCommand();
        	myComm.CommandText = "SELECT Details_ID, Details_Content FROM tblDetailsInfor WHERE Mas_ID=11";
        	myReader = myComm.ExecuteReader();
        	cboCareer.Items.Clear();
        	lstCareerID.Items.Clear();
        	
        	if(myReader.HasRows)
        	{
        		while (myReader.Read())
        		{
        			lstCareerID.Items.Add(myReader.GetInt32(0));
        			cboCareer.Items.Add	(myReader.GetString(1));
        		}
        		cboCareer.SelectedIndex = 0;
        	}
        	cboAge.Enabled=false;
        	cboCareer.Enabled=false;
        	myReader.Close();
            lstPatientList.MultiSelect = false;
        }
        
        public void setConnectionRefNLoadData(ref OleDbConnection refCon, ref Image imgTitle, ref MemoryStream msReportDefinition, string strReportTitle)
        {        	
        	setConnectionRefNLoadData(ref refCon);
        	this.ms = msReportDefinition;
        	this.reportImageTitle = imgTitle;
        	this.reportTitle = strReportTitle;
        	
        }
        private void loadPatientData(string filter)
        {
        	string strSQL;
        	OleDbCommand myComm;
        	OleDbDataReader myReader;
            int nCount=0;
        	myComm =refConn.CreateCommand();
            strSQL = "SELECT Patient_ID, Patient_Name, Patient_Address, Patient_Age, Patient_Gender, Patient_Tel, Details_Content, tblProfile.Pro_Date FROM (tblPatient LEFT OUTER JOIN tblDetailsInfor ON tblPatient.Patient_Career = tblDetailsInfor.Details_ID) LEFT OUTER JOIN tblProfile ON tblPatient.Patient_ID=tblProfile.Pro_PatientID ";
        	
        	if (filter!=null)        	
        		strSQL += "WHERE " + filter + ";";
			else strSQL +=";";

        	myComm.CommandText = strSQL;
        	myReader = myComm.ExecuteReader();
        	nCount = 0;
        	//Patient_Career
        	lstPatientList.Rows.Clear();
        	if (myReader.HasRows)
        	{
        		while (myReader.Read())
        		{                    
                    lstPatientList.Rows.Add(new object[] { myReader.IsDBNull(7)?"":myReader.GetDateTime(7).ToShortDateString(), myReader.IsDBNull(1) ? "" : myReader.GetString(1), myReader.IsDBNull(2) ? "" : myReader.GetString(2), myReader.GetByte(3), myReader.GetByte(4) == 0 ? "Nam" : "Nữ", myReader.IsDBNull(5) ? "" : myReader.GetString(5), myReader.IsDBNull(6) ? "" : myReader.GetString(6) });
                    lstPatientList.Rows[nCount].HeaderCell.Value = myReader.GetInt32(0);
                    nCount++;
        		}
        	}            
        	myReader.Close();
        }
        
        void BtnFilterClick(object sender, EventArgs e)
        {
        	string strFilter;
        	strFilter = null;
        	if (chkAgeFilter.Checked)
        	{
        		switch(cboAge.SelectedIndex)
        		{
        			case 0:
        				strFilter  = "(Patient_Age <15)";
        				break;
        			case 1:
        				strFilter = "(Patient_Age>=15 AND Patient_Age<30)";
        				break;
        			case 2:
        				strFilter = "(Patient_Age>=30 AND Patient_Age<45)";
        				break;        			
        			case 3:
        				strFilter = "(Patient_Age>=30 AND Patient_Age<45)";
        				break;
        			case 4:
        				strFilter ="(Patient_Age <60)";
        				break;
        			default: break;
        		}        		
        	}
        	if (chkCareerFilter.Checked)
        	{
        		if (cboCareer.SelectedIndex!=-1)        		
        		{    			
    				if (strFilter!=null)
	        		{
	        			strFilter += " AND ";	
	        		}
        			strFilter += "(Patient_Career =" + lstCareerID.Items[cboCareer.SelectedIndex]+ ")";
        		}//cbo
        	}//career
        	loadPatientData(strFilter);        	
        }
		private void LoadPatientProfile(string strPatientID)
        {
        	OleDbCommand myCom;
        	OleDbDataReader myReader;
        	ListViewItem objListViewItem;
        	DateTime dt;
        	myCom = refConn.CreateCommand();
        	myCom.CommandText = "SELECT PROFILE_ID, Pro_Date FROM tblProfile WHERE (Pro_PatientID=" + strPatientID + ") AND (IsDeleted=0);";
        	lstProfile.Items.Clear();
        	myReader = myCom.ExecuteReader();
        	if (myReader.HasRows)
        	{
        		while (myReader.Read())
        		{
        			objListViewItem = lstProfile.Items.Add(myReader.GetInt32(0).ToString());
        			if (!myReader.IsDBNull(1))
        			{
        				dt  = myReader.GetDateTime(1);
        				objListViewItem.SubItems.Add(dt.Day.ToString() + "/" + dt.Month.ToString() + "/" + dt.Year.ToString());
        			}
        		}
        	}
        	myReader.Close();
        	myReader.Dispose();
        	myCom.Dispose();
        }
        
		public void DisableControl()
		{
			this.btnViewProfileList.Visible =false;
			this.lstProfile.Visible=false;
			this.btnShowProfile.Visible =false;
			this.lstPatientList.Size = new Size(724, 339);
		}

        private void cboSearchIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSearchIndex.SelectedIndex == 1)
            {
                dtDateIndex.Visible = true;
                txtSearchKey.Visible = false;
            }else
            {
                dtDateIndex.Visible = false;
                txtSearchKey.Visible = true;
            }
        }

        private void dtDateIndex_ValueChanged(object sender, EventArgs e)
        {
            int i, N;            
            string strDateKey;
            strDateKey = dtDateIndex.Value.ToShortDateString();
            N= lstPatientList.Rows.Count;
            for (i = 1; i < N; i++)
            {
                if (String.Compare(strDateKey, lstPatientList.Rows[i].Cells[0].Value.ToString()) == 0)
                {
                    lstPatientList.Rows[i].Selected = true;
                    return;
                }
                else lstPatientList.Rows[i].Selected = false;
            }
        }

    }
}
