/*
 * Created by VinhNT email: VinhNT_gands@yahoo.com
 * User: VinhNT email: VinhNT_gands@yahoo.com
 * Date: 2/25/2009
 * Time: 1:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Phongkhamnoisoi
{
	/// <summary>
	/// Description of frmAddNewMasterItem.
	/// </summary>diagnosis
	/// 
	public partial class frmAddNewMasterItem : Form
	{
		public const string ENUM_STRING_CATOGERY_DIAGNOSIS ="Chuẩn đoán";
		public const string ENUM_STRING_CATOGERY_TREATMENT ="Điều trị";
		public const int ENUM_INTEGER_CATOGERY_DIAGNOSIS =0;
		public const int ENUM_INTEGER_CATOGERY_TREATMENT =1;
		public const int ENUM_INTEGER_CATOGERY_CAREER =2;
		public const int ENUM_INTEGER_CATOGERY_DORTOR_INFOR =3;
        public const int ENUM_INTEGER_CATOGERY_DOCTOR_COMMENT = 4;
		private const string ERR_CATEGORY_TYPPE_NOT_SELECTED ="Lỗi, chưa chọn loại Catogery, vui lòng chọn...";
		private const string ERR_CATEGORY_NAME_EMPTY ="Lỗi, chưa nhập tên Catogery, vui lòng nhập vào...";
		private const string MSG_INSERT_COMPLETED ="Đã thêm xong...";
		public const int ENUM_MODE_ADDNEW_BEGIN =1;
		public const int ENUM_MODE_ADDNEW_OUTSIDE =1;
		public const int ENUM_MODE_EDIT =2;
		
		private int iWorkMode;
		private string strRefID;
		OleDbConnection refCon;
		
		public frmAddNewMasterItem()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();			
			iMode = ENUM_INTEGER_CATOGERY_DIAGNOSIS;
			this.cboCatogeryType.Enabled =false;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			cboCatogeryType.Items.Clear();
			iWorkMode = ENUM_MODE_ADDNEW_BEGIN;
			cboCatogeryType.Items.Add(ENUM_STRING_CATOGERY_DIAGNOSIS);
			cboCatogeryType.Items.Add(ENUM_STRING_CATOGERY_TREATMENT);
			cboCatogeryType.SelectedIndex = ENUM_INTEGER_CATOGERY_DIAGNOSIS;
		}//frmAddNewMasterItem
		public void setRefConnection(OleDbConnection refParentCon)
		{
			this.refCon = refParentCon;	
		}//setRefConnection
		public void setCatMode(int mode)
		{
			if (mode>1) mode =ENUM_INTEGER_CATOGERY_TREATMENT;
			if (mode<0) mode =ENUM_INTEGER_CATOGERY_DIAGNOSIS;
			this.iMode = mode;
			this.cboCatogeryType.SelectedIndex =mode;
		}//setCatMode
		void BtnResetClick(object sender, System.EventArgs e)
		{
			this.txtCatogeryName.Text = string.Empty;
			this.txtCatogeryDescription.Text = string.Empty;
			this.cboCatogeryType.SelectedIndex = this.iMode;
		}//BtnResetClick
		void BtnCloseClick(object sender, System.EventArgs e)
		{
			if (iWorkMode==ENUM_MODE_ADDNEW_OUTSIDE || iWorkMode==ENUM_MODE_EDIT)
			{
				frmCatogeryList frmTmp = new frmCatogeryList();
				frmTmp.setConnectionReferenceNLoadData(this.refCon);
				frmTmp.MdiParent =this.MdiParent;
				frmTmp.Show();
				frmTmp = null;
			}
			this.Close();
			
		}//BtnCloseClick
		void BtnOKClick(object sender, System.EventArgs e)
		{
			OleDbCommand myCom ;
			string strSQL;
			if (this.txtCatogeryName.Text.Length<=0)
			{
				MessageBox.Show(ERR_CATEGORY_NAME_EMPTY, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtCatogeryName.Focus();
				return;
			}
			myCom = new OleDbCommand();
			myCom.Connection = this.refCon;
			
			if (iWorkMode == ENUM_MODE_EDIT)
			{//edit an existing item
				frmCatogeryList frmTmp;
				strSQL ="UPDATE tblMasterInfor SET M_Name= '"+ txtCatogeryName.Text.ToString() + "', M_Description ='" + txtCatogeryDescription.Text.ToString() + "'  WHERE M_ID= " + strRefID + ";";
				myCom.CommandText = strSQL;
				myCom.Connection = refCon;
				myCom.ExecuteNonQuery();
				this.Close();
				frmTmp = new frmCatogeryList();				
				frmTmp.setConnectionReferenceNLoadData(this.refCon);
				frmTmp.MdiParent =this.MdiParent;
				frmTmp.Show();
				frmTmp = null;
			}//Add new mode
			else
			{
				strSQL ="INSERT INTO tblMasterInfor(M_Name, M_Type, M_Description) VALUES('" + txtCatogeryName.Text.ToString() + "', " + cboCatogeryType.SelectedIndex.ToString() + ", ";
				if (txtCatogeryDescription.Text.Length<=0) 
				{
					strSQL += "NULL );";
				}else strSQL+= "'" + txtCatogeryDescription.Text.ToString() + "');";
				myCom.CommandText = strSQL;
				myCom.Connection = refCon;
				myCom.ExecuteNonQuery();				
				txtCatogeryName.Text = string.Empty;
				txtCatogeryDescription.Text = string.Empty;
				cboCatogeryType.SelectedIndex =  this.iMode;
			}//if - else
		}//BtnOKClick
		public void loadItem(string itemID, OleDbConnection refParentCon)
		{
			OleDbCommand myCom ;
			OleDbDataReader myReader;			
			myCom = new OleDbCommand();
			myCom.Connection = refParentCon;
			this.refCon = refParentCon;
			myCom.CommandText = "SELECT M_Name, M_Type, M_Description FROM tblMasterInfor WHERE M_ID=" + itemID +";";
			myReader = myCom.ExecuteReader();
			if (myReader.HasRows)
			{
				myReader.Read();
				txtCatogeryName.Text = myReader.GetString(0);
				txtCatogeryDescription.Text = myReader.GetString(2);
				cboCatogeryType.SelectedIndex = myReader.GetByte(1);
				this.iWorkMode = ENUM_MODE_EDIT;
			}else
			{
				this.iWorkMode = ENUM_MODE_ADDNEW_OUTSIDE;
			}
			myReader.Close();
			this.strRefID = itemID;
		}//void loadItem
		public void setAddNewRef(OleDbConnection refParentCon)
		{
			this.iMode = ENUM_MODE_ADDNEW_OUTSIDE;
			this.refCon = refParentCon;
		}//setAddNewRef
	}//Class
}//Namespace
