/*
 * Created by VinhNT email: VinhNT_gands@yahoo.com
 * User: Administrator
 * Date: 2/25/2009
 * Time: 1:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Windows.Forms;
namespace Phongkhamnoisoi
{
	partial class frmAddNewMasterItem
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private int iMode;
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
			this.groupBox1 = new GroupBox();
			this.btnClose = new Button();
			this.btnReset = new Button();
			this.btnOK = new Button();
			this.txtCatogeryDescription = new TextBox();
			this.label2 = new Label();
			this.cboCatogeryType = new ComboBox();
			this.label1 = new Label();
			this.txtCatogeryName = new TextBox();
			this.lblMasterID = new Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnClose);
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.btnOK);
			this.groupBox1.Controls.Add(this.txtCatogeryDescription);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cboCatogeryType);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtCatogeryName);
			this.groupBox1.Controls.Add(this.lblMasterID);
			this.groupBox1.Location = new System.Drawing.Point(6, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(323, 179);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nhập thông tin Catogery mới";
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(209, 150);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(94, 23);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "Hủy bỏ";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(109, 150);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(94, 23);
			this.btnReset.TabIndex = 4;
			this.btnReset.Text = "Làm lại";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(9, 150);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(94, 23);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "Chấp nhận";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.BtnOKClick);
			// 
			// txtCatogeryDescription
			// 
			this.txtCatogeryDescription.Location = new System.Drawing.Point(106, 73);
			this.txtCatogeryDescription.Multiline = true;
			this.txtCatogeryDescription.Name = "txtCatogeryDescription";
			this.txtCatogeryDescription.Size = new System.Drawing.Size(211, 71);
			this.txtCatogeryDescription.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 28);
			this.label2.TabIndex = 10;
			this.label2.Text = "Mô tả Catogery:";
			// 
			// cboCatogeryType
			// 
			this.cboCatogeryType.FormattingEnabled = true;
			this.cboCatogeryType.Location = new System.Drawing.Point(106, 46);
			this.cboCatogeryType.Name = "cboCatogeryType";
			this.cboCatogeryType.Size = new System.Drawing.Size(209, 21);
			this.cboCatogeryType.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 15);
			this.label1.TabIndex = 8;
			this.label1.Text = "Loại Catogery";
			// 
			// txtCatogeryName
			// 
			this.txtCatogeryName.Location = new System.Drawing.Point(106, 19);
			this.txtCatogeryName.Name = "txtCatogeryName";
			this.txtCatogeryName.Size = new System.Drawing.Size(209, 20);
			this.txtCatogeryName.TabIndex = 0;
			// 
			// lblMasterID
			// 
			this.lblMasterID.Location = new System.Drawing.Point(6, 25);
			this.lblMasterID.Name = "lblMasterID";
			this.lblMasterID.Size = new System.Drawing.Size(77, 15);
			this.lblMasterID.TabIndex = 6;
			this.lblMasterID.Text = "Tên category:";
			// 
			// frmAddNewMasterItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(329, 186);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.Name = "frmAddNewMasterItem";
			this.Text = "Nhập thông tin Catoregy";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private Button btnClose;
		private Button btnReset;
		private TextBox txtCatogeryDescription;
		private TextBox txtCatogeryName;
		private ComboBox cboCatogeryType;
		private Label lblMasterID;
		private Label label1;
		private Label label2;
		private Button btnOK;
		private GroupBox groupBox1;
	}
}
