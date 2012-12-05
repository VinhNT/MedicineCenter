/*
 * Created by VinhNT email: VinhNT_gands@yahoo.com
 * User: Administrator
 * Date: 2/20/2009
 * Time: 3:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DirectX.Capture;
using System.IO;
using Phongkhamnoisoi;

namespace Phongkhamnoisoi
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class frmMainForm : Form
	{
		public System.Data.OleDb.OleDbConnection myConn ;
		private System.Data.OleDb.OleDbCommand  myCom;
		private System.Data.OleDb.OleDbDataReader myReader;
		private System.Windows.Forms.ToolStripButton tbTmp4LoadDynamic;
		private System.Windows.Forms.ToolStripSeparator sepTmp;
		private int TotalButtonHeight;
		private const string ERROR_WHILE_LOADING_DATABASE ="Không tìm thấy cơ sở dữ liệu, chương trình không thể tiếp tục thực hiện...";
        //Image mainBackGroundImage;
		public frmMainForm()
		{			
			byte i =0;			
            PrivateDataEncode pde = new PrivateDataEncode();            
			myConn = new OleDbConnection();
			myCom = new OleDbCommand();

			myCom.CommandText="Select M_ID, M_Name, M_Type, M_Description From tblMasterInfor ORDER BY M_Type";
			myCom.Connection = myConn;
			myConn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Data.mdb;Jet OLEDB:Database Password=whatthehellisgoingon";
			try{
				myConn.Open();
			}catch(Exception e)
			{				
				MessageBox.Show(ERROR_WHILE_LOADING_DATABASE + e.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Dispose();
				Application.Exit();
			}
			myReader = myCom.ExecuteReader();
			System.ComponentModel.ComponentResourceManager resources1 = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
			InitializeComponent();
			if (myReader.HasRows) 
			{
				while (myReader.Read())
				{	
					this.tbTmp4LoadDynamic = new System.Windows.Forms.ToolStripButton();
					this.tbTmp4LoadDynamic.Overflow = ToolStripItemOverflow.Never;
					if (myReader.GetByte(2) ==frmAddNewMasterItem.ENUM_INTEGER_CATOGERY_DIAGNOSIS)
					{
						try{							
	                        this.tbTmp4LoadDynamic.Image = Image.FromFile(Application.StartupPath + @"\image\diagnosis.bmp");
						}catch(System.IO.FileNotFoundException){}
					}else if (myReader.GetByte(2) ==frmAddNewMasterItem.ENUM_INTEGER_CATOGERY_TREATMENT)
					{//treatment
						try{
                        	this.tbTmp4LoadDynamic.Image = Image.FromFile(Application.StartupPath + @"\image\treatment.bmp");//career.bmp
						}catch(System.IO.FileNotFoundException){}
					}else 
					{
						try{
	                        this.tbTmp4LoadDynamic.Image = Image.FromFile(Application.StartupPath + @"\image\career.bmp");
						}catch(System.IO.FileNotFoundException){}
					}
					//this.tbTmp4LoadDynamic.Image = ((System.Drawing.Image)(resources.GetObject("mnuBtnPatientRecord.Image")));
					this.tbTmp4LoadDynamic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
					this.tbTmp4LoadDynamic.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
					this.tbTmp4LoadDynamic.ImageTransparentColor = System.Drawing.Color.Magenta;
					this.tbTmp4LoadDynamic.Name = "tb" +myReader.GetValue(0).ToString();
					this.tbTmp4LoadDynamic.Size = new System.Drawing.Size(90, 40);					
					this.tbTmp4LoadDynamic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
					this.tbTmp4LoadDynamic.Click += new System.EventHandler(this.DynamicToolBarClick);
					this.tbTmp4LoadDynamic.ImageTransparentColor = System.Drawing.Color.Magenta;
					this.tbTmp4LoadDynamic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
					this.tbTmp4LoadDynamic.Text = myReader.GetString(1);
                    this.tbTmp4LoadDynamic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
					this.tbTmp4LoadDynamic.DoubleClick += new EventHandler(DynamicToolBarClick);
					sepTmp = new ToolStripSeparator();
					sepTmp.Name = "auto" + i++.ToString();
					sepTmp.Size = new System.Drawing.Size(6, 1);                    
					this.tbMainToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{sepTmp, tbTmp4LoadDynamic});                    
				}//	myReader.Read()
			}//myReader.HasRows
            myReader.Close();

            this.frmMainForm_SizeChanged(null, null);            
		}

		void frmMainForm_Closing(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}//frmMainForm
		
		void DynamicToolBarClick(object sender, EventArgs e)
		{
			frmDetailsProviding frmTmp;            
			String sourceName = ((System.Windows.Forms.ToolStripButton)sender).Name;
			String sourceID = sourceName.Substring(2);            
			frmTmp = new frmDetailsProviding();			
			frmTmp.Text = ((System.Windows.Forms.ToolStripButton)sender).Text;			
			frmTmp.loadData(sourceID, this.myConn, frmTmp.Text);
			frmTmp.ShowDialog();
		}//DynamicToolBarClick
		
		void MnuItemAddTreatmentDetailsClick(object sender, EventArgs e)
		{
			frmAddNewMasterItem frmTmp = new frmAddNewMasterItem();
			frmTmp.Show();
			frmTmp.setCatMode(frmAddNewMasterItem.ENUM_INTEGER_CATOGERY_TREATMENT);
			frmTmp.setRefConnection(this.myConn);
			frmTmp.MdiParent =this;
			frmTmp =null;
		}//MnuItemAddTreatmentDetailsClick
		void MnuItemAddDiagnosisDetailsClick(object sender, System.EventArgs e)
		{
			frmAddNewMasterItem frmTmp = new frmAddNewMasterItem();
			frmTmp.setRefConnection(this.myConn);
			frmTmp.Show();
			frmTmp.MdiParent =this;
			frmTmp =null;
		}//MnuItemAddDiagnosisDetailsClick
		
		void MnuItemCatogeryListClick(object sender, EventArgs e)
		{
			frmCatogeryList frmTmp = new frmCatogeryList();
			frmTmp.Show();
			frmTmp.setConnectionReferenceNLoadData(this.myConn);
			frmTmp.MdiParent =this;
			frmTmp = null;
		}//MnuItemCatogeryListClick

        private void mnuBtnPatientRecord_Click(object sender, EventArgs e)
        {
            frmPatientRecord frmTmp = new frmPatientRecord();
            frmTmp.setParent(this);
            frmTmp.setReferenceConnectNLoadData(ref this.myConn, ref this.pdc.ReportDefinition, ref this.pdc.reportHeader, this.pdc.ReportTitle);
            frmTmp.ShowDialog();            
            frmTmp = null;
        }//MnuBtnPatientRecordClick
		
		void TsBtnListPatientClick(object sender, EventArgs e)
		{
			frmSearchPatient frmTmp = new frmSearchPatient();
			frmTmp.setConnectionRefNLoadData(ref this.myConn, ref pdc.reportHeader, ref pdc.ReportDefinition, pdc.ReportTitle);
			frmTmp.ShowDialog();
			frmTmp = null;
		}
		
		void FrmMainFormLoad(object sender, EventArgs e)
		{
			pdc = new Phongkhamnoisoi.PrivateDataPrepair.PrivateDataCustomer();
			pdc = PrivateDataPrepair.GetPrivateData(Application.StartupPath + @"\boss_com.dat");			
			this.BackgroundImage = pdc.backGround;
		}
		private Phongkhamnoisoi.PrivateDataPrepair.PrivateDataCustomer pdc;
		
		void BtnItemCopyrightClick(object sender, EventArgs e)
		{
			string strCopyRight = "Medic supporter Version 1.1\r\n";
			strCopyRight += "FREE License ,..\r\n"; 
			strCopyRight += "Copyright@2009-2011 by Nguyen The Vinh\r\n"; 
			strCopyRight += "Contact at email: vinhnt_gands@yahoo.com";
            strCopyRight += "\n\tnguyenthevinhbk@gmail.com";
			MessageBox.Show(strCopyRight, "Copyright", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

        private void btnFillingImage_Click(object sender, EventArgs e)
        {
            frmFillingImageConfig frmTmp = new frmFillingImageConfig();
            frmTmp.ShowDialog();
            frmTmp = null;
        }
	}
}
