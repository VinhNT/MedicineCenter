using System.Windows.Forms;
/*
 * Created by VinhNT email: VinhNT_gands@yahoo.com
 * User: Administrator
 * Date: 2/23/2009
 * Time: 1:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace Phongkhamnoisoi
{
	partial class frmDetailsProviding
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailsProviding));
            this.btnApply = new Button();
            this.btnClose = new Button();
            this.drgList = new DataGridView();
            this.lstIDTmp = new ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.drgList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(12, 330);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(160, 23);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Chấp nhận thay đổi";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApplyClick);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(311, 330);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(164, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Đóng của sổ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
            // 
            // drgList
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            this.drgList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.drgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            this.drgList.DefaultCellStyle = dataGridViewCellStyle2;
            this.drgList.Location = new System.Drawing.Point(0, 0);
            this.drgList.Name = "drgList";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            this.drgList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.drgList.RowTemplate.Resizable = DataGridViewTriState.True;
            this.drgList.Size = new System.Drawing.Size(488, 324);
            this.drgList.TabIndex = 5;
            // 
            // lstIDTmp
            // 
            this.lstIDTmp.FormattingEnabled = true;
            this.lstIDTmp.Location = new System.Drawing.Point(523, 12);
            this.lstIDTmp.Name = "lstIDTmp";
            this.lstIDTmp.Size = new System.Drawing.Size(59, 186);
            this.lstIDTmp.TabIndex = 6;
            this.lstIDTmp.Visible = false;
            // 
            // frmDetailsProviding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(492, 357);
            this.ControlBox = false;
            this.Controls.Add(this.lstIDTmp);
            this.Controls.Add(this.drgList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnApply);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmDetailsProviding";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.drgList)).EndInit();
            this.ResumeLayout(false);

		}
		private ListBox lstIDTmp;
		private DataGridView drgList;
		private Button btnClose;
		private Button btnApply;
	}
}
