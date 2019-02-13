using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace SoftCareIT
{
    public partial class Sent_Email : Form
    {
        public string To;
        
        public Sent_Email()
        {
            InitializeComponent();
        }
        
        private void Sent_Email_Load(object sender, EventArgs e)
        {
            txtSETo.Text = To;
        }

        private void btnSEmail_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                MailMessage message = new MailMessage();
                message.From = new MailAddress(txtSEFrom.Text);
                message.To.Add(txtSETo.Text);
                message.Body = txtSEBody.Text;
                message.Subject = txtSESubject.Text;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;

                /*if (txtattachment.Text != "")
                {
                    message.Attachments.Add(new Attachment(txtattachment.Text));
                }*/

                client.Credentials = new System.Net.NetworkCredential(txtSEFrom.Text, txtSEPassword.Text);
                client.Send(message);
                message = null;
                MessageBox.Show("Successfully send your email");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSECancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
