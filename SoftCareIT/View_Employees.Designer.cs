namespace SoftCareIT
{
    partial class View_Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Employees));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtVESearch = new System.Windows.Forms.TextBox();
            this.btnVESearch = new System.Windows.Forms.Button();
            this.dataGridViewEmployees_Info = new System.Windows.Forms.DataGridView();
            this.labelSR = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees_Info)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtVESearch);
            this.panel1.Controls.Add(this.btnVESearch);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 26);
            this.panel1.TabIndex = 0;
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
            // txtVESearch
            // 
            this.txtVESearch.Location = new System.Drawing.Point(32, 3);
            this.txtVESearch.Name = "txtVESearch";
            this.txtVESearch.Size = new System.Drawing.Size(266, 20);
            this.txtVESearch.TabIndex = 0;
            this.txtVESearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtVESearch_KeyUp);
            // 
            // btnVESearch
            // 
            this.btnVESearch.Location = new System.Drawing.Point(304, 1);
            this.btnVESearch.Name = "btnVESearch";
            this.btnVESearch.Size = new System.Drawing.Size(75, 23);
            this.btnVESearch.TabIndex = 1;
            this.btnVESearch.Text = "Search";
            this.btnVESearch.UseVisualStyleBackColor = true;
            this.btnVESearch.Click += new System.EventHandler(this.btnVESearch_Click);
            // 
            // dataGridViewEmployees_Info
            // 
            this.dataGridViewEmployees_Info.AllowUserToOrderColumns = true;
            this.dataGridViewEmployees_Info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewEmployees_Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewEmployees_Info.Location = new System.Drawing.Point(12, 45);
            this.dataGridViewEmployees_Info.Name = "dataGridViewEmployees_Info";
            this.dataGridViewEmployees_Info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployees_Info.Size = new System.Drawing.Size(799, 244);
            this.dataGridViewEmployees_Info.TabIndex = 1;
            this.dataGridViewEmployees_Info.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_Info_CellClick);
            // 
            // labelSR
            // 
            this.labelSR.AutoSize = true;
            this.labelSR.ForeColor = System.Drawing.Color.Red;
            this.labelSR.Location = new System.Drawing.Point(542, 12);
            this.labelSR.Name = "labelSR";
            this.labelSR.Size = new System.Drawing.Size(0, 13);
            this.labelSR.TabIndex = 2;
            // 
            // View_Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 301);
            this.Controls.Add(this.labelSR);
            this.Controls.Add(this.dataGridViewEmployees_Info);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "View_Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Employees";
            this.Load += new System.EventHandler(this.View_Employees_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees_Info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVESearch;
        private System.Windows.Forms.TextBox txtVESearch;
        private System.Windows.Forms.DataGridView dataGridViewEmployees_Info;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelSR;
        private System.Windows.Forms.Label lblSearch;
    }
}