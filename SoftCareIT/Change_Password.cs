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
    public partial class Change_Password : Form
    {
        public Change_Password()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            LogIns liclass = new LogIns();
            liclass.ChangePassword(txtCOPass.Text, txtCNPass.Text, txtCRPass.Text);
            if(liclass.Message == "")
            {
                this.Hide();
            }
            else
            {
                labelM.Text = liclass.Message;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
