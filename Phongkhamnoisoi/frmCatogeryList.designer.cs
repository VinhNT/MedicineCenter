/*
 * Created by VinhNT email: VinhNT_gands@yahoo.com
 * User: Administrator
 * Date: 2/25/2009
 * Time: 3:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Windows.Forms;
namespace Phongkhamnoisoi
{
	partial class frmCatogeryList
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lstCatogery = new ListBox();
			this.btnAddNewCatogery = new Button();
			this.btnRemoveCatogery = new Button();
			this.btnUpdate = new Button();
			this.btnClose = new Button();
			this.lstItemsID = new ListBox();
			this.SuspendLayout();
			// 
			// lstCatogery
			// 
			this.lstCatogery.FormattingEnabled = true;
			this.lstCatogery.Location = new System.Drawing.Point(1, 1);
			this.lstCatogery.Name = "lstCatogery";
			this.lstCatogery.Size = new System.Drawing.Size(468, 277);
			this.lstCatogery.TabIndex = 0;
			// 
			// btnAddNewCatogery
			// 
			this.btnAddNewCatogery.Location = new System.Drawing.Point(1, 284);
			this.btnAddNewCatogery.Name = "btnAddNewCatogery";
			this.btnAddNewCatogery.Size = new System.Drawing.Size(102, 23);
			this.btnAddNewCatogery.TabIndex = 1;
			this.btnAddNewCatogery.Text = "Thêm mới";
			this.btnAddNewCatogery.UseVisualStyleBackColor = true;
			this.btnAddNewCatogery.Click += new System.EventHandler(this.BtnAddNewCatogeryClick);
			// 
			// btnRemoveCatogery
			// 
			this.btnRemoveCatogery.Location = new System.Drawing.Point(114, 284);
			this.btnRemoveCatogery.Name = "btnRemoveCatogery";
			this.btnRemoveCatogery.Size = new System.Drawing.Size(102, 23);
			this.btnRemoveCatogery.TabIndex = 2;
			this.btnRemoveCatogery.Text = "Xóa bỏ";
			this.btnRemoveCatogery.UseVisualStyleBackColor = true;
			this.btnRemoveCatogery.Click += new System.EventHandler(this.BtnRemoveCatogeryClick);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(232, 284);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(102, 23);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "Cập nhật";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(355, 284);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(102, 23);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "Đóng cửa sổ";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// lstItemsID
			// 
			this.lstItemsID.FormattingEnabled = true;
			this.lstItemsID.Location = new System.Drawing.Point(420, 261);
			this.lstItemsID.Name = "lstItemsID";
			this.lstItemsID.Size = new System.Drawing.Size(49, 17);
			this.lstItemsID.TabIndex = 5;
			// 
			// frmCatogeryList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 310);
			this.Controls.Add(this.lstItemsID);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnRemoveCatogery);
			this.Controls.Add(this.btnAddNewCatogery);
			this.Controls.Add(this.lstCatogery);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCatogeryList";
			this.ShowInTaskbar = false;
			this.Text = "Danh sách Catogery";
			this.ResumeLayout(false);
		}
		private ListBox lstItemsID;
		private Button btnUpdate;
		private Button btnAddNewCatogery;
		private Button btnClose;
		private Button btnRemoveCatogery;
		private ListBox lstCatogery;
		
	}
}
