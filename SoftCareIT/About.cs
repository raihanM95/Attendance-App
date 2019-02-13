using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SoftCareIT
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBoxLFB_Click(object sender, EventArgs e)
        {
            Process.Start("www.facebook.com/raihan.Mahmud95");
        }

        private void pictureBoxLIN_Click(object sender, EventArgs e)
        {
            Process.Start("www.linkedin.com/in/raihanM95");
        }

        private void pictureBoxLTR_Click(object sender, EventArgs e)
        {
            Process.Start("www.twitter.com/raihanM95");
        }

        private void pictureBoxLGH_Click(object sender, EventArgs e)
        {
            Process.Start("www.github.com/raihanM95");
        }
    }
}
