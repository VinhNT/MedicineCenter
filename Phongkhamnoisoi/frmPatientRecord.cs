/*
 * Created by VinhNT email: VinhNT_gands@yahoo.com
 * User: Administrator
 * Date: 3/4/2009
 * Time: 9:02 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.IO;

namespace Phongkhamnoisoi
{
	/// <summary>
	/// Description of frmPatientRecord.
	/// </summary>
	public partial class frmPatientRecord : Form
	{
		
		private OleDbConnection refConn;
		private System.Data.OleDb.OleDbDataReader myReader;
		private ComboBox cboShow_Treatment;
		private ComboBox[] cboShow_Diagnosis;
		private const string MSG_DIAGNOSIS = "Chuẩn đoán";
		private const string MSG_TREATMENT = "Kết luận - điều trị";
		private const string FRM_SEPPERATE_ID_NAME ="@: ";
		private const string ERROR_RECORD_ID_IS_EMPTY = "Vui lòng nhập vào mã số phiếu khám";
		private const string ERROR_RECORD_ID_IS_DUPLICATED = "Mã số phiếu khám này đã được sử dụng, vui lòng nhập mã số khác";
		private const string ERROR_PATIENT_NAME_IS_EMPTY ="Tên bệnh nhân đang bị bỏ trống, đề nghị nhập vào";
		private const string ERROR_PATIENT_AGE_IS_NOT_VALID ="Vui lòng kiểm tra lại tuổi, tuổi phải là một số từ 0-99";
		private const string ERROR_NO_DIAGNOS = "Chưa có thông tin chuẩn đoán, vui lòng nhập vào thông tin này";
		private const string ERROR_NO_TREATMENT = "Chưa có thông tin điều trị, vui lòng nhập vào thông tin này";
		private const string ERROR_NO_GENDER_SELECTED = "Chưa chọn thông tin giới tính, vui lòng chọn thông tin này";
		private const string ERROR_CAN_NOT_OPEN_IMAGE="Có lỗi khi hiển thị ảnh, vui lòng chọn ảnh khác";
		private const string COMBO_DIAGNOSIS_NAME="cboShow_Diag_";
		private const string OTHER_DIAGNOSIS_SEPERATE ="[diagnosis]";
		private const string QUES_SURE_TO_DELETE="Chắc chắn muốn xóa?";
		private const string MSG_DELETE_COMPLETED ="Đã xóa xong...";
        //private const 
		private bool isFirstInitital;
		private bool isEditPatient;
		private int  nDiagType;		
		private frmMainForm frmParent;	
		private string strPatientID;
		private MemoryStream ReportDefinition;		
		private Image refImageHeader;
		private List<int> lstDrID;
		string ReportTitle;
		string[] strWidth = new string[] {
						"2.0in",
						"1.8in",
						"1.5in"};
		string[] strHeight = new string[] {
						"1.444in",
						"1.3in",
						"1.083in"};
		
		public frmPatientRecord()
		{			
			InitializeComponent();
			cboPatientGender.SelectedIndex =0;			
			isFirstInitital = true;
			isEditPatient = false;
			this.txtRecordID.Enabled =false;
			txtNote_1.MaxLength = 50;
			txtNote_2.MaxLength = 50;
			txtNote_3.MaxLength = 50;
			txtNote_4.MaxLength = 50;			
			lstDrID = new List<int>();
		}
		
		public void saveData()
		{
			if (!ValidateData() ) 
				return;
			this.txtRecordID.Enabled =false;
			if (this.isFirstInitital)			
				InsertDataRecord();
			else 
				UpdateDataRecord();
			tsbtnPrint.Enabled=true;
			tsbtnPreview.Enabled =true;
            LockPatientInformation(true);
		}
		public void setParent(frmMainForm frmP)
		{
			this.frmParent = frmP;
		}
		Boolean InsertDataRecord()
		{
			string strSQL;
			int intLastID;
			string strFileName, strRelatedID, strTmp, strPrefix;
			int i, n;
			DateTime dt;
			OleDbCommand myCom = new OleDbCommand();
			myCom.Connection = refConn;
			//First insert patient related data record
			if (!isEditPatient)
			{
				intLastID = InsertPatient(myCom);
				if (intLastID ==-1)
				{
					return false;
				}				
			}else
			{
				intLastID = UpdatePatient(myCom);
				if (intLastID ==-1)
				{
					return false;
				}				
			}
			if (!Directory.Exists(Application.StartupPath+ @"\PatientImages"))
			{
				Directory.CreateDirectory(Application.StartupPath+ @"\PatientImages");
			}
			//Insert profile infor
			dt = DateTime.Now;
			strPrefix = Application.StartupPath+ @"\PatientImages\id_" + dt.Year.ToString()+dt.Month.ToString()+dt.Day.ToString()+dt.Hour.ToString()+dt.Minute.ToString()+dt.Second.ToString();			
			strSQL = "INSERT INTO tblProfile(PROFILE_ID, Pro_PatientID, Pro_Date, Pro_Image1, Pro_Image2, Pro_Image3, Pro_Image4, Pro_Comment1, Pro_Comment2, Pro_Comment3,Pro_Comment4, Pro_Other, Pro_ExtraDiagnosis, Pro_ExtraTreatment, Pro_DoctorNote, IsDeleted)VALUES(" + txtRecordID.Text + ", " + intLastID.ToString() + ", '" + dtpRecordedDate.Value.ToShortDateString() + "', ";
			if (pic_Frame1.Image!=null)
			{
				strFileName = strPrefix + txtRecordID.Text+"Picture1.jpg";
				pic_Frame1.Image.Save(strFileName, ImageFormat.Jpeg);
				strSQL +="'" + strFileName + "', ";
			}else 
				strSQL +="NULL, ";
			if (pic_Frame2.Image!=null)
			{
				strFileName = strPrefix + txtRecordID.Text+"Picture2.jpg";
				pic_Frame2.Image.Save(strFileName, ImageFormat.Jpeg);
				strSQL +="'" + strFileName + "', ";
			}else 
				strSQL +="NULL, ";
			if (pic_Frame3.Image!=null)
			{
				strFileName = strPrefix + txtRecordID.Text+"Picture3.jpg";
				pic_Frame3.Image.Save(strFileName, ImageFormat.Jpeg);
				strSQL +="'" + strFileName + "', ";
			}else 
				strSQL +="NULL, ";
			if (pic_Frame4.Image!=null)
			{
				strFileName = strPrefix + txtRecordID.Text+"Picture4.jpg";
				pic_Frame4.Image.Save(strFileName, ImageFormat.Jpeg);
				strSQL +="'" + strFileName + "', ";
			}else 
				strSQL +="NULL, ";
			if (txtNote_1.TextLength>0 && pic_Frame1.Image!=null)
				strSQL +="'" + txtNote_1.Text + "', ";
			else 
				strSQL +="NULL, ";
			
			if (txtNote_2.TextLength>0 && pic_Frame2.Image!=null)
				strSQL +="'" + txtNote_2.Text + "', ";
			else 
				strSQL +="NULL, ";
			if (txtNote_3.TextLength>0 && pic_Frame3.Image!=null)
				strSQL +="'" + txtNote_3.Text + "', ";
			else 
				strSQL +="NULL, ";
			if (txtNote_4.TextLength>0 && pic_Frame4.Image!=null)
				strSQL +="'" + txtNote_4.Text + "', ";
			else 
				strSQL +="NULL, ";			
			strTmp ="";
			n = cboShow_Diagnosis.Length;
			for (i=0; i<n; i++)
			{
				if ((cboShow_Diagnosis[i].SelectedIndex==-1)&&(cboShow_Diagnosis[i].Text.Length>0))
				{
					if (strTmp.Length>0)
						strTmp+= (OTHER_DIAGNOSIS_SEPERATE + cboShow_Diagnosis[i].Name.Substring(COMBO_DIAGNOSIS_NAME.Length) +FRM_SEPPERATE_ID_NAME +cboShow_Diagnosis[i].Text);
					else
						strTmp = cboShow_Diagnosis[i].Name.Substring(COMBO_DIAGNOSIS_NAME.Length)+FRM_SEPPERATE_ID_NAME+cboShow_Diagnosis[i].Text;
				}
			}
			if ((cboShow_Treatment.SelectedIndex==-1)&&(cboShow_Treatment.Text.Length>0))
			{
				if (strTmp.Length>0) 					
						strTmp+= (OTHER_DIAGNOSIS_SEPERATE + cboShow_Treatment.Name.Substring(COMBO_DIAGNOSIS_NAME.Length) +FRM_SEPPERATE_ID_NAME +cboShow_Treatment.Text);
					else
						strTmp = cboShow_Treatment.Name.Substring(COMBO_DIAGNOSIS_NAME.Length)+FRM_SEPPERATE_ID_NAME+cboShow_Treatment.Text;
			}
			//strsql = strSQL + "@Pro_Other);"
			if (strTmp.Length==0)
				strSQL+="NULL, ";
			else
				strSQL +="'" + strTmp + "', ";
			if (txtExtraDiagnosis.TextLength>0) 
				strSQL += "'" + txtExtraDiagnosis.Text + "', ";
			else 
				strSQL += " NULL, ";
			if (txtExtraTreatment.TextLength>0)
				strSQL += "'" + txtExtraTreatment.Text + "', ";
			else
				strSQL += " NULL, ";
			if (cboExtraNote.Text.Length >0)
				strSQL += "'" + cboExtraNote.Text + "', 0);";
			else
				strSQL += " NULL, 0);";
			
			//myCom.Parameters.Add(new OleDbParameter(Pro_Other
			myCom.CommandText = strSQL;
			//txtPatientName.Text = strSQL;
			myCom.ExecuteNonQuery();
			//return;
			//Generate diagnosis
			n = cboShow_Diagnosis.Length;
			
			for (i=0; i<n; i++)
			{
				if (cboShow_Diagnosis[i].SelectedIndex>=0)
				{
					strRelatedID =cboShow_Diagnosis[i].Text.Substring(0,  cboShow_Diagnosis[i].Text.IndexOf(FRM_SEPPERATE_ID_NAME));
					strSQL = "INSERT INTO tblProfileDetails(Profile_ID, Profile_Related) VALUES(" + txtRecordID.Text +", " + strRelatedID + ");";
					myCom.CommandText = strSQL;
					myCom.ExecuteNonQuery();				
				}
			}			
			if (cboShow_Treatment.SelectedIndex>=0)
			{
				strRelatedID =cboShow_Treatment.Text.Substring(0,  cboShow_Treatment.Text.IndexOf(FRM_SEPPERATE_ID_NAME));
				strSQL = "INSERT INTO tblProfileDetails(Profile_ID, Profile_Related) VALUES(" + txtRecordID.Text +", " + strRelatedID + ");";
				myCom.CommandText = strSQL;
				myCom.ExecuteNonQuery();
			}
			if (cboDrName.SelectedIndex>=0)
			{
				strRelatedID =lstDrID[cboDrName.SelectedIndex].ToString();
				strSQL = "INSERT INTO tblProfileDetails(Profile_ID, Profile_Related) VALUES(" + txtRecordID.Text +", " + strRelatedID + ");";
				myCom.CommandText = strSQL;
				myCom.ExecuteNonQuery();
			}
			tsbtnSave.Enabled =false;
			tsbtnPreview.Enabled =true;
			tsbtnPrint.Enabled =true;
			//finish
            return true;
		}
		void UpdateDataRecord()
		{
			
		}
		int InsertPatient(OleDbCommand myComm)
		{
			string strSQL;
			int intLastID;
						
			strSQL = "SELECT MAX(Patient_ID) FROM tblPatient";
			myComm.CommandText = strSQL;			
			myReader = myComm.ExecuteReader();
			if (myReader.HasRows)
			{
				myReader.Read();
				if ( myReader.IsDBNull(0) ) 
					intLastID=1;
				else
					intLastID = myReader.GetInt32(0)+1;
					
			}else intLastID = 1;
			myReader.Close();
			
			strSQL = "INSERT INTO tblPatient (Patient_ID, Patient_Name, Patient_Address, Patient_Age, Patient_Gender, Patient_Tel, Patient_Career) VALUES(" + intLastID.ToString() +", '" + txtPatientName.Text + "', ";
			if (txtPatientAddress.Text.Length<=0)
			{
				strSQL += "NULL, " + txtPatientAge.Text + ", ";
			}
			else
			{
				strSQL += "'" + txtPatientAddress.Text + "', " + txtPatientAge.Text +", ";
			}
			strSQL += cboPatientGender.SelectedIndex.ToString() + ", ";
			if (txtPatientPhone.Text.Length<0) 
			{
				strSQL += "NULL, ";
			}
			else
			{
				strSQL += "'" + txtPatientPhone.Text  + "', ";
			}
			if (cboPatientCareer.SelectedIndex<0)
			{
				strSQL += "NULL);";
			}
			else
			{
				strSQL += lstCareerID.Items[cboPatientCareer.SelectedIndex].ToString()  + ");";
			}
			myComm.CommandText = strSQL;
			//cboShow_Treatment.Text = strSQL;
			myComm.Connection = refConn;
			try{
				myComm.ExecuteNonQuery();
			}catch (Exception e)
			{
				MessageBox.Show (e.Message.ToString());
				return -1;
			}
			return intLastID;
		}
		int UpdatePatient(OleDbCommand myCom)
		{
			string strSQL ="";
			strSQL = "UPDATE tblPatient SET Patient_Name='" + txtPatientName.Text + "', Patient_Address='" + txtPatientAddress.Text + "', Patient_Age=" + txtPatientAge.Text +", Patient_Gender =" + cboPatientGender.SelectedIndex.ToString() +", Patient_Tel=";
			if (txtPatientPhone.TextLength==0)
			{
				strSQL += "NULL, Patient_Career=";
			}else 
			{
				strSQL+= txtPatientPhone.Text + ", Patient_Career=";
			}
			if (cboPatientCareer.SelectedIndex!=-1)
				strSQL += lstCareerID.Items[cboPatientCareer.SelectedIndex].ToString();
			else 
				strSQL +="NULL";
			strSQL += " WHERE Patient_ID=" + strPatientID + ";";
			myCom.CommandText = strSQL;
			try{
				myCom.ExecuteNonQuery();
			}catch(Exception e)
			{				
				MessageBox.Show (e.Message);
				return -1;
			}
			return int.Parse(strPatientID);
			
		}
		bool ValidateData()
		{
			int i;
			if (txtRecordID.Text.Length<=0)
			{
				MessageBox.Show(ERROR_RECORD_ID_IS_EMPTY, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtRecordID.Focus();
				return false;
			}
			if (checkReferenceKey("tblProfile", "PROFILE_ID", txtRecordID.Text, false))
			{
				MessageBox.Show(ERROR_RECORD_ID_IS_DUPLICATED, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtRecordID.Focus();
				return false;
			}
			if (txtPatientName.Text.Length<=0)
			{
				MessageBox.Show(ERROR_PATIENT_NAME_IS_EMPTY, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtPatientName.Focus();
				return false;
			}
			if (txtPatientAge.Text.Length<=0)
			{
				MessageBox.Show(ERROR_PATIENT_AGE_IS_NOT_VALID, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtPatientAge.Focus();
				return false;
			}
			if (cboPatientGender.SelectedIndex<0)
			{
				MessageBox.Show(ERROR_NO_GENDER_SELECTED, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				cboPatientGender.Focus();
				return false;
			}
			try{
				i = int.Parse(txtPatientAge.Text);
			}catch(Exception)
			{
				MessageBox.Show(ERROR_PATIENT_AGE_IS_NOT_VALID, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtPatientAge.Focus();
				return false;
			}
			/*
			if (cboShow_Treatment.SelectedIndex==-1)
			{
				MessageBox.Show(ERROR_NO_TREATMENT, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				cboShow_Treatment.Focus();
				return false;
			}*/
			return true;
		}
		private Boolean checkReferenceKey(string tablename, string fieldname, string key, Boolean isString)
		{
			Boolean	tmp;
			OleDbCommand myCom = new OleDbCommand();
			myCom.Connection = this.refConn;
			System.Data.OleDb.OleDbDataReader myReader;
			if (isString) 
			{
				myCom.CommandText = "SELECT * FROM " + tablename + " WHERE " + fieldname + " ='" + key + "';";
			}else
			{
				myCom.CommandText = "SELECT * FROM " + tablename + " WHERE " + fieldname + " =" + key + ";";
			}
			myReader = myCom.ExecuteReader();
			tmp = myReader.HasRows;
			myReader.Close();
			return tmp;			
		}//checkReferenceKey
		private TextBox txtExtraDiagnosis;
		private TextBox txtExtraTreatment;
		private ComboBox cboExtraNote;
		
		public void setReferenceConnectNLoadData(ref OleDbConnection refParent, ref MemoryStream ReportDefinition, ref Image imgHeader, string ReportTitle)
		{
			string strSQL;
			int pType, cType;
			int YPoint, i;
			Button btnRefTmp;
			ComboBox cboShow_Diag = new ComboBox();
			cboShow_Treatment = new ComboBox();
			Label lblShow_Diag;
			
			OleDbCommand myCom = new OleDbCommand();
			OleDbDataReader myReader;
			pType = -1;
			this.refConn = refParent;
			this.refImageHeader = CopyImage(imgHeader);
			this.ReportTitle = ReportTitle;
			strSQL = "SELECT tblMasterInfor.M_ID, tblMasterInfor.M_Type, tblMasterInfor.M_Name, tblDetailsInfor.Details_ID, tblDetailsInfor.Details_Content FROM tblMasterInfor LEFT JOIN tblDetailsInfor ON tblMasterInfor.M_ID = tblDetailsInfor.Mas_ID WHERE tblMasterInfor.M_Type=" + frmAddNewMasterItem.ENUM_INTEGER_CATOGERY_DIAGNOSIS.ToString() + ";";
			myCom.CommandText = strSQL;
			myCom.Connection = refParent;
			myReader = myCom.ExecuteReader();
			YPoint = 453;nDiagType=0;
			lstComboName.Items.Clear();
			txtExtraDiagnosis = new TextBox();
			cboExtraNote = new ComboBox();
            
			txtExtraTreatment = new TextBox();
			if (myReader.HasRows)
			{
				while (myReader.Read())
				{
					cType  = myReader.GetInt32(0);
					if (cType!=pType)
					{//new combo						
						cboShow_Diag = new ComboBox();
						cboShow_Diag.Cursor = Cursors.Hand;
						cboShow_Diag.FlatStyle = FlatStyle.Popup;
						cboShow_Diag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						cboShow_Diag.FormattingEnabled = true;
						cboShow_Diag.Name = cType.ToString();
						cboShow_Diag.Location = new System.Drawing.Point(180, YPoint);
						lstComboName.Items.Add(COMBO_DIAGNOSIS_NAME + myReader.GetInt32(0).ToString());
						cboShow_Diag.Name = COMBO_DIAGNOSIS_NAME + myReader.GetInt32(0).ToString();
						cboShow_Diag.Size = new System.Drawing.Size(430, 28);						
						
						lblShow_Diag = new Label();
						lblShow_Diag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
						lblShow_Diag.Location = new System.Drawing.Point(99, YPoint);
                        lblShow_Diag.Name = "lbl"+COMBO_DIAGNOSIS_NAME + nDiagType.ToString();
						lblShow_Diag.Size = new System.Drawing.Size(100, 23);
						lblShow_Diag.Text = myReader.GetString(2);
						pType = cType;
						YPoint += 30;
						nDiagType++;
						this.Controls.Add(cboShow_Diag);
						this.Controls.Add(lblShow_Diag);
					}//new item
					if (cboShow_Diag!=null)
					{
						//tblDetailsInfor.Details_ID, tblDetailsInfor.Details_Content
						if (!myReader.IsDBNull(3))
						{
							cboShow_Diag.Items.Add(myReader.GetValue(3).ToString() + FRM_SEPPERATE_ID_NAME + myReader.GetValue(4).ToString());
						}
					}
				}//read one record				
			}//has rows
			txtExtraDiagnosis.Location= new System.Drawing.Point(180, YPoint);
			txtExtraDiagnosis.Size = new System.Drawing.Size(430, 46);
			txtExtraDiagnosis.Multiline =true;
			//txtExtraDiagnosis.BorderStyle
			YPoint += 52;
			this.cboShow_Diagnosis = new ComboBox[nDiagType];
			for (i=0; i<nDiagType; i++)
			{
				this.cboShow_Diagnosis[i] = (ComboBox)this.Controls[lstComboName.Items[i].ToString()];
			}
			myReader.Close();
			strSQL = "SELECT tblMasterInfor.M_ID, tblMasterInfor.M_Type, tblMasterInfor.M_Name, tblDetailsInfor.Details_ID, tblDetailsInfor.Details_Content FROM tblMasterInfor LEFT JOIN tblDetailsInfor ON tblMasterInfor.M_ID = tblDetailsInfor.Mas_ID WHERE tblMasterInfor.M_Type=" + frmAddNewMasterItem.ENUM_INTEGER_CATOGERY_TREATMENT.ToString() + ";";
			myCom.CommandText = strSQL;
			myCom.Connection = refParent;
			myReader = myCom.ExecuteReader();			
			lblLastTreatment.Location= new System.Drawing.Point(1, YPoint);
			
			cboShow_Treatment = new ComboBox();
			cboShow_Treatment.Cursor = Cursors.Hand;
			cboShow_Treatment.FlatStyle = FlatStyle.Popup;
			cboShow_Treatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			cboShow_Treatment.FormattingEnabled = true;
			cboShow_Treatment.Location = new System.Drawing.Point(180, YPoint);
			cboShow_Treatment.Name = "cboShow_Treatment";
			cboShow_Treatment.Size = new System.Drawing.Size(430, 28);
			nDiagType ++;
			this.Controls.Add(cboShow_Treatment);
			
			cboShow_Treatment.Items.Clear();
			
			if (myReader.HasRows)
			{
				while (myReader.Read())
				{
					if (!myReader.IsDBNull(3))
					{
						cboShow_Treatment.Items.Add(myReader.GetValue(3).ToString() + FRM_SEPPERATE_ID_NAME + myReader.GetValue(4).ToString());						
					}
				}
			}			
			myReader.Close();
			YPoint += 30;
			txtExtraTreatment.Size = new System.Drawing.Size(430, 46);
			txtExtraTreatment.Location= new System.Drawing.Point(180, YPoint);
			txtExtraTreatment.Multiline = true;
			YPoint+=48;
			strSQL = "SELECT tblMasterInfor.M_ID, tblMasterInfor.M_Type, tblMasterInfor.M_Name, tblDetailsInfor.Details_ID, tblDetailsInfor.Details_Content FROM tblMasterInfor LEFT JOIN tblDetailsInfor ON tblMasterInfor.M_ID = tblDetailsInfor.Mas_ID WHERE tblMasterInfor.M_Type=" + frmAddNewMasterItem.ENUM_INTEGER_CATOGERY_CAREER.ToString() + ";";
			myCom.CommandText = strSQL;			
			myReader = myCom.ExecuteReader();
			cboPatientCareer.Items.Clear();
			lstCareerID.Items.Clear();
			lblDoctorNote.Location = new System.Drawing.Point(1, YPoint);
			cboExtraNote.Size = new System.Drawing.Size(430, 46);
			cboExtraNote.Location= new System.Drawing.Point(180, YPoint);
			//txtPatientName.Text = strSQL;
			
			if (myReader.HasRows)
			{
				while (myReader.Read())
				{
					if (!myReader.IsDBNull(3))
					{
						cboPatientCareer.Items.Add(myReader.GetValue(4).ToString());
						lstCareerID.Items.Add(myReader.GetValue(3).ToString());
					}
				}
			}
			myReader.Close();
			GenerateRecordID();
			
			myCom.CommandText = "SELECT Details_ID, Details_Content FROM tblDetailsInfor WHERE Mas_ID=13;" ;
			myReader = myCom.ExecuteReader();
			if (myReader.HasRows)
			{
				while (myReader.Read())
				{
					lstDrID.Add(myReader.GetInt32(0));
					cboDrName.Items.Add (myReader.GetString(1));					
				}
			};
			myReader.Close();
			for (i=1; i<5; i++)
			{
				btnRefTmp = (Button)this.Controls["btn_pic_Frame" + i.ToString()];
				btnRefTmp.Click += new EventHandler(btnBrowse4Image_Click);
			}

            myCom.CommandText = "SELECT Details_ID, Details_Content FROM tblDetailsInfor WHERE Mas_ID=15;";
            myReader = myCom.ExecuteReader();
            cboExtraNote.Items.Clear();
            if (myReader.HasRows)
            {
                while (myReader.Read())
                {                    
                    cboExtraNote.Items.Add(myReader.GetString(1));
                }
            };
            myReader.Close();

			this.Controls.Add(txtExtraDiagnosis);
			this.Controls.Add(txtExtraTreatment);			
			this.Controls.Add(cboExtraNote);
			this.ReportDefinition = ReportDefinition;
			this.Height = this.cboExtraNote.Top+this.cboExtraNote.Height + 40;
		}//setReferenceConnectNLoadData	
		void MnuSaveRecordClick(object sender, EventArgs e)
		{
			this.saveData();
		}//MnuSaveRecordClick
		void LblCaptureLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			frmCaptureImage frmTmp = new frmCaptureImage(this, int.Parse(nudNoOfPicture.Text));
			frmTmp.ShowDialog();
			frmTmp.Top = this.Top;
			frmTmp.Left = this.Left;
			frmTmp = null;
		}
        private void tsbtnPrint_Click(object sender, EventArgs e)
        {           	
        	DialogResult dr;
        	MemoryStream ms = CreateReportDefinition();
        	ReportPrinter rp = new ReportPrinter();        	
	    	dr =prtGetPrinterSetting.ShowDialog();
	        if (dr == DialogResult.Cancel) return;        	
        	rp.PrintDataSource(createDataTable4Report(), createParameter4Report(), prtGetPrinterSetting.PrinterSettings, ref ms);
        	rp.Dispose();
        }
        private void filterImage()
        {
            
        }
/*
        private string[] createDiagnosisString()
        {
            int i, n;
            string[] result;
            bool isFirst = true;
            string strTmp1, strTmp2;
            n = cboShow_Diagnosis.Length;
            result = new string[2];
            strTmp1 = "";
            strTmp2 = "";
            for (i = 0; i < n; i++)
            {            	
                if (cboShow_Diagnosis[i].Text.Length > 0)
                {
                    if (isFirst)
                    {
                    	isFirst = false;
                        if (cboShow_Diagnosis[i].SelectedIndex >= 0)
                        {
                            strTmp2 = ((Label)this.Controls["lbl" + COMBO_DIAGNOSIS_NAME + i.ToString()]).Text;
                            strTmp1 = cboShow_Diagnosis[i].Text.Substring(cboShow_Diagnosis[i].Text.IndexOf(FRM_SEPPERATE_ID_NAME) + FRM_SEPPERATE_ID_NAME.Length);
                        }
                        else
                        {
                            strTmp2 = ((Label)this.Controls["lbl" + COMBO_DIAGNOSIS_NAME + i.ToString()]).Text;
                            strTmp1 = cboShow_Diagnosis[i].Text;
                        }
                    }
                    else
                    {
                        if (cboShow_Diagnosis[i].SelectedIndex >= 0)
                        {
                            strTmp2 += "\r\n" + ((Label)this.Controls["lbl" + COMBO_DIAGNOSIS_NAME + i.ToString()]).Text;
                            strTmp1 += "\r\n" + cboShow_Diagnosis[i].Text.Substring(cboShow_Diagnosis[i].Text.IndexOf(FRM_SEPPERATE_ID_NAME) + FRM_SEPPERATE_ID_NAME.Length);
                        }
                        else
                        {
                            strTmp2 += "\r\n" + ((Label)this.Controls["lbl" + COMBO_DIAGNOSIS_NAME + i.ToString()]).Text;
                            strTmp1 += "\r\n" + cboShow_Diagnosis[i].Text;
                        }
                    }
                    //cboShow_Diagnosis
                }
            }
            result[0] = strTmp1;
            result[1] = strTmp2;
            return result;
        }
*/
        private string createDiagnosisString()
        {
            int i, n;
            bool isFirst = true;
            string strTmp;
            n = cboShow_Diagnosis.Length;
            strTmp = "";
            for (i = 0; i < n; i++)
            {
                if (cboShow_Diagnosis[i].Text.Length > 0)
                {
                    if (isFirst)
                    {
                        isFirst = false;
                        strTmp = ((Label)this.Controls["lbl" + COMBO_DIAGNOSIS_NAME + i.ToString()]).Text + ":   " + cboShow_Diagnosis[i].Text.Substring(cboShow_Diagnosis[i].Text.IndexOf(FRM_SEPPERATE_ID_NAME) + FRM_SEPPERATE_ID_NAME.Length);
                    }
                    else
                    {

                        strTmp += "\r\n" + ((Label)this.Controls["lbl" + COMBO_DIAGNOSIS_NAME + i.ToString()]).Text + ":    " + cboShow_Diagnosis[i].Text.Substring(cboShow_Diagnosis[i].Text.IndexOf(FRM_SEPPERATE_ID_NAME) + FRM_SEPPERATE_ID_NAME.Length);
                    }
                    //cboShow_Diagnosis
                }
            }
            return strTmp;
        }

        private void tsbtnPreview_Click(object sender, EventArgs e)        	
        {   
        	ReportViewer rv;
        	MemoryStream ms = CreateReportDefinition();
        	frmPreviewReport frmTmp = new frmPreviewReport(ref ms);
            
            rv = (ReportViewer)frmTmp.Controls["rv"];
            rv.LocalReport.SetParameters(createParameter4Report());
            rv.LocalReport.DataSources.Add(new ReportDataSource("BossCom_RecordPatient", createDataTable4Report()));            
            frmTmp.Show_data();
            frmTmp.ShowDialog();            
        }//Print the examine record
        
        private DataTable createDataTable4Report()
        {//Populate data before printing
        	
        	DataTable dt4Adding = new DataTable();
        	dt4Adding.Columns.Add("DrName");            
            dt4Adding.Columns.Add("Image_1", Type.GetType("System.Byte[]"));
            dt4Adding.Columns.Add("Image_2", Type.GetType("System.Byte[]"));
            dt4Adding.Columns.Add("Image_3", Type.GetType("System.Byte[]"));
            dt4Adding.Columns.Add("Image_4", Type.GetType("System.Byte[]"));

            dt4Adding.Columns.Add("Note1");
            dt4Adding.Columns.Add("Note2");
            dt4Adding.Columns.Add("Note3");
            dt4Adding.Columns.Add("Note4");
            dt4Adding.Columns.Add("PatientAddress");
            dt4Adding.Columns.Add("PatientAge");
            dt4Adding.Columns.Add("PatientGender");
            dt4Adding.Columns.Add("PatientName");
            dt4Adding.Columns.Add("PatientTel");            
            dt4Adding.Columns.Add("RecordID");//Image_Header
			dt4Adding.Columns.Add("Image_Header", Type.GetType("System.Byte[]"));
			
            DataRow dr = dt4Adding.NewRow();
            dr["DrName"] = cboDrName.Text;
            dr["Note1"] = txtNote_1.Text;
            dr["Note2"] = txtNote_2.Text;
            dr["Note3"] = txtNote_3.Text;
            dr["Note4"] = txtNote_4.Text;            

            dr["Image_1"] = imageToByteArray(this.pic_Frame1.Image);
            dr["Image_2"] = imageToByteArray(this.pic_Frame2.Image);
            dr["Image_3"] = imageToByteArray(this.pic_Frame3.Image);
            dr["Image_4"] = imageToByteArray(this.pic_Frame4.Image);
            dr["Image_Header"] = imageToByteArray(this.refImageHeader);
            dr["PatientAddress"] = txtPatientAddress.Text;
            dr["PatientAge"] = txtPatientAge.Text;
            dr["PatientGender"] = cboPatientGender.Text;
            dr["PatientName"] = txtPatientName.Text;
            dr["PatientTel"] = txtPatientPhone.Text;            
            dr["RecordID"] = txtRecordID.Text;
            dt4Adding.Rows.Add(dr);
            return dt4Adding;
            
        }//createDataTable4Report
        private List<ReportParameter> createParameter4Report()
        {
        	List<ReportParameter> param;
        	param = new List<ReportParameter>();
            //string[] strDianosis;
            
            //strDianosis = createDiagnosisString();
            param.Add(new ReportParameter("Diagnosis", createDiagnosisString(), true));
            //param.Add(new ReportParameter("Diagnosis", strDianosis[0], true));
            //param.Add(new ReportParameter("rptDiagnosisCaption", strDianosis[1], true));
            if (cboShow_Treatment.SelectedIndex>=0)
            {
            	param.Add(new ReportParameter("Treatment", cboShow_Treatment.Text.Substring(cboShow_Treatment.Text.IndexOf(FRM_SEPPERATE_ID_NAME)+FRM_SEPPERATE_ID_NAME.Length)));
            }else
            	param.Add(new ReportParameter("Treatment", cboShow_Treatment.Text));

            param.Add(new ReportParameter("LastDrName", cboDrName.SelectedIndex==-1?"":cboDrName.Text, true));
            //param.Add(new ReportParameter("ReportTitle", "Test title", true));
            param.Add(new ReportParameter("ReportTitle", this.ReportTitle, true));
            param.Add(new ReportParameter("rptRecordID", "SỐ PHIẾU:", true));
            param.Add(new ReportParameter("rptPatientName", "HỌ TÊN BỆNH NHÂN:", true));
            param.Add(new ReportParameter("rptPatientAddress", "ĐỊA CHỈ:", true));
            param.Add(new ReportParameter("rptDortor", "BÁC SĨ NỘI SOI", true));
            param.Add(new ReportParameter("rptPatientAge", "TUỔI:", true));
            param.Add(new ReportParameter("rptPatientGender", "GIỚI TÍNH:", true));
            param.Add(new ReportParameter("rptPatientTel", "ĐIỆN THOẠI:", true));
            param.Add(new ReportParameter("rptDiagnosis", "KẾT LUẬN:", true));
            param.Add(new ReportParameter("rptTreatment", "HƯỚNG ĐIỀU TRỊ:", true));
            param.Add(new ReportParameter("lbtDoctorNote", "LỜI DẶN CỦA BÁC SĨ:", true));
            param.Add(new ReportParameter("rptExtraDiagnosis", txtExtraDiagnosis.Text, true));
            param.Add(new ReportParameter("rptExtraTreatment", txtExtraTreatment.Text, true));
            param.Add(new ReportParameter("rptDoctorNote", cboExtraNote.Text, true));
            param.Add(new ReportParameter("rptRecordDate", "Ngày "+dtpRecordedDate.Value.Day.ToString() + " tháng " +dtpRecordedDate.Value.Month.ToString() + " năm " + dtpRecordedDate.Value.Year.ToString()  , true));
            param.Add(new ReportParameter("rptComment", "Lưu ý: Mang theo phiếu này khi đến khám lại lần sau", true));
            param.Add(new ReportParameter("rptImageCaption", "", true));
            if (int.Parse(nudNoOfPicture.Text) == 2 || int.Parse(nudNoOfPicture.Text) == 4)
                param.Add(new ReportParameter("rptImageCaption", "Hình ảnh\nnội soi", true));
            else
                param.Add(new ReportParameter("rptImageCaption", "", true));
            return param;
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms;
            if (imageIn == null) return null;
            ms = new MemoryStream();            
            imageIn.Save(ms, ImageFormat.Jpeg);
        	return ms.ToArray();           
        }
		
		void Button1Click(object sender, EventArgs e)
		{
			frmSearchPatient frmTmp = new frmSearchPatient();
			frmTmp.setConnectionRefNLoadData(ref this.refConn);
			frmTmp.setRefFrom(this);
			frmTmp.DisableControl();
			frmTmp.ShowDialog();			
			frmTmp = null;
		}
		void btnBrowse4Image_Click(object sender, EventArgs e)
		{
			Button btnTmp;
			PictureBox picTmp;
			string strName;
			DialogResult result;
			FileStream fs;
			btnTmp = (Button)sender;
			strName = btnTmp.Name.Substring(btnTmp.Name.IndexOf("pic"));
			picTmp = (PictureBox)this.Controls[strName];
			result = this.opdGetImage.ShowDialog();
			if (result== DialogResult.OK)
			{
				try{
					fs = new FileStream(opdGetImage.FileName, FileMode.Open);
					picTmp.Image = CopyImage(Image.FromStream (fs));
					fs.Close();
				}catch(System.IO.IOException)
				{
					MessageBox.Show(ERROR_CAN_NOT_OPEN_IMAGE, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);						
				}				
			}
		}
		
		public void LoadPatient(string patientID)
		{
			string strSQL;OleDbCommand myCom;
			OleDbDataReader myReader;
			int i, n, c;
			this.isEditPatient =true;
			strSQL = "SELECT Patient_Name, Patient_Address, Patient_Age, Patient_Gender, Patient_Tel, Patient_Career FROM tblPatient WHERE Patient_ID=" + patientID + ";";
			myCom = refConn.CreateCommand();
			myCom.CommandText = strSQL;
			myReader = myCom.ExecuteReader();
			if (myReader.HasRows)
			{
				myReader.Read();
				strPatientID = patientID;
				txtPatientName.Text = myReader.GetString(0);
				txtPatientAddress.Text = myReader.IsDBNull(1)?"":myReader.GetString(1);
				txtPatientAge.Text = myReader.GetByte(2).ToString();
				cboPatientGender.SelectedIndex = myReader.GetByte(3);
				txtPatientPhone.Text = myReader.IsDBNull(4)?"":myReader.GetString(4);
				if (!myReader.IsDBNull(5))
				{
					n = lstCareerID.Items.Count-1;
					c = myReader.GetInt32(5);
					for(i=0; i<n; i++)
					{
						if (int.Parse(lstCareerID.Items[i].ToString())==c) 
						{
							cboPatientCareer.SelectedIndex =i;
							break;
						}
					}					    
				}else cboPatientCareer.SelectedIndex =-1;
				strPatientID = patientID;
			}
		}
		
		void NudNoOfPictureValueChanged(object sender, EventArgs e)
		{
			byte i, n;
			PictureBox picTmp;
			TextBox txtTmp;
			Button btnTmp;
			n = Byte.Parse(nudNoOfPicture.Value.ToString());
			i=4;
			while (i>0)
			{
				picTmp = (PictureBox)this.Controls["pic_Frame" + i.ToString()];
				btnTmp = (Button) this.Controls["btn_pic_Frame" + i.ToString()];				
				txtTmp =(TextBox) this.Controls["txtNote_" + i.ToString()];
				if (i>n)
				{
					picTmp.Visible =false;
					txtTmp.Visible=false;
					btnTmp.Visible =false;
				}else
				{
					picTmp.Visible =true;
					txtTmp.Visible=true;
					btnTmp.Visible =true;
				}
				i--;
			}
		}		
		void FrmPatientRecordLoad(object sender, EventArgs e)
		{
			this.NudNoOfPictureValueChanged(null,null);
			cboImageSize.Items.Clear();			
			cboImageSize.Items.Add("5.08x3.66cm");
			cboImageSize.Items.Add("4.57x3.3cm");
			cboImageSize.Items.Add("3.81x2.75cm");
            cboImageSize.SelectedIndex = 0;
		}
		
		private Bitmap CopyImage(Image value)
		{			
			Bitmap bm = new Bitmap(value.Width, value.Height, PixelFormat.Format32bppArgb);
			Graphics g= Graphics.FromImage(bm);
			g.DrawImage(value, 0, 0, value.Width, value.Height);
			g.Dispose();
			return bm;
		}
		private Image DupplicateImage(Image value)
		{			
			Bitmap bm = new Bitmap(value.Width, value.Height, PixelFormat.Format32bppArgb);
			Graphics g= Graphics.FromImage(bm);
			g.DrawImage(value, 0, 0, value.Width, value.Height);
			g.Dispose();
			return bm;
		}
		private char[] byte2char(byte[] source)
		{			
			int i, n;
			char [] des;
			n  = source.Length-3;
			des = new char[n];
			for (i=0; i<n; i++) 
				des[i] = (char)source[i+3];
			return des;				
		}
		
		private MemoryStream CreateReportDefinition()
		{
			string strTmp;
        	string strImageBefore, strImage;
        	string CloseTag = "</Image>";        	
        	int firstIndex, LastIndex, nPic;        	
        	MemoryStream ms;
        	BinaryWriter bw;

        	nPic = int.Parse(nudNoOfPicture.Value.ToString());
        	strTmp = new string(byte2char(this.ReportDefinition.ToArray()));
            
        	if (cboImageSize.SelectedIndex==-1) cboImageSize.SelectedIndex=0;
        	firstIndex= strTmp.IndexOf("<Image Name=\"picFrame1\">");
        	LastIndex = strTmp.IndexOf(CloseTag, firstIndex) + CloseTag.Length;        	
        	strImageBefore = strTmp.Substring(firstIndex, LastIndex-firstIndex);
        	strImage = strImageBefore;
        	strImage = strImage.Replace("2in", strWidth[cboImageSize.SelectedIndex]);
        	strImage = strImage.Replace("1.444in", strHeight[cboImageSize.SelectedIndex]);
        	strTmp = strTmp.Replace(strImageBefore, strImage);
        	
        	firstIndex= strTmp.IndexOf("<Image Name=\"picFrame2\">");
        	LastIndex = strTmp.IndexOf(CloseTag, firstIndex) + CloseTag.Length;        	
        	strImageBefore = strTmp.Substring(firstIndex, LastIndex-firstIndex);
        	strImage = strImageBefore;
        	strImage = strImage.Replace("2in", strWidth[cboImageSize.SelectedIndex]);
        	strImage = strImage.Replace("1.444in", strHeight[cboImageSize.SelectedIndex]);
        	strTmp = strTmp.Replace(strImageBefore, strImage);
            
			firstIndex= strTmp.IndexOf("<Image Name=\"picFrame3\">");
        	LastIndex = strTmp.IndexOf(CloseTag, firstIndex) + CloseTag.Length;        	
        	strImageBefore = strTmp.Substring(firstIndex, LastIndex-firstIndex);
        	strImage = strImageBefore;
            if (nPic > 2)
            {
                strImage = strImage.Replace("2in", strWidth[cboImageSize.SelectedIndex]);
                strImage = strImage.Replace("1.444in", strHeight[cboImageSize.SelectedIndex]);
            }
            else
            {
                strImage = strImage.Replace("<Sizing>Fit</Sizing>", "<Sizing>AutoSize</Sizing>");
            }
        	strTmp = strTmp.Replace(strImageBefore, strImage);
        	
        	firstIndex= strTmp.IndexOf("<Image Name=\"picFrame4\">");
        	LastIndex = strTmp.IndexOf(CloseTag, firstIndex) + CloseTag.Length;        	
        	strImageBefore = strTmp.Substring(firstIndex, LastIndex-firstIndex);
        	strImage = strImageBefore;
        	if (nPic >2) 
        	{
        		strImage = strImage.Replace("2in", strWidth[cboImageSize.SelectedIndex]);
        		strImage = strImage.Replace("1.444in", strHeight[cboImageSize.SelectedIndex]);
        	}else
        	{
        		strImage = strImage.Replace("<Sizing>Fit</Sizing>", "<Sizing>AutoSize</Sizing>");
        	}        	
            /*
        	strTmp = strTmp.Replace(strImageBefore, strImage);
            
        	firstIndex= strTmp.IndexOf("<Image Name=\"picFrame5\">");
        	LastIndex = strTmp.IndexOf(CloseTag, firstIndex) + CloseTag.Length;        	
        	strImageBefore = strTmp.Substring(firstIndex, LastIndex-firstIndex);
        	strImage = strImageBefore;
        	if (nPic >2) 
        	{
        		strImage = strImage.Replace("2in", strWidth[cboImageSize.SelectedIndex]);
        		strImage = strImage.Replace("1.444in", strHeight[cboImageSize.SelectedIndex]);
        	}else
        	{
        		strImage = strImage.Replace("<Sizing>Fit</Sizing>", "<Sizing>AutoSize</Sizing>");        	
        	}
        	strTmp = strTmp.Replace(strImageBefore, strImage);
        	firstIndex= strTmp.IndexOf("<Image Name=\"picFrame6\">");
        	LastIndex = strTmp.IndexOf(CloseTag, firstIndex) + CloseTag.Length;        	
        	strImageBefore = strTmp.Substring(firstIndex, LastIndex-firstIndex);
        	strImage = strImageBefore;        	
        	if (nPic >2) 
        	{
        		strImage = strImage.Replace("2in", strWidth[cboImageSize.SelectedIndex]);
        		strImage = strImage.Replace("1.444in", strHeight[cboImageSize.SelectedIndex]);
        	}else
        	{
        		strImage = strImage.Replace("<Sizing>Fit</Sizing>", "<Sizing>AutoSize</Sizing>");
        	}
            */
        	strTmp ="<?x"+ strTmp.Replace(strImageBefore, strImage);
            
        	ms = new MemoryStream();
        	bw  = new BinaryWriter(ms);
        	bw.Write(strTmp.ToCharArray());

            //this.print2file(this.ReportDefinition);

        	return ms;
		}
		public void LoadProfile(string ProfileID)
		{
			OleDbCommand myCom;
			OleDbDataReader myReader;
			string[] strOther;			
			string strTmp, strOneItem;
			int i, intCombo, n, noOfComboBox, noOfImages, x;
			bool isContinue;
			myCom = refConn.CreateCommand();
			myCom.CommandText ="SELECT Pro_PatientID, Pro_Date, Pro_Image1, Pro_Image2, Pro_Image3, Pro_Image4, Pro_Image5, Pro_Image6, Pro_Comment1, Pro_Comment2, Pro_Comment3, Pro_Comment4, Pro_Comment5, Pro_Comment6, Pro_Other, Pro_ExtraDiagnosis, Pro_ExtraTreatment, Pro_DoctorNote FROM tblProfile WHERE PROFILE_ID=" + ProfileID + ";";
			myReader = myCom.ExecuteReader();
			if (myReader.HasRows)
			{
				myReader.Read();
				LoadPatient(myReader.GetInt32(0).ToString());
				noOfImages = 0;
				for (i=2; i<8; i++)
				{
					if (!myReader.IsDBNull(i))
					{
						noOfImages ++;
						LoadImage(myReader.GetString(i), i-1);
					}
				}
				nudNoOfPicture.Value = noOfImages;
				NudNoOfPictureValueChanged(null, null);
				for (i=8;i<14 ;i++ ) if (!myReader.IsDBNull(i)) ((TextBox)this.Controls["txtNote_" + (i-5).ToString()]).Text = myReader.GetString(i);
				noOfComboBox = cboShow_Diagnosis.Length;
				if (!myReader.IsDBNull(14))
				{
					string [] strXXX;
					strXXX = new string[]{OTHER_DIAGNOSIS_SEPERATE};
					strTmp = myReader.GetValue(14).ToString();
					strOther = strTmp.Split(strXXX, StringSplitOptions.RemoveEmptyEntries);
					n = strOther.Length;
					for (i=0; i<n; i++)
					{
						
						for (intCombo =0; intCombo<noOfComboBox; intCombo++)
						{
							strTmp = cboShow_Diagnosis[intCombo].Name.Substring(COMBO_DIAGNOSIS_NAME.Length);
							if (strOther[i].StartsWith(strTmp))
						    {
								x = strOther[i].IndexOf(FRM_SEPPERATE_ID_NAME) + FRM_SEPPERATE_ID_NAME.Length;
								cboShow_Diagnosis[intCombo].Text = strOther[i].Substring(x);
						    }

						}//Visit all diag
						strTmp = cboShow_Treatment.Name.Substring(COMBO_DIAGNOSIS_NAME.Length);
						if (strOther[i].StartsWith(strTmp))
					    {
							x = strOther[i].IndexOf(FRM_SEPPERATE_ID_NAME) + FRM_SEPPERATE_ID_NAME.Length;
							cboShow_Treatment.Text = strOther[i].Substring(x);
					    }
					//Get treatment					
					}
				}//Composite field
				//Extra diagnosis
				if (!myReader.IsDBNull(15))				
					txtExtraDiagnosis.Text = myReader.GetString(15);
				else 
					txtExtraDiagnosis.Text= "";
				if (!myReader.IsDBNull(16))				
					txtExtraTreatment.Text = myReader.GetString(16);
				else 
					txtExtraTreatment.Text= "";
				if (!myReader.IsDBNull(17))				
					cboExtraNote.Text = myReader.GetString(17);
				else 
					cboExtraNote.Text= "";
			}else
			{
				return;
			}
			myReader.Close();
			myCom.CommandText = "SELECT Profile_Related FROM tblProfileDetails WHERE Profile_ID =" + ProfileID + ";";
			myReader = myCom.ExecuteReader();
			noOfComboBox = cboShow_Diagnosis.Length;
			if (myReader.HasRows)
			{
				while (myReader.Read())
				{
					strTmp = myReader.GetInt32(0).ToString() + FRM_SEPPERATE_ID_NAME;
					isContinue = true;
					for (intCombo =0; intCombo<noOfComboBox; intCombo++)
					{
						n = cboShow_Diagnosis[intCombo].Items.Count;
						for (i=0; i<n; i++)
						{
							strOneItem = cboShow_Diagnosis[intCombo].Items[i].ToString();
							if (strOneItem.StartsWith(strTmp))
							{
								cboShow_Diagnosis[intCombo].SelectedIndex = i;
								intCombo = noOfComboBox;
								isContinue =false;
								i=n;
							}
						}
					}//Visit all diag
					//Get treatment
					if (isContinue)
					{
						n = cboShow_Treatment.Items.Count;
						for (i=0; i<n; i++)
						{
							strOneItem = cboShow_Treatment.Items[i].ToString();
							if (strOneItem.StartsWith(strTmp))
							{
								cboShow_Treatment.SelectedIndex = i;								
								i=n;
								isContinue =false;
							}
						}
					}//end if
					if (isContinue)
					{
						n = lstDrID.Count;
						for (i=0; i<n; i++)
						{
							if (lstDrID[i]==myReader.GetInt32(0))
							{
								cboDrName.SelectedIndex = i;								
								i=n;
								//isContinue =false;
							}
						}
					}
				}	
			}//HasRows
			txtRecordID.Text = ProfileID;
			myReader.Close();
			myCom.Dispose();
			tsbtnSave.Enabled =false;
			lblCapture.Enabled=false;
			tsbtnPrint.Enabled =true;
			tsbtnPreview.Enabled=true;
			this.btsDeleteProfile.Enabled =true;
            LockPatientInformation(true);
		}//LoadProfile
		private void LoadImage(string ImageFile, int PicNo)
		{		
			string strTmp;
			PictureBox pic;
			Image img;
			strTmp = "pic_Frame" + PicNo.ToString();
			pic = (PictureBox)this.Controls[strTmp];
			try{
				img = Image.FromFile(ImageFile);
				pic.Image = CopyImage(img);
			}catch(Exception){}
		}
		
		void BtsDeleteProfileClick(object sender, EventArgs e)
		{
			string strSQL;
			OleDbCommand myCom;
			strSQL = "UPDATE tblProfile SET IsDeleted=1 WHERE PROFILE_ID= " + txtRecordID.Text + ";";
			//txtNote_1.Text = strSQL;
			if (MessageBox.Show(QUES_SURE_TO_DELETE, "Xoa phieu kham", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
			{
				myCom = this.refConn.CreateCommand();
				myCom.CommandText = strSQL;
				myCom.ExecuteNonQuery();				
				MessageBox.Show(MSG_DELETE_COMPLETED, "Xoa phieu kham", MessageBoxButtons.OK);
				ResetPatientRecord();
			}
		}
		void ResetPatientRecord()
		{
			int i, n;
			GenerateRecordID();
			this.isEditPatient = false;
			txtNote_1.Text = "";
			txtNote_2.Text = "";
			txtNote_3.Text = "";
			txtNote_4.Text = "";
			pic_Frame1.Image = null;
			pic_Frame2.Image = null;
			pic_Frame3.Image = null;
			pic_Frame4.Image = null;
			txtPatientAddress.Text = "";
			txtPatientAge.Text = "";
			txtPatientName.Text ="";
			txtPatientPhone.Text = "";
			txtExtraTreatment.Text ="";
			cboExtraNote.Text ="";
			txtExtraDiagnosis.Text ="";
			n = cboShow_Diagnosis.Length;
			for (i=0; i<n; i++)
			{
				cboShow_Diagnosis[i].Text ="";
			}
			cboShow_Treatment.Text ="";
		}
		void GenerateRecordID()
		{
			string strSQL;
			OleDbDataReader myReader;
			OleDbCommand myCom;
			strSQL = "SELECT MAX(tblProfile.PROFILE_ID) FROM tblProfile;";
			myCom = this.refConn.CreateCommand();
			myCom.CommandText = strSQL;			
			myReader = myCom.ExecuteReader();
			if (myReader.HasRows)
			{
				while (myReader.Read())
				{
					if ( myReader.IsDBNull(0) ) 
						txtRecordID.Text = "1";
					else 
						txtRecordID.Text= (myReader.GetInt32(0)+1).ToString();					
				}
			}else txtRecordID.Text = "1";
			myReader.Close();
		} 
		void print2file(MemoryStream Inms)
		{
			FileStream fs;
			
            int i=0, count;
			long r=0;
			byte[] bs;
			fs = new FileStream("C:\\abc.rdlc", FileMode.OpenOrCreate);
			
			bs = new byte[512];
            Inms.Seek(0, SeekOrigin.Begin);
            while (r < Inms.Length)
			{
                count = Inms.Read(bs, 0, 512);
                r += count;
                i += count;
                fs.Write(bs, 0, count);
			}
            fs.Close();
		}

        void LockPatientInformation(Boolean islocked)
        {
            txtPatientAddress.Enabled = !islocked;
            txtPatientAge.Enabled = !islocked;
            txtPatientName.Enabled = !islocked;
            txtPatientPhone.Enabled = !islocked;            
        }

        private void btnFillingWay_Click(object sender, EventArgs e)
        {
            
        }
	}
}

