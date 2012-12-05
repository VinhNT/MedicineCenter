/*
 * Created by VinhNT email: VinhNT_gands@yahoo.com
 * User: Administrator
 * Date: 2/25/2009
 * Time: 3:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
namespace Phongkhamnoisoi
{
	/// <summary>
	/// Description of frmCatogeryList.
	/// </summary>
	public partial class frmCatogeryList : Form
	{
		OleDbConnection refCon;
		private string MSG_QUESTION_BEFORE_DELETE 	="Chắc chắn xóa chứ?";
		private string ERROR_CAN_NOT_REMOVE 		="Không thể xóa Catogery này, đã có thông tin chi tiết liên quan";
		public const int INT_CAREER_ID 			= 11; //Do not remove/modify this one
			
		public frmCatogeryList()
		{
			InitializeComponent();			
		}//frmCatogeryList
		public void setConnectionReferenceNLoadData(OleDbConnection refParent)
		{
			string strSQL;
			string tmpItem;
			int iType;
			OleDbCommand myCom = new OleDbCommand();
			OleDbDataReader myReader;
			this.refCon = refParent;
			strSQL  = "SELECT M_ID, M_Name, M_Type, M_Description FROM tblMasterInfor WHERE M_ID<>" + INT_CAREER_ID.ToString() + " ORDER by M_Type, M_ID;";
			myCom.CommandText = strSQL;
			myCom.Connection = refCon;
			myReader = myCom.ExecuteReader();
			lstCatogery.Items.Clear();
			lstItemsID.Items.Clear();
			
			if (myReader.HasRows)
			{
				while (myReader.Read())
				{
					tmpItem = myReader.GetInt32(0).ToString() + "\t"; 
					iType = myReader.GetByte(2);
					if (iType==frmAddNewMasterItem.ENUM_INTEGER_CATOGERY_DIAGNOSIS)
					{
						tmpItem += frmAddNewMasterItem.ENUM_STRING_CATOGERY_DIAGNOSIS;
					}else
					{
						tmpItem += frmAddNewMasterItem.ENUM_STRING_CATOGERY_TREATMENT;
					}
					lstItemsID.Items.Add(myReader.GetInt32(0).ToString());
					tmpItem+= ":\t\t" +myReader.GetString(1);					
					lstCatogery.Items.Add(tmpItem);
				}
			}else
			{
				btnRemoveCatogery.Enabled =false;
				btnUpdate.Enabled =false;					
			}
			myReader.Close();
		}//setConnectionReferenceNLoadData
		void BtnCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}//BtnCloseClick
		void BtnRemoveCatogeryClick(object sender, EventArgs e)
		{
			int iDeletedIdex;
			string strTmp;
			OleDbCommand myCom;
			iDeletedIdex = lstCatogery.SelectedIndex;
			if (iDeletedIdex ==-1) return;
			strTmp = lstItemsID.SelectedItem.ToString();
			if (MessageBox.Show (MSG_QUESTION_BEFORE_DELETE, MSG_QUESTION_BEFORE_DELETE, MessageBoxButtons.YesNo)== DialogResult.Yes)
			{
				if (checkReferenceKey("tblDetailsInfor", "Mas_ID", strTmp, false))
				{
					MessageBox.Show(ERROR_CAN_NOT_REMOVE, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}				    
				myCom = new OleDbCommand();
				myCom.Connection =refCon;
				myCom.CommandText= "DELETE FROM tblMasterInfor WHERE M_ID=" + strTmp + ";";
				myCom.ExecuteNonQuery();				
			}else return;
		}//BtnRemoveCatogeryClick
		private Boolean checkReferenceKey(string tablename, string fieldname, string key, Boolean isString)
		{
			Boolean	tmp;
			OleDbCommand myCom = new OleDbCommand();
			myCom.Connection = refCon;
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
		void BtnAddNewCatogeryClick(object sender, EventArgs e)
		{
			frmAddNewMasterItem frmTmp = new frmAddNewMasterItem();
			frmTmp.setAddNewRef(this.refCon);
			frmTmp.Show();
			frmTmp = null;
			this.Close();
		}//BtnAddNewCatogeryClick
		void BtnUpdateClick(object sender, EventArgs e)
		{
			int iIndex;
			string strItemId;
			iIndex = lstCatogery.SelectedIndex;
			if (iIndex <0) return;
			frmAddNewMasterItem frmTmp = new frmAddNewMasterItem();
			strItemId = lstItemsID.Items[iIndex].ToString();
			frmTmp.loadItem(strItemId, this.refCon);
			frmTmp.Show();
			frmTmp = null;
			this.Close();
		}//BtnUpdateClick
	}
}
