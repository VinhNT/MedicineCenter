namespace Phongkhamnoisoi
{
    partial class frmFillingImageConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.colorChose = new System.Windows.Forms.ColorDialog();
            this.btnChoseColor = new System.Windows.Forms.Button();
            this.tbTolerance = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTolerances = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lstPosition = new System.Windows.Forms.ListBox();
            this.mtxtOnePosition = new System.Windows.Forms.MaskedTextBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbTolerance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTolerances)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xoa bang:";
            // 
            // btnChoseColor
            // 
            this.btnChoseColor.Location = new System.Drawing.Point(75, 72);
            this.btnChoseColor.Name = "btnChoseColor";
            this.btnChoseColor.Size = new System.Drawing.Size(84, 24);
            this.btnChoseColor.TabIndex = 1;
            this.btnChoseColor.UseVisualStyleBackColor = true;
            // 
            // tbTolerance
            // 
            this.tbTolerance.Location = new System.Drawing.Point(3, 122);
            this.tbTolerance.Maximum = 100;
            this.tbTolerance.Name = "tbTolerance";
            this.tbTolerance.Size = new System.Drawing.Size(156, 45);
            this.tbTolerance.TabIndex = 3;
            this.tbTolerance.Scroll += new System.EventHandler(this.tbTolerance_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Muc do";
            // 
            // nudTolerances
            // 
            this.nudTolerances.Location = new System.Drawing.Point(75, 104);
            this.nudTolerances.Name = "nudTolerances";
            this.nudTolerances.Size = new System.Drawing.Size(84, 20);
            this.nudTolerances.TabIndex = 6;
            this.nudTolerances.ValueChanged += new System.EventHandler(this.nudTolerances_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Xoa bang:";
            // 
            // lstPosition
            // 
            this.lstPosition.FormattingEnabled = true;
            this.lstPosition.Location = new System.Drawing.Point(164, 10);
            this.lstPosition.Name = "lstPosition";
            this.lstPosition.Size = new System.Drawing.Size(67, 173);
            this.lstPosition.TabIndex = 8;
            // 
            // mtxtOnePosition
            // 
            this.mtxtOnePosition.Location = new System.Drawing.Point(66, 162);
            this.mtxtOnePosition.Name = "mtxtOnePosition";
            this.mtxtOnePosition.PromptChar = ',';
            this.mtxtOnePosition.Size = new System.Drawing.Size(67, 20);
            this.mtxtOnePosition.TabIndex = 9;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(135, 160);
            this.btnAddToList.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(28, 23);
            this.btnAddToList.TabIndex = 10;
            this.btnAddToList.Text = ">>";
            this.btnAddToList.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cac diem tien hanh xoa";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 198);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Luu";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(113, 198);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Dong";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmFillingImageConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 227);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.mtxtOnePosition);
            this.Controls.Add(this.lstPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudTolerances);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTolerance);
            this.Controls.Add(this.btnChoseColor);
            this.Controls.Add(this.label1);
            this.Name = "frmFillingImageConfig";
            this.Text = "Cai dat che do xoa vien den";
            this.Load += new System.EventHandler(this.frmFillingImageConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbTolerance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTolerances)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorChose;
        private System.Windows.Forms.Button btnChoseColor;
        private System.Windows.Forms.TrackBar tbTolerance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTolerances;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstPosition;
        private System.Windows.Forms.MaskedTextBox mtxtOnePosition;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}