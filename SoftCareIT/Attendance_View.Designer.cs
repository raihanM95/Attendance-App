namespace SoftCareIT
{
    partial class Attendance_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance_View));
            this.dataGridViewAttendance = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtVASearch = new System.Windows.Forms.TextBox();
            this.btnVASearch = new System.Windows.Forms.Button();
            this.labelSR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAttendance
            // 
            this.dataGridViewAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewAttendance.Location = new System.Drawing.Point(12, 44);
            this.dataGridViewAttendance.Name = "dataGridViewAttendance";
            this.dataGridViewAttendance.Size = new System.Drawing.Size(538, 245);
            this.dataGridViewAttendance.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtVASearch);
            this.panel1.Controls.Add(this.btnVASearch);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 26);
            this.panel1.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(36, 6);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(50, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search...";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // txtVASearch
            // 
            this.txtVASearch.Location = new System.Drawing.Point(32, 3);
            this.txtVASearch.Name = "txtVASearch";
            this.txtVASearch.Size = new System.Drawing.Size(266, 20);
            this.txtVASearch.TabIndex = 0;
            this.txtVASearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtVASearch_KeyUp);
            // 
            // btnVASearch
            // 
            this.btnVASearch.Location = new System.Drawing.Point(304, 1);
            this.btnVASearch.Name = "btnVASearch";
            this.btnVASearch.Size = new System.Drawing.Size(75, 23);
            this.btnVASearch.TabIndex = 1;
            this.btnVASearch.Text = "Search";
            this.btnVASearch.UseVisualStyleBackColor = true;
            this.btnVASearch.Click += new System.EventHandler(this.btnVASearch_Click);
            // 
            // labelSR
            // 
            this.labelSR.AutoSize = true;
            this.labelSR.ForeColor = System.Drawing.Color.Red;
            this.labelSR.Location = new System.Drawing.Point(415, 12);
            this.labelSR.Name = "labelSR";
            this.labelSR.Size = new System.Drawing.Size(0, 13);
            this.labelSR.TabIndex = 3;
            // 
            // Attendance_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 301);
            this.Controls.Add(this.labelSR);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewAttendance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Attendance_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View";
            this.Load += new System.EventHandler(this.Attendance_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendance)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAttendance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtVASearch;
        private System.Windows.Forms.Button btnVASearch;
        private System.Windows.Forms.Label labelSR;
    }
}