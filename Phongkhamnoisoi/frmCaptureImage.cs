/*
 * Created by VinhNT email: VinhNT_gands@yahoo.com
 * User: Administrator
 * Date: 3/6/2009
 * Time: 11:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using DirectX.Capture;
using System.Drawing.Imaging;

namespace Phongkhamnoisoi
{
	/// <summary>
	/// Description of frmCaptureImage.
	/// </summary>	
	public partial class frmCaptureImage : Form
	{
		private Filters filters;
		private frmPatientRecord frmReference;
		private bool hasDevice;
		private bool isStarted;		
		private PictureBox memPicture;
		private Capture captureDevice;
		private const string MSG_START = "Bắt đầu";
		private const string MSG_STOP = "Dừng lại";
		private const string ERROR_TOO_MUCH_IMAGE = "Chọn quá nhiều ảnh, vui lòng bỏ bớt ảnh khác trước khi chọn ảnh này";
		private const int NO_OF_TEMPORARY_PICTURE = 15;
		public frmCaptureImage()
		{			
			InitializeComponent();
			initDevide();
		}	

		void frmCaptureImage_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}
		public frmCaptureImage(frmPatientRecord refFrm, int noOfImage)
		{
			InitializeComponent();			
			initDevide();
			this.frmReference = refFrm;
			this.nudNoOfPicture.Value = noOfImage;
		}
		private void initDevide()
		{
			int i; string strDesFrameName;
			PictureBox picDesination;
			CheckBox chkTemp;
			try
            {//This mean enum devices and create a link to device
                filters = new Filters();
                //this.thaoTácToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                if (filters.VideoInputDevices.Count<=0)
                {
                	cboSelectDevide.Items.Add("Không tìm thấy thiết bị...");
                	return;
                }else
                {
                	hasDevice = true;
                }
                for (i=1; i<=filters.VideoInputDevices.Count; i++) cboSelectDevide.Items.Add(filters.VideoInputDevices[i-1].Name);
                this.cboSelectDevide.SelectedIndex = i-2;
            }			
            catch (Exception e)
            {
            	hasDevice = false;
            	MessageBox.Show (e.Message.ToString());
				return;
            }
            isStarted =false;
            memPicture = new PictureBox();
            memPicture.Size = new Size(640 ,480);
            for (i=1; i<=NO_OF_TEMPORARY_PICTURE; i++)
            {
            	strDesFrameName = "pic_Frame" + i.ToString();            	
				picDesination = (PictureBox)this.Controls[strDesFrameName];				
				strDesFrameName = "chkSelect_" + i.ToString();
				chkTemp = (CheckBox) this.Controls[strDesFrameName];
				picDesination.DoubleClick+= new EventHandler(picDesination_DoubleClick);
				chkTemp.CheckStateChanged += new EventHandler(ChkSelect_CheckedChanged);
            }
            this.Disposed += new EventHandler(frmCaptureImage_Disposed);
            this.btnOK.Click += BtnOKClick;
			this.FormClosed+= new FormClosedEventHandler(frmCaptureImage_FormClosed);
			LblCaptureLinkClicked(null, null);
		}

		void frmCaptureImage_Disposed(object sender, EventArgs e)
		{
			if (isStarted)
			{
				if (captureDevice!=null) 
				{		
					if (captureDevice.Capturing) captureDevice.Stop();
					captureDevice.Dispose();					
					this.filters = null;					
				}
				isStarted =false;
			}
		}

		void picDesination_DoubleClick(object sender, EventArgs e)
		{   //Do nothing if the camera is capturing
            PictureBox picTemp;
            if (isStarted) return;
            picTemp = (PictureBox)sender;
            if (picTemp.Image != null)
                picPreview.Image = picTemp.Image;
		}
		int CountSelectedImage()
		{
			string chkName;int i, nCount;
			CheckBox chkTemp;
			nCount = 0;
			for (i=1; i<=NO_OF_TEMPORARY_PICTURE; i++)
			{
				chkName = "chkSelect_" + i.ToString();
				chkTemp = (CheckBox) this.Controls[chkName];
				if (chkTemp.Checked)nCount++;
			}
			return nCount;			
		}
		
		void LblCaptureLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (!hasDevice ) return;
			if (cboSelectDevide.Items.Count==0) return;
			if (cboSelectDevide.SelectedIndex<0) return;
			if (isStarted)
			{
				if (captureDevice!=null) 
				{		
					if (captureDevice.Capturing) captureDevice.Stop();
					captureDevice.Dispose();
				}
				this.lblCaptureStart.Text = MSG_START;
				isStarted =false;
				return;
			}else
			{//start device
				captureDevice = new Capture(filters.VideoInputDevices[cboSelectDevide.SelectedIndex], null);
				captureDevice.FrameSize = new Size(640, 480);
				captureDevice.FrameRate = 30; //20frame/sec
				captureDevice.FrameEvent2+= new Capture.HeFrame(captureDevice_FrameEvent2);
				captureDevice.PreviewWindow = picPreview;				
				//captureDevice.Cue();
				captureDevice.GrapImg();
				//captureDevice.Start();
				isStarted =true;
				this.lblCaptureStart.Text = MSG_STOP;
			}
			
		}
		
		public Image ResizeBitmap(Image b, int nWidth, int nHeight) 
        {
            Bitmap result = new Bitmap(nWidth, nHeight);
            using (Graphics g = Graphics.FromImage((Image)result))    g.DrawImage(b, 0, 0, nWidth, nHeight); 
            return result; 
        }
		
		void captureDevice_FrameEvent2(Bitmap BM)
		{
			if (this.memPicture.Image !=null) this.memPicture.Dispose();
			this.memPicture.Image = BM;
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string strDesFrameName;
			int index;
            PictureBox picDesination;
            if (memPicture == null) return;
			strDesFrameName = "pic_Frame" + nudFrameNo.Text;			
			picDesination = (PictureBox)this.Controls[strDesFrameName];
			
			picDesination.Image = CopyImage(memPicture.Image);
			index = int.Parse(nudFrameNo.Text)-1;
			
			if (nudFrameNo.Value<NO_OF_TEMPORARY_PICTURE)
				nudFrameNo.Value = nudFrameNo.Value+1;
			else
				nudFrameNo.Value =1;
		}	
			
		void ChkSelect_CheckedChanged(object sender, EventArgs e)
		{
			int n;
			CheckBox cCheck;
			cCheck = (CheckBox)sender;
			
			n = int.Parse(nudNoOfPicture.Text);
			if (CountSelectedImage()>n)
			{
				MessageBox.Show (ERROR_TOO_MUCH_IMAGE, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				cCheck.Checked =false;
				return;
			}
		}		
		
		void BtnOKClick(object sender, EventArgs e)
		{
			int i, j;
			string strSourceFrameName, strCheckboxName, strDestinationFrameName;
			PictureBox picDesination, picSource;
			CheckBox chkTemp;
			j = 1;
			for (i=1; i<NO_OF_TEMPORARY_PICTURE+1; i++)
			{
				strSourceFrameName = "pic_Frame" + i.ToString();				
				strCheckboxName = "chkSelect_" + i.ToString();
				//MessageBox.Show(strCheckboxName);
				
				picSource = (PictureBox)this.Controls[strSourceFrameName];
				chkTemp = (CheckBox) this.Controls[strCheckboxName];
				if (chkTemp!=null)
					
				if (chkTemp.Checked)
				{
					strDestinationFrameName = "pic_Frame" + j.ToString();
					picDesination = (PictureBox)frmReference.Controls[strDestinationFrameName];
					picDesination.Image = CopyImage(picSource.Image);
					j++;
					if (j==7) 
					{	
						this.Dispose();
						return;
					}
				}
			}//finish transfering data			
			this.Dispose();
		}//BtnOKClick
		private Bitmap CopyImage(Image value)
		{			
			Bitmap bm = new Bitmap(value.Width, value.Height, PixelFormat.Format32bppArgb);
			Graphics g= Graphics.FromImage(bm);
			g.DrawImage(value, 0, 0, value.Width, value.Height);
			g.Dispose();
			return bm;
		}
		private void FormClosingEventCancle_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			DialogResult dr = MessageBox.Show("Do you REALLY want to close this app?",
			"Closing event!", MessageBoxButtons.YesNo);
			if(dr == DialogResult.No)
				e.Cancel = true;
			else
				e.Cancel = false;    
		}
	}

}