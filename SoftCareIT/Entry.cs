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
    public partial class Entry : Form
    {
        public string Date;
        public string Time;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SoftCareIT_Data.mdf;Integrated Security=True");

        public Entry()
        {
            InitializeComponent();
            IDLoad();
        }
        
        void IDLoad()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT DID FROM Employees_Info";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach(DataRow dr in dt.Rows)
                {
                    cmbEIDNo.Items.Add(dr["DID"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnEntry_Click(object sender, EventArgs e)
        {
            Date = cmbEDDay.Text + "-" + cmbEDMonth.Text + "-" + cmbEDYear.Text;
            Time = cmbETHour.Text + ":" + cmbETMin.Text + cmbETH.Text;

            Attendance an = new Attendance(cmbEIDNo.Text, Date, Time);
            an.Entry();
            if (an.Message == "")
            {
                this.Hide();
            }
            else
            {
                labelM.Text = an.Message;
            }
        }
    }
}
