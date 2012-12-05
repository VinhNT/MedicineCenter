using System;
using System.Windows.Forms;
/*
 * Created by VinhNT email: VinhNT_gands@yahoo.com
 * User: Administrator
 * Date: 3/4/2009
 * Time: 9:02 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Phongkhamnoisoi
{
	partial class frmPatientRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientRecord));
            this.groupBox1 = new GroupBox();
            this.cboDrName = new ComboBox();
            this.btnSearchPatient = new Button();
            this.txtRecordID = new TextBox();
            this.label9 = new Label();
            this.dtpRecordedDate = new DateTimePicker();
            this.label8 = new Label();
            this.label7 = new Label();
            this.label6 = new Label();
            this.cboPatientCareer = new ComboBox();
            this.txtPatientPhone = new TextBox();
            this.label5 = new Label();
            this.txtPatientAddress = new TextBox();
            this.label4 = new Label();
            this.label3 = new Label();
            this.cboPatientGender = new ComboBox();
            this.txtPatientAge = new TextBox();
            this.label2 = new Label();
            this.txtPatientName = new TextBox();
            this.label1 = new Label();
            this.label11 = new Label();
            this.nudNoOfPicture = new NumericUpDown();
            this.lblCapture = new LinkLabel();
            this.pic_Frame3 = new PictureBox();
            this.pic_Frame2 = new PictureBox();
            this.pic_Frame1 = new PictureBox();
            this.label10 = new Label();
            this.lblShow_ = new Label();
            this.lstCareerID = new ListBox();
            this.lstComboName = new ListBox();
            this.pic_Frame4 = new PictureBox();
            this.txtNote_1 = new TextBox();
            this.txtNote_2 = new TextBox();
            this.txtNote_3 = new TextBox();
            this.txtNote_4 = new TextBox();
            this.toolStrip1 = new ToolStrip();
            this.tsbtnSave = new ToolStripButton();
            this.tsbtnPrint = new ToolStripButton();
            this.tsbtnPreview = new ToolStripButton();
            this.btsDeleteProfile = new ToolStripButton();
            this.prtGetPrinterSetting = new PrintDialog();
            this.btn_pic_Frame1 = new Button();
            this.btn_pic_Frame2 = new Button();
            this.btn_pic_Frame3 = new Button();
            this.btn_pic_Frame4 = new Button();
            this.opdGetImage = new OpenFileDialog();
            this.label12 = new Label();
            this.lblLastTreatment = new Label();
            this.cboImageSize = new ComboBox();
            this.label13 = new Label();
            this.lblDoctorNote = new Label();
            this.btnFillingWay = new Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame4)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboDrName);
            this.groupBox1.Controls.Add(this.btnSearchPatient);
            this.groupBox1.Controls.Add(this.txtRecordID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpRecordedDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboPatientCareer);
            this.groupBox1.Controls.Add(this.txtPatientPhone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPatientAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboPatientGender);
            this.groupBox1.Controls.Add(this.txtPatientAge);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.nudNoOfPicture);
            this.groupBox1.Controls.Add(this.lblCapture);
            this.groupBox1.Location = new System.Drawing.Point(2, 22);
            this.groupBox1.Margin = new Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(689, 93);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // cboDrName
            // 
            this.cboDrName.FlatStyle = FlatStyle.Flat;
            this.cboDrName.FormattingEnabled = true;
            this.cboDrName.Location = new System.Drawing.Point(268, 68);
            this.cboDrName.Margin = new Padding(1);
            this.cboDrName.Name = "cboDrName";
            this.cboDrName.Size = new System.Drawing.Size(182, 21);
            this.cboDrName.TabIndex = 37;
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchPatient.BackgroundImage")));
            this.btnSearchPatient.BackgroundImageLayout = ImageLayout.Center;
            this.btnSearchPatient.Location = new System.Drawing.Point(317, 8);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(34, 29);
            this.btnSearchPatient.TabIndex = 2;
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            this.btnSearchPatient.Click += new System.EventHandler(this.Button1Click);
            // 
            // txtRecordID
            // 
            this.txtRecordID.BorderStyle = BorderStyle.FixedSingle;
            this.txtRecordID.Location = new System.Drawing.Point(132, 8);
            this.txtRecordID.Margin = new Padding(1);
            this.txtRecordID.Name = "txtRecordID";
            this.txtRecordID.Size = new System.Drawing.Size(181, 20);
            this.txtRecordID.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(6, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 18);
            this.label9.TabIndex = 36;
            this.label9.Text = "SỐ PHIẾU KHÁM:";
            // 
            // dtpRecordedDate
            // 
            this.dtpRecordedDate.AllowDrop = true;
            this.dtpRecordedDate.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
                        | AnchorStyles.Left)
                        | AnchorStyles.Right)));
            this.dtpRecordedDate.Cursor = Cursors.Hand;
            this.dtpRecordedDate.Format = DateTimePickerFormat.Short;
            this.dtpRecordedDate.Location = new System.Drawing.Point(546, 49);
            this.dtpRecordedDate.Margin = new Padding(1);
            this.dtpRecordedDate.Name = "dtpRecordedDate";
            this.dtpRecordedDate.Size = new System.Drawing.Size(122, 20);
            this.dtpRecordedDate.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(454, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "NGÀY KHÁM:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(219, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "BÁC SĨ";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "NGHỀ NGHIỆP:";
            // 
            // cboPatientCareer
            // 
            this.cboPatientCareer.FlatStyle = FlatStyle.Flat;
            this.cboPatientCareer.FormattingEnabled = true;
            this.cboPatientCareer.Location = new System.Drawing.Point(133, 66);
            this.cboPatientCareer.Margin = new Padding(1);
            this.cboPatientCareer.Name = "cboPatientCareer";
            this.cboPatientCareer.Size = new System.Drawing.Size(82, 21);
            this.cboPatientCareer.TabIndex = 7;
            // 
            // txtPatientPhone
            // 
            this.txtPatientPhone.BorderStyle = BorderStyle.FixedSingle;
            this.txtPatientPhone.Location = new System.Drawing.Point(546, 27);
            this.txtPatientPhone.Margin = new Padding(1);
            this.txtPatientPhone.Name = "txtPatientPhone";
            this.txtPatientPhone.Size = new System.Drawing.Size(122, 20);
            this.txtPatientPhone.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(454, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "ĐIỆN THOẠI:";
            // 
            // txtPatientAddress
            // 
            this.txtPatientAddress.BorderStyle = BorderStyle.FixedSingle;
            this.txtPatientAddress.Location = new System.Drawing.Point(132, 46);
            this.txtPatientAddress.Margin = new Padding(1);
            this.txtPatientAddress.Name = "txtPatientAddress";
            this.txtPatientAddress.Size = new System.Drawing.Size(318, 20);
            this.txtPatientAddress.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "ĐỊA CHỈ:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(454, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "GIỚI TÍNH:";
            // 
            // cboPatientGender
            // 
            this.cboPatientGender.FlatStyle = FlatStyle.Flat;
            this.cboPatientGender.FormattingEnabled = true;
            this.cboPatientGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboPatientGender.Location = new System.Drawing.Point(546, 6);
            this.cboPatientGender.Margin = new Padding(1);
            this.cboPatientGender.Name = "cboPatientGender";
            this.cboPatientGender.Size = new System.Drawing.Size(119, 21);
            this.cboPatientGender.TabIndex = 4;
            // 
            // txtPatientAge
            // 
            this.txtPatientAge.BorderStyle = BorderStyle.FixedSingle;
            this.txtPatientAge.Location = new System.Drawing.Point(399, 9);
            this.txtPatientAge.Margin = new Padding(1);
            this.txtPatientAge.Name = "txtPatientAge";
            this.txtPatientAge.Size = new System.Drawing.Size(50, 20);
            this.txtPatientAge.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(358, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "TUỔI:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.BorderStyle = BorderStyle.FixedSingle;
            this.txtPatientName.Location = new System.Drawing.Point(132, 27);
            this.txtPatientName.Margin = new Padding(1);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(181, 20);
            this.txtPatientName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "HỌ TÊN BỆNH NHÂN:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(454, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "CHỌN SỐ ẢNH:";
            // 
            // nudNoOfPicture
            // 
            this.nudNoOfPicture.Location = new System.Drawing.Point(553, 71);
            this.nudNoOfPicture.Margin = new Padding(1);
            this.nudNoOfPicture.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudNoOfPicture.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoOfPicture.Name = "nudNoOfPicture";
            this.nudNoOfPicture.Size = new System.Drawing.Size(39, 20);
            this.nudNoOfPicture.TabIndex = 30;
            this.nudNoOfPicture.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudNoOfPicture.ValueChanged += new System.EventHandler(this.NudNoOfPictureValueChanged);
            // 
            // lblCapture
            // 
            this.lblCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapture.Location = new System.Drawing.Point(596, 71);
            this.lblCapture.Name = "lblCapture";
            this.lblCapture.Size = new System.Drawing.Size(68, 18);
            this.lblCapture.TabIndex = 31;
            this.lblCapture.TabStop = true;
            this.lblCapture.Text = "Chọn hình";
            this.lblCapture.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lblCapture.LinkClicked += new LinkLabelLinkClickedEventHandler(this.LblCaptureLinkClicked);
            // 
            // pic_Frame3
            // 
            this.pic_Frame3.BackColor = System.Drawing.Color.Silver;
            this.pic_Frame3.BackgroundImageLayout = ImageLayout.Stretch;
            this.pic_Frame3.Location = new System.Drawing.Point(45, 295);
            this.pic_Frame3.Name = "pic_Frame3";
            this.pic_Frame3.Size = new System.Drawing.Size(203, 123);
            this.pic_Frame3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_Frame3.TabIndex = 36;
            this.pic_Frame3.TabStop = false;
            // 
            // pic_Frame2
            // 
            this.pic_Frame2.BackColor = System.Drawing.Color.Silver;
            this.pic_Frame2.BackgroundImageLayout = ImageLayout.Stretch;
            this.pic_Frame2.Location = new System.Drawing.Point(431, 143);
            this.pic_Frame2.Name = "pic_Frame2";
            this.pic_Frame2.Size = new System.Drawing.Size(203, 123);
            this.pic_Frame2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_Frame2.TabIndex = 35;
            this.pic_Frame2.TabStop = false;
            // 
            // pic_Frame1
            // 
            this.pic_Frame1.BackColor = System.Drawing.Color.Silver;
            this.pic_Frame1.BackgroundImageLayout = ImageLayout.Stretch;
            this.pic_Frame1.Image = ((System.Drawing.Image)(resources.GetObject("pic_Frame1.Image")));
            this.pic_Frame1.Location = new System.Drawing.Point(46, 143);
            this.pic_Frame1.Name = "pic_Frame1";
            this.pic_Frame1.Size = new System.Drawing.Size(203, 123);
            this.pic_Frame1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_Frame1.TabIndex = 34;
            this.pic_Frame1.TabStop = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Brown;
            this.label10.Location = new System.Drawing.Point(286, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 117);
            this.label10.TabIndex = 32;
            this.label10.Text = "HÌNH ẢNH NỘI SOI";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblShow_
            // 
            this.lblShow_.Location = new System.Drawing.Point(0, 0);
            this.lblShow_.Name = "lblShow_";
            this.lblShow_.Size = new System.Drawing.Size(100, 23);
            this.lblShow_.TabIndex = 40;
            // 
            // lstCareerID
            // 
            this.lstCareerID.FormattingEnabled = true;
            this.lstCareerID.Location = new System.Drawing.Point(585, -19);
            this.lstCareerID.Name = "lstCareerID";
            this.lstCareerID.Size = new System.Drawing.Size(109, 43);
            this.lstCareerID.TabIndex = 39;
            // 
            // lstComboName
            // 
            this.lstComboName.FormattingEnabled = true;
            this.lstComboName.Location = new System.Drawing.Point(470, -20);
            this.lstComboName.Name = "lstComboName";
            this.lstComboName.Size = new System.Drawing.Size(109, 43);
            this.lstComboName.TabIndex = 41;
            // 
            // pic_Frame4
            // 
            this.pic_Frame4.BackColor = System.Drawing.Color.Silver;
            this.pic_Frame4.BackgroundImageLayout = ImageLayout.Stretch;
            this.pic_Frame4.Location = new System.Drawing.Point(431, 295);
            this.pic_Frame4.Name = "pic_Frame4";
            this.pic_Frame4.Size = new System.Drawing.Size(203, 123);
            this.pic_Frame4.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_Frame4.TabIndex = 43;
            this.pic_Frame4.TabStop = false;
            // 
            // txtNote_1
            // 
            this.txtNote_1.BorderStyle = BorderStyle.FixedSingle;
            this.txtNote_1.Location = new System.Drawing.Point(46, 271);
            this.txtNote_1.Margin = new Padding(1);
            this.txtNote_1.Name = "txtNote_1";
            this.txtNote_1.Size = new System.Drawing.Size(204, 20);
            this.txtNote_1.TabIndex = 46;
            // 
            // txtNote_2
            // 
            this.txtNote_2.BorderStyle = BorderStyle.FixedSingle;
            this.txtNote_2.Location = new System.Drawing.Point(431, 271);
            this.txtNote_2.Margin = new Padding(1);
            this.txtNote_2.Name = "txtNote_2";
            this.txtNote_2.Size = new System.Drawing.Size(204, 20);
            this.txtNote_2.TabIndex = 47;
            // 
            // txtNote_3
            // 
            this.txtNote_3.BorderStyle = BorderStyle.FixedSingle;
            this.txtNote_3.Location = new System.Drawing.Point(45, 423);
            this.txtNote_3.Margin = new Padding(1);
            this.txtNote_3.Name = "txtNote_3";
            this.txtNote_3.Size = new System.Drawing.Size(204, 20);
            this.txtNote_3.TabIndex = 48;
            // 
            // txtNote_4
            // 
            this.txtNote_4.BorderStyle = BorderStyle.FixedSingle;
            this.txtNote_4.Location = new System.Drawing.Point(432, 422);
            this.txtNote_4.Margin = new Padding(1);
            this.txtNote_4.Name = "txtNote_4";
            this.txtNote_4.Size = new System.Drawing.Size(204, 20);
            this.txtNote_4.TabIndex = 49;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new ToolStripItem[] {
            this.tsbtnSave,
            this.tsbtnPrint,
            this.tsbtnPreview,
            this.btsDeleteProfile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(692, 25);
            this.toolStrip1.TabIndex = 52;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(23, 22);
            this.tsbtnSave.Text = "Lưu lại thông tin phiếu khám";
            this.tsbtnSave.Click += new System.EventHandler(this.TsbtnSaveClick);
            // 
            // tsbtnPrint
            // 
            this.tsbtnPrint.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.tsbtnPrint.Enabled = false;
            this.tsbtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPrint.Image")));
            this.tsbtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPrint.Name = "tsbtnPrint";
            this.tsbtnPrint.Size = new System.Drawing.Size(23, 22);
            this.tsbtnPrint.Text = "In phiếu khám";
            this.tsbtnPrint.Click += new System.EventHandler(this.tsbtnPrint_Click);
            // 
            // tsbtnPreview
            // 
            this.tsbtnPreview.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.tsbtnPreview.Enabled = false;
            this.tsbtnPreview.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnPreview.Image")));
            this.tsbtnPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnPreview.Name = "tsbtnPreview";
            this.tsbtnPreview.Size = new System.Drawing.Size(23, 22);
            this.tsbtnPreview.Text = "Xem trước bản In phiếu khám";
            this.tsbtnPreview.Click += new System.EventHandler(this.tsbtnPreview_Click);
            // 
            // btsDeleteProfile
            // 
            this.btsDeleteProfile.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.btsDeleteProfile.Enabled = false;
            this.btsDeleteProfile.Image = ((System.Drawing.Image)(resources.GetObject("btsDeleteProfile.Image")));
            this.btsDeleteProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btsDeleteProfile.Name = "btsDeleteProfile";
            this.btsDeleteProfile.Size = new System.Drawing.Size(23, 22);
            this.btsDeleteProfile.Text = "toolStripButton1";
            this.btsDeleteProfile.Click += new System.EventHandler(this.BtsDeleteProfileClick);
            // 
            // prtGetPrinterSetting
            // 
            this.prtGetPrinterSetting.UseEXDialog = true;
            // 
            // btn_pic_Frame1
            // 
            this.btn_pic_Frame1.Location = new System.Drawing.Point(226, 243);
            this.btn_pic_Frame1.Margin = new Padding(0, 3, 0, 3);
            this.btn_pic_Frame1.Name = "btn_pic_Frame1";
            this.btn_pic_Frame1.Size = new System.Drawing.Size(22, 23);
            this.btn_pic_Frame1.TabIndex = 53;
            this.btn_pic_Frame1.TabStop = false;
            this.btn_pic_Frame1.Text = "...";
            this.btn_pic_Frame1.UseVisualStyleBackColor = true;
            // 
            // btn_pic_Frame2
            // 
            this.btn_pic_Frame2.Location = new System.Drawing.Point(613, 244);
            this.btn_pic_Frame2.Margin = new Padding(0, 3, 0, 3);
            this.btn_pic_Frame2.Name = "btn_pic_Frame2";
            this.btn_pic_Frame2.Size = new System.Drawing.Size(22, 23);
            this.btn_pic_Frame2.TabIndex = 54;
            this.btn_pic_Frame2.TabStop = false;
            this.btn_pic_Frame2.Text = "...";
            this.btn_pic_Frame2.UseVisualStyleBackColor = true;
            // 
            // btn_pic_Frame3
            // 
            this.btn_pic_Frame3.Location = new System.Drawing.Point(227, 396);
            this.btn_pic_Frame3.Margin = new Padding(0, 3, 0, 3);
            this.btn_pic_Frame3.Name = "btn_pic_Frame3";
            this.btn_pic_Frame3.Size = new System.Drawing.Size(22, 23);
            this.btn_pic_Frame3.TabIndex = 55;
            this.btn_pic_Frame3.TabStop = false;
            this.btn_pic_Frame3.Text = "...";
            this.btn_pic_Frame3.UseVisualStyleBackColor = true;
            // 
            // btn_pic_Frame4
            // 
            this.btn_pic_Frame4.Location = new System.Drawing.Point(614, 395);
            this.btn_pic_Frame4.Margin = new Padding(0, 3, 0, 3);
            this.btn_pic_Frame4.Name = "btn_pic_Frame4";
            this.btn_pic_Frame4.Size = new System.Drawing.Size(22, 23);
            this.btn_pic_Frame4.TabIndex = 56;
            this.btn_pic_Frame4.TabStop = false;
            this.btn_pic_Frame4.Text = "...";
            this.btn_pic_Frame4.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(0, 448);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 21);
            this.label12.TabIndex = 59;
            this.label12.Text = "KẾT LUẬN:";
            // 
            // lblLastTreatment
            // 
            this.lblLastTreatment.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastTreatment.ForeColor = System.Drawing.Color.Red;
            this.lblLastTreatment.Location = new System.Drawing.Point(1, 474);
            this.lblLastTreatment.Name = "lblLastTreatment";
            this.lblLastTreatment.Size = new System.Drawing.Size(163, 21);
            this.lblLastTreatment.TabIndex = 60;
            this.lblLastTreatment.Text = "HƯỚNG ĐIỀU TRỊ:";
            // 
            // cboImageSize
            // 
            this.cboImageSize.FlatStyle = FlatStyle.Flat;
            this.cboImageSize.FormattingEnabled = true;
            this.cboImageSize.Location = new System.Drawing.Point(578, 117);
            this.cboImageSize.Margin = new Padding(1);
            this.cboImageSize.Name = "cboImageSize";
            this.cboImageSize.Size = new System.Drawing.Size(106, 21);
            this.cboImageSize.TabIndex = 62;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(462, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 16);
            this.label13.TabIndex = 61;
            this.label13.Text = "KÍCH THƯỚC ẢNH:";
            // 
            // lblDoctorNote
            // 
            this.lblDoctorNote.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorNote.ForeColor = System.Drawing.Color.Red;
            this.lblDoctorNote.Location = new System.Drawing.Point(1, 495);
            this.lblDoctorNote.Name = "lblDoctorNote";
            this.lblDoctorNote.Size = new System.Drawing.Size(175, 21);
            this.lblDoctorNote.TabIndex = 63;
            this.lblDoctorNote.Text = "LỜI DẶN CỦA BÁC SĨ:";
            // 
            // btnFillingWay
            // 
            this.btnFillingWay.Location = new System.Drawing.Point(5, 117);
            this.btnFillingWay.Name = "btnFillingWay";
            this.btnFillingWay.Size = new System.Drawing.Size(33, 21);
            this.btnFillingWay.TabIndex = 64;
            this.btnFillingWay.Text = "button1";
            this.btnFillingWay.UseVisualStyleBackColor = true;
            this.btnFillingWay.Click += new System.EventHandler(this.btnFillingWay_Click);
            // 
            // frmPatientRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 715);
            this.Controls.Add(this.btnFillingWay);
            this.Controls.Add(this.lblDoctorNote);
            this.Controls.Add(this.cboImageSize);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblLastTreatment);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_pic_Frame4);
            this.Controls.Add(this.btn_pic_Frame3);
            this.Controls.Add(this.btn_pic_Frame2);
            this.Controls.Add(this.btn_pic_Frame1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtNote_4);
            this.Controls.Add(this.txtNote_3);
            this.Controls.Add(this.txtNote_2);
            this.Controls.Add(this.txtNote_1);
            this.Controls.Add(this.pic_Frame4);
            this.Controls.Add(this.lstComboName);
            this.Controls.Add(this.lstCareerID);
            this.Controls.Add(this.lblShow_);
            this.Controls.Add(this.pic_Frame3);
            this.Controls.Add(this.pic_Frame2);
            this.Controls.Add(this.pic_Frame1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPatientRecord";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Phieu kham";
            this.Load += new System.EventHandler(this.FrmPatientRecordLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame4)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}		
		private ToolStripButton btsDeleteProfile;
		private Label lblDoctorNote;
		private ComboBox cboImageSize;
		private Label label13;
		private Label lblLastTreatment;
		private Label label12;
        private OpenFileDialog opdGetImage;
		private Button btn_pic_Frame4;
		private Button btn_pic_Frame3;
		private Button btn_pic_Frame2;
		private Button btn_pic_Frame1;
		private ComboBox cboDrName;
		private PrintDialog prtGetPrinterSetting;
		private Button btnSearchPatient;
		private ToolStripButton tsbtnPrint;
		private ToolStripButton tsbtnPreview;
		private ToolStripButton tsbtnSave;
		private ToolStrip toolStrip1;
		public PictureBox pic_Frame2;
		public PictureBox pic_Frame3;
		public PictureBox pic_Frame1;
        public PictureBox pic_Frame4;
		private LinkLabel lblCapture;
		private TextBox txtNote_1;
		private TextBox txtNote_2;
		private TextBox txtNote_3;
        private TextBox txtNote_4;		
		private ListBox lstComboName;
		private ListBox lstCareerID;
		private Label lblShow_;
		private TextBox txtPatientAddress;		
		private NumericUpDown nudNoOfPicture;
		private ComboBox cboPatientCareer;
		private DateTimePicker dtpRecordedDate;
		private ComboBox cboPatientGender;
		private TextBox txtPatientPhone;
		private TextBox txtPatientName;
		private TextBox txtPatientAge;
		private TextBox txtRecordID;
		private Label label11;
		private GroupBox groupBox1;
		private Label label10;
		private Label label9;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		
		void TsbtnSaveClick(object sender, EventArgs e)
		{
			this.saveData();
		}

        private Button btnFillingWay;
	}
}
