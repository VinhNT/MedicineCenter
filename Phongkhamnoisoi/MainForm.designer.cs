/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2/20/2009
 * Time: 3:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace Phongkhamnoisoi
{
	partial class frmMainForm
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.tbMainToolBar = new System.Windows.Forms.ToolStrip();
            this.tsBtnListPatient = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnCreatePadding = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuBtnPatientRecord = new System.Windows.Forms.ToolStripButton();
            this.btnFillingImage = new System.Windows.Forms.ToolStripButton();
            this.btnItemCopyright = new System.Windows.Forms.ToolStripButton();
            this.tbMainToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMainToolBar
            // 
            this.tbMainToolBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbMainToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnListPatient,
            this.toolStripSeparator2,
            this.tsBtnCreatePadding,
            this.toolStripSeparator1,
            this.mnuBtnPatientRecord,
            this.btnFillingImage,
            this.btnItemCopyright});
            this.tbMainToolBar.Location = new System.Drawing.Point(0, 0);
            this.tbMainToolBar.Name = "tbMainToolBar";
            this.tbMainToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tbMainToolBar.Size = new System.Drawing.Size(180, 509);
            this.tbMainToolBar.TabIndex = 1;
            this.tbMainToolBar.Text = "MainToolBar";
            // 
            // tsBtnListPatient
            // 
            this.tsBtnListPatient.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnListPatient.Image")));
            this.tsBtnListPatient.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnListPatient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnListPatient.Name = "tsBtnListPatient";
            this.tsBtnListPatient.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsBtnListPatient.Size = new System.Drawing.Size(177, 24);
            this.tsBtnListPatient.Text = "Tìm kiếm bệnh nhân                  ";
            this.tsBtnListPatient.ToolTipText = "Danh sách bệnh nhân";
            this.tsBtnListPatient.Click += new System.EventHandler(this.TsBtnListPatientClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsBtnCreatePadding
            // 
            this.tsBtnCreatePadding.AutoSize = false;
            this.tsBtnCreatePadding.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBtnCreatePadding.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCreatePadding.Name = "tsBtnCreatePadding";
            this.tsBtnCreatePadding.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsBtnCreatePadding.Size = new System.Drawing.Size(90, 4);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnuBtnPatientRecord
            // 
            this.mnuBtnPatientRecord.Image = ((System.Drawing.Image)(resources.GetObject("mnuBtnPatientRecord.Image")));
            this.mnuBtnPatientRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuBtnPatientRecord.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuBtnPatientRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuBtnPatientRecord.Name = "mnuBtnPatientRecord";
            this.mnuBtnPatientRecord.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.mnuBtnPatientRecord.Size = new System.Drawing.Size(177, 39);
            this.mnuBtnPatientRecord.Text = "Khám bệnh";
            this.mnuBtnPatientRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mnuBtnPatientRecord.Click += new System.EventHandler(this.mnuBtnPatientRecord_Click);
            // 
            // btnFillingImage
            // 
            this.btnFillingImage.Image = ((System.Drawing.Image)(resources.GetObject("btnFillingImage.Image")));
            this.btnFillingImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFillingImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFillingImage.Name = "btnFillingImage";
            this.btnFillingImage.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.btnFillingImage.Size = new System.Drawing.Size(90, 20);
            this.btnFillingImage.Text = "Cai dat Filling";
            this.btnFillingImage.Click += new System.EventHandler(this.btnFillingImage_Click);
            // 
            // btnItemCopyright
            // 
            this.btnItemCopyright.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnItemCopyright.Image = ((System.Drawing.Image)(resources.GetObject("btnItemCopyright.Image")));
            this.btnItemCopyright.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItemCopyright.Name = "btnItemCopyright";
            this.btnItemCopyright.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.btnItemCopyright.Size = new System.Drawing.Size(62, 17);
            this.btnItemCopyright.Text = "Bản quyền";
            this.btnItemCopyright.Click += new System.EventHandler(this.BtnItemCopyrightClick);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(902, 509);
            this.Controls.Add(this.tbMainToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medic Information Management System";
            this.SizeChanged += new System.EventHandler(this.frmMainForm_SizeChanged);
            this.Load += new System.EventHandler(this.FrmMainFormLoad);
            this.tbMainToolBar.ResumeLayout(false);
            this.tbMainToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}//
		private System.Windows.Forms.ToolStripButton btnItemCopyright;
		private System.Windows.Forms.ToolStripButton tsBtnListPatient;

		void frmMainForm_SizeChanged(object sender, System.EventArgs e)
		{
            int i, n;
            n = tbMainToolBar.Items.Count;
            TotalButtonHeight = 0;
            for (i = 0; i < n; i++)
            {
                this.TotalButtonHeight += tbMainToolBar.Items[n - 1].ContentRectangle.Height;                
            }
            this.tsBtnCreatePadding.Size = new System.Drawing.Size(0, this.Size.Height -this.TotalButtonHeight);
		}//InitializeComponent        
        private ToolStrip tbMainToolBar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsBtnCreatePadding;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton mnuBtnPatientRecord;
        private ToolStripButton btnFillingImage;
        //private System.Windows.Forms.ToolStripContainer toolStripContainer1;		
	}//class
}
