namespace SoftCareIT
{
    partial class Sent_Email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sent_Email));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSEFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSEPassword = new System.Windows.Forms.TextBox();
            this.txtSETo = new System.Windows.Forms.TextBox();
            this.btnSEmail = new System.Windows.Forms.Button();
            this.txtSESubject = new System.Windows.Forms.TextBox();
            this.txtSEBody = new System.Windows.Forms.TextBox();
            this.btnSECancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Email:";
            // 
            // txtSEFrom
            // 
            this.txtSEFrom.Location = new System.Drawing.Point(125, 139);
            this.txtSEFrom.Name = "txtSEFrom";
            this.txtSEFrom.Size = new System.Drawing.Size(176, 20);
            this.txtSEFrom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Subject:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Body:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(184, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtSEPassword
            // 
            this.txtSEPassword.Location = new System.Drawing.Point(400, 139);
            this.txtSEPassword.Name = "txtSEPassword";
            this.txtSEPassword.PasswordChar = '*';
            this.txtSEPassword.Size = new System.Drawing.Size(100, 20);
            this.txtSEPassword.TabIndex = 2;
            // 
            // txtSETo
            // 
            this.txtSETo.Location = new System.Drawing.Point(125, 171);
            this.txtSETo.Name = "txtSETo";
            this.txtSETo.Size = new System.Drawing.Size(176, 20);
            this.txtSETo.TabIndex = 3;
            // 
            // btnSEmail
            // 
            this.btnSEmail.Location = new System.Drawing.Point(467, 305);
            this.btnSEmail.Name = "btnSEmail";
            this.btnSEmail.Size = new System.Drawing.Size(75, 23);
            this.btnSEmail.TabIndex = 6;
            this.btnSEmail.Text = "Send";
            this.btnSEmail.UseVisualStyleBackColor = true;
            this.btnSEmail.Click += new System.EventHandler(this.btnSEmail_Click);
            // 
            // txtSESubject
            // 
            this.txtSESubject.Location = new System.Drawing.Point(125, 203);
            this.txtSESubject.Name = "txtSESubject";
            this.txtSESubject.Size = new System.Drawing.Size(176, 20);
            this.txtSESubject.TabIndex = 4;
            // 
            // txtSEBody
            // 
            this.txtSEBody.Location = new System.Drawing.Point(125, 235);
            this.txtSEBody.Multiline = true;
            this.txtSEBody.Name = "txtSEBody";
            this.txtSEBody.Size = new System.Drawing.Size(269, 44);
            this.txtSEBody.TabIndex = 5;
            // 
            // btnSECancel
            // 
            this.btnSECancel.Location = new System.Drawing.Point(377, 305);
            this.btnSECancel.Name = "btnSECancel";
            this.btnSECancel.Size = new System.Drawing.Size(75, 23);
            this.btnSECancel.TabIndex = 7;
            this.btnSECancel.Text = "Cancel";
            this.btnSECancel.UseVisualStyleBackColor = true;
            this.btnSECancel.Click += new System.EventHandler(this.btnSECancel_Click);
            // 
            // Sent_Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(565, 340);
            this.Controls.Add(this.btnSECancel);
            this.Controls.Add(this.txtSEBody);
            this.Controls.Add(this.txtSESubject);
            this.Controls.Add(this.btnSEmail);
            this.Controls.Add(this.txtSETo);
            this.Controls.Add(this.txtSEPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSEFrom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sent_Email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sent Email";
            this.Load += new System.EventHandler(this.Sent_Email_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSEFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSEPassword;
        private System.Windows.Forms.TextBox txtSETo;
        private System.Windows.Forms.Button btnSEmail;
        private System.Windows.Forms.TextBox txtSESubject;
        private System.Windows.Forms.TextBox txtSEBody;
        private System.Windows.Forms.Button btnSECancel;
    }
}