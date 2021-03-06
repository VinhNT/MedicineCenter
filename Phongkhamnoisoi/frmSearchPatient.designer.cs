
using System.Windows.Forms;
namespace Phongkhamnoisoi
{
    partial class frmSearchPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private frmPatientRecord frm4Ref;
        private bool isSearching;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchPatient));
            this.grpFilterData = new GroupBox();
            this.btnFilter = new Button();
            this.cboAge = new ComboBox();
            this.chkAgeFilter = new CheckBox();
            this.cboCareer = new ComboBox();
            this.chkCareerFilter = new CheckBox();
            this.groupBox1 = new GroupBox();
            this.dtDateIndex = new DateTimePicker();
            this.txtSearchKey = new TextBox();
            this.label2 = new Label();
            this.cboSearchIndex = new ComboBox();
            this.label1 = new Label();
            this.btnOK = new Button();
            this.lstPatientList = new DataGridView();
            this.lstCareerID = new ListBox();
            this.lstProfile = new ListView();
            this.btnViewProfileList = new Button();
            this.btnShowProfile = new Button();
            this.grpFilterData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstPatientList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFilterData
            // 
            this.grpFilterData.Controls.Add(this.btnFilter);
            this.grpFilterData.Controls.Add(this.cboAge);
            this.grpFilterData.Controls.Add(this.chkAgeFilter);
            this.grpFilterData.Controls.Add(this.cboCareer);
            this.grpFilterData.Controls.Add(this.chkCareerFilter);
            this.grpFilterData.Location = new System.Drawing.Point(313, 6);
            this.grpFilterData.Name = "grpFilterData";
            this.grpFilterData.Size = new System.Drawing.Size(403, 66);
            this.grpFilterData.TabIndex = 2;
            this.grpFilterData.TabStop = false;
            this.grpFilterData.Text = "Lọc dữ liệu";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(347, 13);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(50, 47);
            this.btnFilter.TabIndex = 10;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.BtnFilterClick);
            // 
            // cboAge
            // 
            this.cboAge.FormattingEnabled = true;
            this.cboAge.Location = new System.Drawing.Point(112, 39);
            this.cboAge.Name = "cboAge";
            this.cboAge.Size = new System.Drawing.Size(229, 21);
            this.cboAge.TabIndex = 9;
            // 
            // chkAgeFilter
            // 
            this.chkAgeFilter.AutoSize = true;
            this.chkAgeFilter.Location = new System.Drawing.Point(7, 43);
            this.chkAgeFilter.Name = "chkAgeFilter";
            this.chkAgeFilter.Size = new System.Drawing.Size(60, 17);
            this.chkAgeFilter.TabIndex = 8;
            this.chkAgeFilter.Text = "Độ tuổi";
            this.chkAgeFilter.UseVisualStyleBackColor = true;
            this.chkAgeFilter.CheckedChanged += new System.EventHandler(this.ChkAgeFilterCheckedChanged);
            // 
            // cboCareer
            // 
            this.cboCareer.FormattingEnabled = true;
            this.cboCareer.Location = new System.Drawing.Point(112, 13);
            this.cboCareer.Name = "cboCareer";
            this.cboCareer.Size = new System.Drawing.Size(229, 21);
            this.cboCareer.TabIndex = 7;
            // 
            // chkCareerFilter
            // 
            this.chkCareerFilter.AutoSize = true;
            this.chkCareerFilter.Location = new System.Drawing.Point(6, 15);
            this.chkCareerFilter.Name = "chkCareerFilter";
            this.chkCareerFilter.Size = new System.Drawing.Size(87, 17);
            this.chkCareerFilter.TabIndex = 6;
            this.chkCareerFilter.Text = "Nghề nghiệp";
            this.chkCareerFilter.UseVisualStyleBackColor = true;
            this.chkCareerFilter.CheckedChanged += new System.EventHandler(this.ChkCareerFilterCheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtDateIndex);
            this.groupBox1.Controls.Add(this.txtSearchKey);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboSearchIndex);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 66);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm nhanh";
            // 
            // dtDateIndex
            // 
            this.dtDateIndex.Location = new System.Drawing.Point(110, 38);
            this.dtDateIndex.Name = "dtDateIndex";
            this.dtDateIndex.Size = new System.Drawing.Size(190, 20);
            this.dtDateIndex.TabIndex = 3;
            this.dtDateIndex.ValueChanged += new System.EventHandler(this.dtDateIndex_ValueChanged);
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Location = new System.Drawing.Point(109, 38);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(190, 20);
            this.txtSearchKey.TabIndex = 2;
            this.txtSearchKey.TextChanged += new System.EventHandler(this.TxtSearchKeyTextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khóa tìm kiếm:";
            // 
            // cboSearchIndex
            // 
            this.cboSearchIndex.FormattingEnabled = true;
            this.cboSearchIndex.Location = new System.Drawing.Point(109, 19);
            this.cboSearchIndex.Name = "cboSearchIndex";
            this.cboSearchIndex.Size = new System.Drawing.Size(190, 21);
            this.cboSearchIndex.TabIndex = 1;
            this.cboSearchIndex.SelectedIndexChanged += new System.EventHandler(this.cboSearchIndex_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêu chí tìm kiếm:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(153, 423);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(432, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "Chấp nhận";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOKClick);
            // 
            // lstPatientList
            // 
            this.lstPatientList.AllowUserToAddRows = false;
            this.lstPatientList.AllowUserToDeleteRows = false;
            this.lstPatientList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            this.lstPatientList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstPatientList.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.lstPatientList.Location = new System.Drawing.Point(2, 78);
            this.lstPatientList.MultiSelect = false;
            this.lstPatientList.Name = "lstPatientList";
            this.lstPatientList.ReadOnly = true;
            this.lstPatientList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.lstPatientList.Size = new System.Drawing.Size(507, 339);
            this.lstPatientList.TabIndex = 13;
            // 
            // lstCareerID
            // 
            this.lstCareerID.FormattingEnabled = true;
            this.lstCareerID.Location = new System.Drawing.Point(-270, -6);
            this.lstCareerID.Name = "lstCareerID";
            this.lstCareerID.Size = new System.Drawing.Size(120, 95);
            this.lstCareerID.TabIndex = 14;
            this.lstCareerID.Visible = false;
            // 
            // lstProfile
            // 
            this.lstProfile.FullRowSelect = true;
            this.lstProfile.Location = new System.Drawing.Point(515, 109);
            this.lstProfile.Name = "lstProfile";
            this.lstProfile.Size = new System.Drawing.Size(198, 239);
            this.lstProfile.TabIndex = 15;
            this.lstProfile.UseCompatibleStateImageBehavior = false;
            // 
            // btnViewProfileList
            // 
            this.btnViewProfileList.Location = new System.Drawing.Point(515, 72);
            this.btnViewProfileList.Name = "btnViewProfileList";
            this.btnViewProfileList.Size = new System.Drawing.Size(195, 31);
            this.btnViewProfileList.TabIndex = 16;
            this.btnViewProfileList.Text = "&Xem hồ sơ bệnh án";
            this.btnViewProfileList.UseVisualStyleBackColor = true;
            this.btnViewProfileList.Click += new System.EventHandler(this.BtnViewProfileListClick);
            // 
            // btnShowProfile
            // 
            this.btnShowProfile.Location = new System.Drawing.Point(515, 354);
            this.btnShowProfile.Name = "btnShowProfile";
            this.btnShowProfile.Size = new System.Drawing.Size(195, 31);
            this.btnShowProfile.TabIndex = 17;
            this.btnShowProfile.Text = "Xem chi tiết &bệnh án";
            this.btnShowProfile.UseVisualStyleBackColor = true;
            this.btnShowProfile.Click += new System.EventHandler(this.BtnShowProfileClick);
            // 
            // frmSearchPatient
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 449);
            this.Controls.Add(this.btnShowProfile);
            this.Controls.Add(this.btnViewProfileList);
            this.Controls.Add(this.lstProfile);
            this.Controls.Add(this.lstCareerID);
            this.Controls.Add(this.lstPatientList);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpFilterData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearchPatient";
            this.Text = "Tim kiem thong tin benh nhan";            
            this.grpFilterData.ResumeLayout(false);
            this.grpFilterData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstPatientList)).EndInit();
            this.ResumeLayout(false);

        }
        private Button btnShowProfile;
        private Button btnViewProfileList;

        void frmSearchPatient_DoubleClick(object sender, System.EventArgs e)
        {
        	
        }
        private ListView lstProfile;
        private ListBox lstCareerID;
        private DataGridView lstPatientList;
        private ComboBox cboAge;
        private ComboBox cboCareer;
        private CheckBox chkAgeFilter;
        private CheckBox chkCareerFilter;
        private TextBox txtSearchKey;
        private ComboBox cboSearchIndex;

        #endregion

        private GroupBox grpFilterData;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Button btnOK;
        private Button btnFilter;
        
        void TxtSearchKeyTextChanged(object sender, System.EventArgs e)
        {
        	int i, n, j;
        	string strTmp;
        	if (txtSearchKey.TextLength==0) return;
			n = lstPatientList.Rows.Count;
			if (n==0) return;
			if (lstPatientList.SelectedRows!=null)
				if (lstPatientList.SelectedRows.Count>0)
					lstPatientList.SelectedRows[0].Selected =false;
			for (i=0; i<n; i++)
			{
				j = intSearchIndex[cboSearchIndex.SelectedIndex];
				strTmp = lstPatientList.Rows[i].Cells[j].Value.ToString();
				if (strTmp.Length<txtSearchKey.TextLength) {lstPatientList.Rows[i].Selected =false;continue;}
				if (string.Compare( strTmp.Substring(0, txtSearchKey.TextLength), txtSearchKey.Text, true)==0)
				{
					lstPatientList.Rows[i].Selected =true;
					return;
				}else lstPatientList.Rows[i].Selected =false;
			}
        }       
        
        void BtnOKClick(object sender, System.EventArgs e)
        {
        	int index;
        	string key;
        	if (!isSearching)
        	{
        		this.Close();
        		return;
        	}else
        	{
        		index = getSelected();
        		
        		if (index!=-1)
        		{
        			key = lstPatientList.Rows[index].HeaderCell.Value.ToString();
        			this.frm4Ref.LoadPatient(key);
        		}
        		this.Close();
        	}
        }
        private int getSelected()
        {
        	int i, n;
        	n = lstPatientList.Rows.Count;
			if (n==0) return -1;
			for (i=0; i<n; i++)
			{
				if (lstPatientList.Rows[i].Selected) return i;
			}
			return -1;
        }
        
        void BtnViewProfileListClick(object sender, System.EventArgs e)
        {
        	int index;
        	string key;        	
        	
        	index = getSelected();
    		if (index!=-1)
    		{
                key = lstPatientList.Rows[index].HeaderCell.Value.ToString();
    			//key = lstPatientList.Rows[index].Cells[0].Value.ToString();
    			this.LoadPatientProfile(key);
    		}	
        }
 
        
        void BtnShowProfileClick(object sender, System.EventArgs e)
        {
        	frmPatientRecord frmTmp;	
        	if (lstProfile.SelectedItems!=null)
        		if (lstProfile.SelectedItems.Count>0)
	        	{
        			frmTmp = new frmPatientRecord();
        			frmTmp.setReferenceConnectNLoadData(ref this.refConn, ref ms, ref this.reportImageTitle, this.reportTitle);
        			frmTmp.LoadProfile(lstProfile.SelectedItems[0].Text);
        			this.Dispose();
        			frmTmp.ShowDialog();        			
	        	}
        }

        private DateTimePicker dtDateIndex;
    }
}