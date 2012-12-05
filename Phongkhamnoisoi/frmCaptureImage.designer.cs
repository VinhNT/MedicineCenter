/*
 * Created by VinhNT email: VinhNT_gands@yahoo.com
 * User: Administrator
 * Date: 3/6/2009
 * Time: 11:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Windows.Forms;
namespace Phongkhamnoisoi
{
	partial class frmCaptureImage
	{
		private System.ComponentModel.IContainer components = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaptureImage));
            this.label1 = new Label();
            this.cboSelectDevide = new ComboBox();
            this.lblCaptureStart = new LinkLabel();
            this.picPreview = new PictureBox();
            this.lnkButtonCaptureImage = new LinkLabel();
            this.btnOK = new Button();
            this.label11 = new Label();
            this.nudNoOfPicture = new NumericUpDown();
            this.label2 = new Label();
            this.nudFrameNo = new NumericUpDown();
            this.pic_Frame1 = new PictureBox();
            this.pic_Frame9 = new PictureBox();
            this.pic_Frame8 = new PictureBox();
            this.pic_Frame7 = new PictureBox();
            this.pic_Frame6 = new PictureBox();
            this.pic_Frame5 = new PictureBox();
            this.pic_Frame4 = new PictureBox();
            this.pic_Frame3 = new PictureBox();
            this.pic_Frame2 = new PictureBox();
            this.chkSelect_1 = new CheckBox();
            this.chkSelect_2 = new CheckBox();
            this.chkSelect_3 = new CheckBox();
            this.chkSelect_4 = new CheckBox();
            this.chkSelect_5 = new CheckBox();
            this.chkSelect_6 = new CheckBox();
            this.chkSelect_7 = new CheckBox();
            this.chkSelect_8 = new CheckBox();
            this.chkSelect_9 = new CheckBox();
            this.pic_Frame12 = new PictureBox();
            this.pic_Frame11 = new PictureBox();
            this.pic_Frame10 = new PictureBox();
            this.chkSelect_10 = new CheckBox();
            this.chkSelect_11 = new CheckBox();
            this.chkSelect_12 = new CheckBox();
            this.lblCameraOption = new LinkLabel();
            this.chkSelect_13 = new CheckBox();
            this.pic_Frame13 = new PictureBox();
            this.chkSelect_14 = new CheckBox();
            this.pic_Frame14 = new PictureBox();
            this.chkSelect_15 = new CheckBox();
            this.pic_Frame15 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame15)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lựa chọn thiết bị: ";
            // 
            // cboSelectDevide
            // 
            this.cboSelectDevide.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboSelectDevide.FlatStyle = FlatStyle.Flat;
            this.cboSelectDevide.FormattingEnabled = true;
            this.cboSelectDevide.Location = new System.Drawing.Point(129, 7);
            this.cboSelectDevide.Name = "cboSelectDevide";
            this.cboSelectDevide.Size = new System.Drawing.Size(278, 21);
            this.cboSelectDevide.TabIndex = 0;
            // 
            // lblCaptureStart
            // 
            this.lblCaptureStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptureStart.Location = new System.Drawing.Point(413, 6);
            this.lblCaptureStart.Name = "lblCaptureStart";
            this.lblCaptureStart.Size = new System.Drawing.Size(68, 19);
            this.lblCaptureStart.TabIndex = 1;
            this.lblCaptureStart.TabStop = true;
            this.lblCaptureStart.Text = "Bắt đầu";
            this.lblCaptureStart.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lblCaptureStart.LinkClicked += new LinkLabelLinkClickedEventHandler(this.LblCaptureLinkClicked);
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.Silver;
            this.picPreview.Location = new System.Drawing.Point(14, 31);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(500, 375);
            this.picPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picPreview.TabIndex = 33;
            this.picPreview.TabStop = false;
            // 
            // lnkButtonCaptureImage
            // 
            this.lnkButtonCaptureImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkButtonCaptureImage.Location = new System.Drawing.Point(12, 409);
            this.lnkButtonCaptureImage.Name = "lnkButtonCaptureImage";
            this.lnkButtonCaptureImage.Size = new System.Drawing.Size(181, 36);
            this.lnkButtonCaptureImage.TabIndex = 2;
            this.lnkButtonCaptureImage.TabStop = true;
            this.lnkButtonCaptureImage.Text = "CHỤP ẢNH";
            this.lnkButtonCaptureImage.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lnkButtonCaptureImage.LinkClicked += new LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(18, 448);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(496, 57);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "&Chấp nhận";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOKClick);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(484, 7);
            this.label11.Margin = new Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 18);
            this.label11.TabIndex = 55;
            this.label11.Text = "Lựa chọn số ảnh:";
            this.label11.Visible = false;
            // 
            // nudNoOfPicture
            // 
            this.nudNoOfPicture.Location = new System.Drawing.Point(615, 5);
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
            this.nudNoOfPicture.Size = new System.Drawing.Size(40, 20);
            this.nudNoOfPicture.TabIndex = 54;
            this.nudNoOfPicture.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNoOfPicture.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(364, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 72;
            this.label2.Text = "Khung nhận ảnh:";
            // 
            // nudFrameNo
            // 
            this.nudFrameNo.Location = new System.Drawing.Point(475, 409);
            this.nudFrameNo.Margin = new Padding(1);
            this.nudFrameNo.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudFrameNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFrameNo.Name = "nudFrameNo";
            this.nudFrameNo.Size = new System.Drawing.Size(40, 20);
            this.nudFrameNo.TabIndex = 71;
            this.nudFrameNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pic_Frame1
            // 
            this.pic_Frame1.BackColor = System.Drawing.Color.Silver;
            this.pic_Frame1.BackgroundImageLayout = ImageLayout.Center;
            this.pic_Frame1.Location = new System.Drawing.Point(557, 31);
            this.pic_Frame1.Name = "pic_Frame1";
            this.pic_Frame1.Size = new System.Drawing.Size(106, 80);
            this.pic_Frame1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_Frame1.TabIndex = 34;
            this.pic_Frame1.TabStop = false;
            // 
            // pic_Frame9
            // 
            this.pic_Frame9.BackColor = System.Drawing.Color.Silver;
            this.pic_Frame9.BackgroundImageLayout = ImageLayout.Center;
            this.pic_Frame9.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_Frame9.InitialImage")));
            this.pic_Frame9.Location = new System.Drawing.Point(789, 203);
            this.pic_Frame9.Name = "pic_Frame9";
            this.pic_Frame9.Size = new System.Drawing.Size(106, 80);
            this.pic_Frame9.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_Frame9.TabIndex = 38;
            this.pic_Frame9.TabStop = false;
            // 
            // pic_Frame8
            // 
            this.pic_Frame8.BackColor = System.Drawing.Color.Silver;
            this.pic_Frame8.BackgroundImageLayout = ImageLayout.Center;
            this.pic_Frame8.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_Frame8.InitialImage")));
            this.pic_Frame8.Location = new System.Drawing.Point(673, 201);
            this.pic_Frame8.Name = "pic_Frame8";
            this.pic_Frame8.Size = new System.Drawing.Size(106, 80);
            this.pic_Frame8.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_Frame8.TabIndex = 39;
            this.pic_Frame8.TabStop = false;
            // 
            // pic_Frame7
            // 
            this.pic_Frame7.BackColor = System.Drawing.Color.Silver;
            this.pic_Frame7.BackgroundImageLayout = ImageLayout.Center;
            this.pic_Frame7.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_Frame7.InitialImage")));
            this.pic_Frame7.Location = new System.Drawing.Point(557, 203);
            this.pic_Frame7.Name = "pic_Frame7";
            this.pic_Frame7.Size = new System.Drawing.Size(106, 80);
            this.pic_Frame7.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_Frame7.TabIndex = 40;
            this.pic_Frame7.TabStop = false;
            // 
            // pic_Frame6
            // 
            this.pic_Frame6.BackColor = System.Drawing.Color.Silver;
            this.pic_Frame6.BackgroundImageLayout = ImageLayout.Center;
            this.pic_Frame6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_Frame6.InitialImage")));
            this.pic_Frame6.Location = new System.Drawing.Point(789, 117);
            this.pic_Frame6.Name = "pic_Frame6";
            this.pic_Frame6.Size = new System.Drawing.Size(106, 80);
            this.pic_Frame6.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_Frame6.TabIndex = 41;
            this.pic_Frame6.TabStop = false;
            // 
            // pic_Frame5
            // 
            this.pic_Frame5.BackColor = System.Drawing.Color.Silver;
            this.pic_Frame5.BackgroundImageLayout = ImageLayout.Center;
            this.pic_Frame5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_Frame5.InitialImage")));
            this.pic_Frame5.Location = new System.Drawing.Point(673, 117);
            this.pic_Frame5.Name = "pic_Frame5";
            this.pic_Frame5.Size = new System.Drawing.Size(106, 80);
            this.pic_Frame5.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_Frame5.TabIndex = 42;
            this.pic_Frame5.TabStop = false;
            // 
            // pic_Frame4
            // 
            this.pic_Frame4.BackColor = System.Drawing.Color.Silver;
            this.pic_Frame4.BackgroundImageLayout = ImageLayout.Center;
            this.pic_Frame4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_Frame4.InitialImage")));
            this.pic_Frame4.Location = new System.Drawing.Point(558, 117);
            this.pic_Frame4.Name = "pic_Frame4";
            this.pic_Frame4.Size = new System.Drawing.Size(106, 80);
            this.pic_Frame4.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_Frame4.TabIndex = 43;
            this.pic_Frame4.TabStop = false;
            // 
            // pic_Frame3
            // 
            this.pic_Frame3.BackColor = System.Drawing.Color.Silver;
            this.pic_Frame3.BackgroundImageLayout = ImageLayout.Center;
            this.pic_Frame3.Location = new System.Drawing.Point(789, 31);
            this.pic_Frame3.Name = "pic_Frame3";
            this.pic_Frame3.Size = new System.Drawing.Size(106, 80);
            this.pic_Frame3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_Frame3.TabIndex = 44;
            this.pic_Frame3.TabStop = false;
            // 
            // pic_Frame2
            // 
            this.pic_Frame2.BackColor = System.Drawing.Color.Silver;
            this.pic_Frame2.BackgroundImageLayout = ImageLayout.Center;
            this.pic_Frame2.Location = new System.Drawing.Point(674, 31);
            this.pic_Frame2.Name = "pic_Frame2";
            this.pic_Frame2.Size = new System.Drawing.Size(106, 80);
            this.pic_Frame2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_Frame2.TabIndex = 45;
            this.pic_Frame2.TabStop = false;
            // 
            // chkSelect_1
            // 
            this.chkSelect_1.Location = new System.Drawing.Point(558, 95);
            this.chkSelect_1.Name = "chkSelect_1";
            this.chkSelect_1.Size = new System.Drawing.Size(14, 16);
            this.chkSelect_1.TabIndex = 56;
            this.chkSelect_1.TabStop = false;
            this.chkSelect_1.UseVisualStyleBackColor = true;
            // 
            // chkSelect_2
            // 
            this.chkSelect_2.Location = new System.Drawing.Point(674, 95);
            this.chkSelect_2.Name = "chkSelect_2";
            this.chkSelect_2.Size = new System.Drawing.Size(14, 16);
            this.chkSelect_2.TabIndex = 57;
            this.chkSelect_2.TabStop = false;
            this.chkSelect_2.UseVisualStyleBackColor = true;
            // 
            // chkSelect_3
            // 
            this.chkSelect_3.Location = new System.Drawing.Point(789, 95);
            this.chkSelect_3.Name = "chkSelect_3";
            this.chkSelect_3.Size = new System.Drawing.Size(14, 16);
            this.chkSelect_3.TabIndex = 58;
            this.chkSelect_3.TabStop = false;
            this.chkSelect_3.UseVisualStyleBackColor = true;
            // 
            // chkSelect_4
            // 
            this.chkSelect_4.Location = new System.Drawing.Point(558, 181);
            this.chkSelect_4.Name = "chkSelect_4";
            this.chkSelect_4.Size = new System.Drawing.Size(14, 16);
            this.chkSelect_4.TabIndex = 59;
            this.chkSelect_4.TabStop = false;
            this.chkSelect_4.UseVisualStyleBackColor = true;
            // 
            // chkSelect_5
            // 
            this.chkSelect_5.Location = new System.Drawing.Point(673, 181);
            this.chkSelect_5.Name = "chkSelect_5";
            this.chkSelect_5.Size = new System.Drawing.Size(14, 16);
            this.chkSelect_5.TabIndex = 60;
            this.chkSelect_5.TabStop = false;
            this.chkSelect_5.UseVisualStyleBackColor = true;
            // 
            // chkSelect_6
            // 
            this.chkSelect_6.Location = new System.Drawing.Point(789, 181);
            this.chkSelect_6.Name = "chkSelect_6";
            this.chkSelect_6.Size = new System.Drawing.Size(14, 16);
            this.chkSelect_6.TabIndex = 61;
            this.chkSelect_6.TabStop = false;
            this.chkSelect_6.UseVisualStyleBackColor = true;
            // 
            // chkSelect_7
            // 
            this.chkSelect_7.Location = new System.Drawing.Point(557, 267);
            this.chkSelect_7.Name = "chkSelect_7";
            this.chkSelect_7.Size = new System.Drawing.Size(14, 16);
            this.chkSelect_7.TabIndex = 62;
            this.chkSelect_7.TabStop = false;
            this.chkSelect_7.UseVisualStyleBackColor = true;
            // 
            // chkSelect_8
            // 
            this.chkSelect_8.Location = new System.Drawing.Point(673, 265);
            this.chkSelect_8.Name = "chkSelect_8";
            this.chkSelect_8.Size = new System.Drawing.Size(14, 16);
            this.chkSelect_8.TabIndex = 63;
            this.chkSelect_8.TabStop = false;
            this.chkSelect_8.UseVisualStyleBackColor = true;
            // 
            // chkSelect_9
            // 
            this.chkSelect_9.Location = new System.Drawing.Point(789, 265);
            this.chkSelect_9.Name = "chkSelect_9";
            this.chkSelect_9.Size = new System.Drawing.Size(14, 16);
            this.chkSelect_9.TabIndex = 64;
            this.chkSelect_9.TabStop = false;
            this.chkSelect_9.UseVisualStyleBackColor = true;
            // 
            // pic_Frame12
            // 
            this.pic_Frame12.BackColor = System.Drawing.Color.Silver;
            this.pic_Frame12.BackgroundImageLayout = ImageLayout.Center;
            this.pic_Frame12.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_Frame12.InitialImage")));
            this.pic_Frame12.Location = new System.Drawing.Point(788, 287);
            this.pic_Frame12.Name = "pic_Frame12";
            this.pic_Frame12.Size = new System.Drawing.Size(106, 80);
            this.pic_Frame12.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_Frame12.TabIndex = 65;
            this.pic_Frame12.TabStop = false;
            // 
            // pic_Frame11
            // 
            this.pic_Frame11.BackColor = System.Drawing.Color.Silver;
            this.pic_Frame11.BackgroundImageLayout = ImageLayout.Center;
            this.pic_Frame11.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_Frame11.InitialImage")));
            this.pic_Frame11.Location = new System.Drawing.Point(673, 287);
            this.pic_Frame11.Name = "pic_Frame11";
            this.pic_Frame11.Size = new System.Drawing.Size(106, 80);
            this.pic_Frame11.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_Frame11.TabIndex = 66;
            this.pic_Frame11.TabStop = false;
            // 
            // pic_Frame10
            // 
            this.pic_Frame10.BackColor = System.Drawing.Color.Silver;
            this.pic_Frame10.BackgroundImageLayout = ImageLayout.Center;
            this.pic_Frame10.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_Frame10.InitialImage")));
            this.pic_Frame10.Location = new System.Drawing.Point(558, 287);
            this.pic_Frame10.Name = "pic_Frame10";
            this.pic_Frame10.Size = new System.Drawing.Size(106, 80);
            this.pic_Frame10.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_Frame10.TabIndex = 67;
            this.pic_Frame10.TabStop = false;
            // 
            // chkSelect_10
            // 
            this.chkSelect_10.Location = new System.Drawing.Point(558, 353);
            this.chkSelect_10.Name = "chkSelect_10";
            this.chkSelect_10.Size = new System.Drawing.Size(14, 16);
            this.chkSelect_10.TabIndex = 68;
            this.chkSelect_10.TabStop = false;
            this.chkSelect_10.UseVisualStyleBackColor = true;
            // 
            // chkSelect_11
            // 
            this.chkSelect_11.Location = new System.Drawing.Point(673, 353);
            this.chkSelect_11.Name = "chkSelect_11";
            this.chkSelect_11.Size = new System.Drawing.Size(14, 16);
            this.chkSelect_11.TabIndex = 69;
            this.chkSelect_11.TabStop = false;
            this.chkSelect_11.UseVisualStyleBackColor = true;
            // 
            // chkSelect_12
            // 
            this.chkSelect_12.Location = new System.Drawing.Point(788, 353);
            this.chkSelect_12.Name = "chkSelect_12";
            this.chkSelect_12.Size = new System.Drawing.Size(14, 16);
            this.chkSelect_12.TabIndex = 70;
            this.chkSelect_12.TabStop = false;
            this.chkSelect_12.UseVisualStyleBackColor = true;
            // 
            // lblCameraOption
            // 
            this.lblCameraOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCameraOption.Location = new System.Drawing.Point(164, 422);
            this.lblCameraOption.Name = "lblCameraOption";
            this.lblCameraOption.Size = new System.Drawing.Size(99, 19);
            this.lblCameraOption.TabIndex = 73;
            this.lblCameraOption.TabStop = true;
            this.lblCameraOption.Text = "Camera Option";
            this.lblCameraOption.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lblCameraOption.LinkClicked += new LinkLabelLinkClickedEventHandler(this.LblCameraOptionLinkClicked);
            // 
            // chkSelect_13
            // 
            this.chkSelect_13.Location = new System.Drawing.Point(558, 433);
            this.chkSelect_13.Name = "chkSelect_13";
            this.chkSelect_13.Size = new System.Drawing.Size(14, 16);
            this.chkSelect_13.TabIndex = 75;
            this.chkSelect_13.TabStop = false;
            this.chkSelect_13.UseVisualStyleBackColor = true;
            // 
            // pic_Frame13
            // 
            this.pic_Frame13.BackColor = System.Drawing.Color.Silver;
            this.pic_Frame13.BackgroundImageLayout = ImageLayout.Center;
            this.pic_Frame13.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_Frame13.InitialImage")));
            this.pic_Frame13.Location = new System.Drawing.Point(558, 371);
            this.pic_Frame13.Name = "pic_Frame13";
            this.pic_Frame13.Size = new System.Drawing.Size(106, 80);
            this.pic_Frame13.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_Frame13.TabIndex = 74;
            this.pic_Frame13.TabStop = false;
            // 
            // chkSelect_14
            // 
            this.chkSelect_14.Location = new System.Drawing.Point(673, 435);
            this.chkSelect_14.Name = "chkSelect_14";
            this.chkSelect_14.Size = new System.Drawing.Size(14, 16);
            this.chkSelect_14.TabIndex = 77;
            this.chkSelect_14.TabStop = false;
            this.chkSelect_14.UseVisualStyleBackColor = true;
            // 
            // pic_Frame14
            // 
            this.pic_Frame14.BackColor = System.Drawing.Color.Silver;
            this.pic_Frame14.BackgroundImageLayout = ImageLayout.Center;
            this.pic_Frame14.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_Frame14.InitialImage")));
            this.pic_Frame14.Location = new System.Drawing.Point(673, 373);
            this.pic_Frame14.Name = "pic_Frame14";
            this.pic_Frame14.Size = new System.Drawing.Size(106, 80);
            this.pic_Frame14.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_Frame14.TabIndex = 76;
            this.pic_Frame14.TabStop = false;
            // 
            // chkSelect_15
            // 
            this.chkSelect_15.Location = new System.Drawing.Point(789, 435);
            this.chkSelect_15.Name = "chkSelect_15";
            this.chkSelect_15.Size = new System.Drawing.Size(14, 16);
            this.chkSelect_15.TabIndex = 79;
            this.chkSelect_15.TabStop = false;
            this.chkSelect_15.UseVisualStyleBackColor = true;
            // 
            // pic_Frame15
            // 
            this.pic_Frame15.BackColor = System.Drawing.Color.Silver;
            this.pic_Frame15.BackgroundImageLayout = ImageLayout.Center;
            this.pic_Frame15.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic_Frame15.InitialImage")));
            this.pic_Frame15.Location = new System.Drawing.Point(789, 373);
            this.pic_Frame15.Name = "pic_Frame15";
            this.pic_Frame15.Size = new System.Drawing.Size(106, 80);
            this.pic_Frame15.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pic_Frame15.TabIndex = 78;
            this.pic_Frame15.TabStop = false;
            // 
            // frmCaptureImage
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 517);
            this.Controls.Add(this.chkSelect_15);
            this.Controls.Add(this.pic_Frame15);
            this.Controls.Add(this.chkSelect_14);
            this.Controls.Add(this.pic_Frame14);
            this.Controls.Add(this.chkSelect_13);
            this.Controls.Add(this.pic_Frame13);
            this.Controls.Add(this.lblCameraOption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudFrameNo);
            this.Controls.Add(this.chkSelect_12);
            this.Controls.Add(this.chkSelect_11);
            this.Controls.Add(this.chkSelect_10);
            this.Controls.Add(this.pic_Frame10);
            this.Controls.Add(this.pic_Frame11);
            this.Controls.Add(this.pic_Frame12);
            this.Controls.Add(this.chkSelect_9);
            this.Controls.Add(this.chkSelect_8);
            this.Controls.Add(this.chkSelect_7);
            this.Controls.Add(this.chkSelect_6);
            this.Controls.Add(this.chkSelect_5);
            this.Controls.Add(this.chkSelect_4);
            this.Controls.Add(this.chkSelect_3);
            this.Controls.Add(this.chkSelect_2);
            this.Controls.Add(this.chkSelect_1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nudNoOfPicture);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lnkButtonCaptureImage);
            this.Controls.Add(this.pic_Frame2);
            this.Controls.Add(this.pic_Frame3);
            this.Controls.Add(this.pic_Frame4);
            this.Controls.Add(this.pic_Frame5);
            this.Controls.Add(this.pic_Frame6);
            this.Controls.Add(this.pic_Frame7);
            this.Controls.Add(this.pic_Frame8);
            this.Controls.Add(this.pic_Frame9);
            this.Controls.Add(this.pic_Frame1);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.lblCaptureStart);
            this.Controls.Add(this.cboSelectDevide);
            this.Controls.Add(this.label1);
            this.Name = "frmCaptureImage";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Bam dung, Double click vao cac anh nho de phong to...";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrameNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Frame15)).EndInit();
            this.ResumeLayout(false);

		}
		private CheckBox chkSelect_13;
		private CheckBox chkSelect_14;
        private CheckBox chkSelect_15;
		private PictureBox pic_Frame15;
		private PictureBox pic_Frame13;
		private PictureBox pic_Frame14;
		
		private LinkLabel lblCameraOption;
		private PictureBox picPreview;
		private LinkLabel lblCaptureStart;
		private LinkLabel lnkButtonCaptureImage;
		private NumericUpDown nudFrameNo;
		private Label label2;
        private Button btnOK;
		private CheckBox chkSelect_3;
		private CheckBox chkSelect_4;
		private CheckBox chkSelect_5;
		private CheckBox chkSelect_6;
		private CheckBox chkSelect_7;
		private CheckBox chkSelect_8;
		private CheckBox chkSelect_9;
		private CheckBox chkSelect_12;
		private CheckBox chkSelect_11;
		private CheckBox chkSelect_10;
		private PictureBox pic_Frame10;
		private PictureBox pic_Frame11;
		private PictureBox pic_Frame12;
		private CheckBox chkSelect_2;
		private CheckBox chkSelect_1;
		private NumericUpDown nudNoOfPicture;
		private Label label11;
		private PictureBox pic_Frame1;
		private PictureBox pic_Frame9;
		private PictureBox pic_Frame8;
		private PictureBox pic_Frame7;
		private PictureBox pic_Frame6;
		private PictureBox pic_Frame5;
		private PictureBox pic_Frame4;
		private PictureBox pic_Frame3;
		private PictureBox pic_Frame2;
		private ComboBox cboSelectDevide;
		private Label label1;		
		
		
		void LblCameraOptionLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (isStarted) 
			{
				captureDevice.PropertyPages[cboSelectDevide.SelectedIndex].Show(this);
			}
		}
	}
}
