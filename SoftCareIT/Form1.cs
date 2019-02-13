using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SoftCareIT
{
    public partial class LogIn : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SoftCareIT_Data.mdf;Integrated Security=True");

        public LogIn()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_LogIn rli = new Register_LogIn();
            rli.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogIns liclass = new LogIns();

            if(liclass.LogIn(txtUser.Text, txtPass.Text) != 0)
            {
                this.Hide();
                MDI_Main mm = new MDI_Main();
                mm.Show();
            }
            else
            {
                labelM.Text = liclass.Message;
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void linklblForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Password_Recovery pr = new Password_Recovery();
            pr.Show();
        }

        private void pictureBoxEX_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
