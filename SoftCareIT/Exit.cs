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
    public partial class Exit : Form
    {
        public string Date;
        public string Time;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SoftCareIT_Data.mdf;Integrated Security=True");

        public Exit()
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

                foreach (DataRow dr in dt.Rows)
                {
                    cmbEXIDNo.Items.Add(dr["DID"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Date = cmbEXDDay.Text + "-" + cmbEXDMonth.Text + "-" + cmbEXDYear.Text;
            Time = cmbEXTHour.Text + ":" + cmbEXTMin.Text + cmbEXTH.Text;

            Attendance ex = new Attendance(cmbEXIDNo.Text, Date, Time);
            ex.Exit();
            if (ex.Message == "")
            {
                this.Hide();
            }
            else
            {
                labelM.Text = ex.Message;
            }
        }
    }
}
