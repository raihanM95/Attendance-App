namespace SoftCareIT
{
    partial class Add_Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Employees));
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAEName = new System.Windows.Forms.TextBox();
            this.dateTimePickerAEB = new System.Windows.Forms.DateTimePicker();
            this.cmbAEGender = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBoxAE = new System.Windows.Forms.PictureBox();
            this.txtAEFName = new System.Windows.Forms.TextBox();
            this.txtAEMName = new System.Windows.Forms.TextBox();
            this.txtAEPNo = new System.Windows.Forms.TextBox();
            this.txtAEEmail = new System.Windows.Forms.TextBox();
            this.txtAEAddress = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAEDepartment = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbAEDesignation = new System.Windows.Forms.ComboBox();
            this.txtAEPStatus = new System.Windows.Forms.TextBox();
            this.txtAECStatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbAEID = new System.Windows.Forms.ComboBox();
            this.labelMSF = new System.Windows.Forms.Label();
            this.labelMSS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAE)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(584, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 22);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Father\'s Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mother\'s Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date of Birth: *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Gender: *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Department: *";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(254, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Email:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(71, 344);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Address: *";
            // 
            // txtAEName
            // 
            this.txtAEName.Location = new System.Drawing.Point(128, 23);
            this.txtAEName.Name = "txtAEName";
            this.txtAEName.Size = new System.Drawing.Size(291, 20);
            this.txtAEName.TabIndex = 1;
            this.txtAEName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAEName_KeyUp);
            // 
            // dateTimePickerAEB
            // 
            this.dateTimePickerAEB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAEB.Location = new System.Drawing.Point(128, 129);
            this.dateTimePickerAEB.Name = "dateTimePickerAEB";
            this.dateTimePickerAEB.Size = new System.Drawing.Size(147, 20);
            this.dateTimePickerAEB.TabIndex = 5;
            this.dateTimePickerAEB.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // cmbAEGender
            // 
            this.cmbAEGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAEGender.FormattingEnabled = true;
            this.cmbAEGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbAEGender.Location = new System.Drawing.Point(354, 128);
            this.cmbAEGender.Name = "cmbAEGender";
            this.cmbAEGender.Size = new System.Drawing.Size(65, 21);
            this.cmbAEGender.TabIndex = 6;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(510, 196);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 22);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBoxAE
            // 
            this.pictureBoxAE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAE.Location = new System.Drawing.Point(468, 42);
            this.pictureBoxAE.Name = "pictureBoxAE";
            this.pictureBoxAE.Size = new System.Drawing.Size(159, 147);
            this.pictureBoxAE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAE.TabIndex = 16;
            this.pictureBoxAE.TabStop = false;
            // 
            // txtAEFName
            // 
            this.txtAEFName.Location = new System.Drawing.Point(128, 58);
            this.txtAEFName.Name = "txtAEFName";
            this.txtAEFName.Size = new System.Drawing.Size(291, 20);
            this.txtAEFName.TabIndex = 3;
            // 
            // txtAEMName
            // 
            this.txtAEMName.Location = new System.Drawing.Point(128, 93);
            this.txtAEMName.Name = "txtAEMName";
            this.txtAEMName.Size = new System.Drawing.Size(291, 20);
            this.txtAEMName.TabIndex = 4;
            // 
            // txtAEPNo
            // 
            this.txtAEPNo.Location = new System.Drawing.Point(128, 306);
            this.txtAEPNo.Name = "txtAEPNo";
            this.txtAEPNo.Size = new System.Drawing.Size(119, 20);
            this.txtAEPNo.TabIndex = 12;
            // 
            // txtAEEmail
            // 
            this.txtAEEmail.Location = new System.Drawing.Point(291, 306);
            this.txtAEEmail.Name = "txtAEEmail";
            this.txtAEEmail.Size = new System.Drawing.Size(128, 20);
            this.txtAEEmail.TabIndex = 13;
            // 
            // txtAEAddress
            // 
            this.txtAEAddress.Location = new System.Drawing.Point(128, 341);
            this.txtAEAddress.Multiline = true;
            this.txtAEAddress.Name = "txtAEAddress";
            this.txtAEAddress.Size = new System.Drawing.Size(291, 33);
            this.txtAEAddress.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Phone No: *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Designation: *";
            // 
            // cmbAEDepartment
            // 
            this.cmbAEDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAEDepartment.FormattingEnabled = true;
            this.cmbAEDepartment.Items.AddRange(new object[] {
            "IT Service",
            "IT Training",
            "Shop Care",
            "Fruit Care"});
            this.cmbAEDepartment.Location = new System.Drawing.Point(128, 164);
            this.cmbAEDepartment.Name = "cmbAEDepartment";
            this.cmbAEDepartment.Size = new System.Drawing.Size(100, 21);
            this.cmbAEDepartment.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Previous Status:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Current Status:";
            // 
            // cmbAEDesignation
            // 
            this.cmbAEDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAEDesignation.FormattingEnabled = true;
            this.cmbAEDesignation.Items.AddRange(new object[] {
            "CEO",
            "MD",
            "GM",
            "DGM",
            "Developer"});
            this.cmbAEDesignation.Location = new System.Drawing.Point(319, 164);
            this.cmbAEDesignation.Name = "cmbAEDesignation";
            this.cmbAEDesignation.Size = new System.Drawing.Size(100, 21);
            this.cmbAEDesignation.TabIndex = 8;
            // 
            // txtAEPStatus
            // 
            this.txtAEPStatus.Location = new System.Drawing.Point(128, 236);
            this.txtAEPStatus.Name = "txtAEPStatus";
            this.txtAEPStatus.Size = new System.Drawing.Size(291, 20);
            this.txtAEPStatus.TabIndex = 10;
            // 
            // txtAECStatus
            // 
            this.txtAECStatus.Location = new System.Drawing.Point(128, 271);
            this.txtAECStatus.Name = "txtAECStatus";
            this.txtAECStatus.Size = new System.Drawing.Size(291, 20);
            this.txtAECStatus.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID: *";
            // 
            // cmbAEID
            // 
            this.cmbAEID.FormattingEnabled = true;
            this.cmbAEID.Location = new System.Drawing.Point(272, 200);
            this.cmbAEID.Name = "cmbAEID";
            this.cmbAEID.Size = new System.Drawing.Size(147, 21);
            this.cmbAEID.TabIndex = 9;
            this.cmbAEID.Text = "SC-";
            // 
            // labelMSF
            // 
            this.labelMSF.AutoSize = true;
            this.labelMSF.ForeColor = System.Drawing.Color.Red;
            this.labelMSF.Location = new System.Drawing.Point(501, 282);
            this.labelMSF.Name = "labelMSF";
            this.labelMSF.Size = new System.Drawing.Size(0, 13);
            this.labelMSF.TabIndex = 17;
            // 
            // labelMSS
            // 
            this.labelMSS.AutoSize = true;
            this.labelMSS.ForeColor = System.Drawing.Color.Green;
            this.labelMSS.Location = new System.Drawing.Point(501, 264);
            this.labelMSS.Name = "labelMSS";
            this.labelMSS.Size = new System.Drawing.Size(0, 13);
            this.labelMSS.TabIndex = 18;
            // 
            // Add_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(671, 405);
            this.Controls.Add(this.labelMSS);
            this.Controls.Add(this.labelMSF);
            this.Controls.Add(this.cmbAEID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAECStatus);
            this.Controls.Add(this.txtAEPStatus);
            this.Controls.Add(this.cmbAEDesignation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbAEDepartment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAEAddress);
            this.Controls.Add(this.txtAEEmail);
            this.Controls.Add(this.txtAEPNo);
            this.Controls.Add(this.txtAEMName);
            this.Controls.Add(this.txtAEFName);
            this.Controls.Add(this.pictureBoxAE);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.cmbAEGender);
            this.Controls.Add(this.dateTimePickerAEB);
            this.Controls.Add(this.txtAEName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Add_Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employees";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAEName;
        private System.Windows.Forms.DateTimePicker dateTimePickerAEB;
        private System.Windows.Forms.ComboBox cmbAEGender;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBoxAE;
        private System.Windows.Forms.TextBox txtAEFName;
        private System.Windows.Forms.TextBox txtAEMName;
        private System.Windows.Forms.TextBox txtAEPNo;
        private System.Windows.Forms.TextBox txtAEEmail;
        private System.Windows.Forms.TextBox txtAEAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAEDepartment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbAEDesignation;
        private System.Windows.Forms.TextBox txtAEPStatus;
        private System.Windows.Forms.TextBox txtAECStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbAEID;
        private System.Windows.Forms.Label labelMSF;
        private System.Windows.Forms.Label labelMSS;
    }
}