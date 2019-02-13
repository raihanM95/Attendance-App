namespace SoftCareIT
{
    partial class MDI_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_Main));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.EmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmployeesToolStripMenuItem,
            this.attendanceToolStripMenuItem,
            this.emailToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(709, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // EmployeesToolStripMenuItem
            // 
            this.EmployeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewEmployeesToolStripMenuItem,
            this.viewEmployeesToolStripMenuItem});
            this.EmployeesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EmployeesToolStripMenuItem.Image")));
            this.EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem";
            this.EmployeesToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.EmployeesToolStripMenuItem.Text = "Employees";
            // 
            // addNewEmployeesToolStripMenuItem
            // 
            this.addNewEmployeesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewEmployeesToolStripMenuItem.Image")));
            this.addNewEmployeesToolStripMenuItem.Name = "addNewEmployeesToolStripMenuItem";
            this.addNewEmployeesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.addNewEmployeesToolStripMenuItem.Text = "Add New Employees";
            this.addNewEmployeesToolStripMenuItem.Click += new System.EventHandler(this.addNewEmployeesToolStripMenuItem_Click);
            // 
            // viewEmployeesToolStripMenuItem
            // 
            this.viewEmployeesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewEmployeesToolStripMenuItem.Image")));
            this.viewEmployeesToolStripMenuItem.Name = "viewEmployeesToolStripMenuItem";
            this.viewEmployeesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.viewEmployeesToolStripMenuItem.Text = "View Employees";
            this.viewEmployeesToolStripMenuItem.Click += new System.EventHandler(this.viewEmployeesToolStripMenuItem_Click);
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAttendanceToolStripMenuItem,
            this.viewAttendanceToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.attendanceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("attendanceToolStripMenuItem.Image")));
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            // 
            // addAttendanceToolStripMenuItem
            // 
            this.addAttendanceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addAttendanceToolStripMenuItem.Image")));
            this.addAttendanceToolStripMenuItem.Name = "addAttendanceToolStripMenuItem";
            this.addAttendanceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addAttendanceToolStripMenuItem.Text = "Entry";
            this.addAttendanceToolStripMenuItem.Click += new System.EventHandler(this.addAttendanceToolStripMenuItem_Click);
            // 
            // viewAttendanceToolStripMenuItem
            // 
            this.viewAttendanceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewAttendanceToolStripMenuItem.Image")));
            this.viewAttendanceToolStripMenuItem.Name = "viewAttendanceToolStripMenuItem";
            this.viewAttendanceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewAttendanceToolStripMenuItem.Text = "Exit";
            this.viewAttendanceToolStripMenuItem.Click += new System.EventHandler(this.viewAttendanceToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewToolStripMenuItem.Image")));
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("emailToolStripMenuItem.Image")));
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.emailToolStripMenuItem.Text = "Email";
            this.emailToolStripMenuItem.Click += new System.EventHandler(this.emailToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem});
            this.settingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingToolStripMenuItem.Image")));
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordToolStripMenuItem.Image")));
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(709, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(103, 17);
            this.toolStripStatusLabel.Text = "SoftCareIT © 2018";
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.clock.Location = new System.Drawing.Point(633, 0);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(80, 24);
            this.clock.TabIndex = 7;
            this.clock.Text = "00:00:00";
            this.clock.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(709, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MDI_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDI_Main";
            this.Text = "Main Manu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem EmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}



