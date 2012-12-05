/*
 * Created by SharpDevelop.
 * User: VinhNT
 * Date: 2/23/2009
 * Time: 1:38 PM
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
	/// Description of Form1.
	/// </summary>
	public partial class frmDetailsProviding : Form
	{
		OleDbConnection refCon;	
		int ni;
        private bool haveToSave;
		private const string ERR_CAN_NOT_REMOVE_A_REFERENCE_KEY="Không thể xóa chi tiết này, chi tiết này đã được sử dụng cho hồ sơ khám bệnh";
		private const string MSG_DELETE_COMPLETED ="Đã xóa xong!";
		private const string MSG_QUESTION_BEFORE_CLOSE ="Lưu lại thay đổi trên cửa sổ này chứ?";
		private const string MSG_QUESTION_TITLE="Lưu thay đổi...";
		private string strMasterID;		
		public void setMaster(string mID)
		{
			this.strMasterID = mID;
		}		
		public frmDetailsProviding()
		{			
			InitializeComponent();
            haveToSave = false;
		}		
		public void loadData(string sourceID, OleDbConnection refParent, string datasetTitle)		{      
			int i;
			System.Data.OleDb.OleDbDataReader myReader;
			OleDbCommand myCom = new OleDbCommand();
			myCom.Connection = refParent;
			this.refCon = refParent;
			myCom.CommandText= "SELECT Details_ID, Details_Content FROM tblDetailsInfor WHERE Mas_ID="+ sourceID +";";
			this.strMasterID = sourceID;
			myReader = myCom.ExecuteReader();
			drgList.RowHeadersVisible =true;
			drgList.ColumnCount = 0;
			drgList.Columns.Add("NameOne", "Mô tả chi tiết");
			drgList.Columns["NameOne"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			lstIDTmp.Items.Clear();
			i=0;
			if (myReader.HasRows) 
			{
				while (myReader.Read())
				{	
					drgList.Rows.Add(new Object[]{myReader.GetString(1)});
					lstIDTmp.Items.Add(myReader.GetInt32(0));
					i++;
				}			
			}
			ni = i;
			myReader.Close();
			this.drgList.UserAddedRow+= new DataGridViewRowEventHandler(drgList_UserAddedRow);
			this.drgList.UserDeletingRow+= new DataGridViewRowCancelEventHandler(drgList_RowsIsBeingRemoved);
			
		}//loadData
		void BtnAddNewClick(object sender, EventArgs e)
		{
			drgList.Rows.Add(new Object[]{null, null});
			lstIDTmp.Items.Add(-1);
		}
		void ApplyAllChange()
		{
			int i;
			int nLst, nDrg;
			string strTmpID;			
			OleDbCommand myCom = new OleDbCommand();
			nLst = lstIDTmp.Items.Count;
			nDrg = drgList.Rows.Count;
			myCom.Connection = refCon;
			if (nLst>nDrg)  nLst = nDrg;
			for (i=0; i<nLst; i++)
			{
				strTmpID = 	lstIDTmp.Items[i].ToString();
				if (int.Parse( lstIDTmp.Items[i].ToString())==-1)
				{
					myCom.CommandText ="INSERT INTO tblDetailsInfor(Mas_ID, Details_Content) values(" + strMasterID + ", '" + drgList.Rows[i].Cells[0].Value.ToString() + "');";
				}else
				{//Update method
					myCom.CommandText ="UPDATE tblDetailsInfor SET Details_Content='" + drgList.Rows[i].Cells[0].Value.ToString() + "' WHERE Details_ID=" + strTmpID +";";
				}
				myCom.ExecuteNonQuery();
			}//Finish update/insert
			
		}//ApplyAllChange
		private void drgList_RowsIsBeingRemoved(object sender, DataGridViewRowCancelEventArgs e)
		{			
			int iRowIndex = e.Row.Index;			
			string removeID = lstIDTmp.Items[iRowIndex].ToString();
			OleDbCommand myCom = new OleDbCommand();
			myCom.Connection = refCon;			
			
			if (Int32.Parse( removeID)!=-1)
			{//Remove the relative record from database
				if (checkReferenceKey("tblProfileDetails", "Profile_Related", removeID, false))
				{
					MessageBox.Show (ERR_CAN_NOT_REMOVE_A_REFERENCE_KEY);
					return;
				}
				myCom.CommandText  = "DELETE from tblDetailsInfor Where Details_ID= " + removeID + ";";
				myCom.ExecuteNonQuery();
				MessageBox.Show (MSG_DELETE_COMPLETED);
				lstIDTmp.Items.RemoveAt(iRowIndex);
				myCom.Dispose();
			}else
			{//This is added-new rows, just remove it from datagridview
				lstIDTmp.Items.RemoveAt(iRowIndex);
			}
		}//drgList_RowsIsBeingRemoved
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
		void BtnCloseClick(object sender, EventArgs e)
		{
			DialogResult answer;
            if (!haveToSave)
            {
                this.Close();
                return;
            }
			answer = MessageBox.Show(MSG_QUESTION_BEFORE_CLOSE, MSG_QUESTION_TITLE, MessageBoxButtons.YesNoCancel);
			if (answer == DialogResult.Yes)
			{//Save data and close window				
				ApplyAllChange();
			}else if (answer==DialogResult.No)
			{//just close window
				
			}else
			{//cancel, do nothing
				return;
			}
			this.Close();
		}
		void BtnApplyClick(object sender, EventArgs e)
		{
			ApplyAllChange();
            haveToSave = false;
            this.Close();
		}
        private void drgList_UserAddedRow(object sender, DataGridViewRowEventArgs e)
		{//Provive the way for update strtmpid listbox    
			lstIDTmp.Items.Add(-1);
            haveToSave = true;
		}
      
	}//Class
}//Namespace