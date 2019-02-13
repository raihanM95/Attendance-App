using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftCareIT
{
    public partial class Password_Recovery : Form
    {
        public Password_Recovery()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            LogIns liclass = new LogIns();
            liclass.RecoveryPassword(txtRVEmail.Text, txtRVNPass.Text, txtRVRPass.Text);
            if(liclass.Message == "")
            {
                this.Hide();
                LogIn li = new LogIn();
                li.Show();
            }
            else
            {
                labelM.Text = liclass.Message;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn li = new LogIn();
            li.Show();
        }
    }
}
