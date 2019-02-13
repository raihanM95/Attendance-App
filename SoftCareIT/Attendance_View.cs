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
using System.IO;

namespace SoftCareIT
{
    public partial class Attendance_View : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SoftCareIT_Data.mdf;Integrated Security=True");

        public Attendance_View()
        {
            InitializeComponent();
        }

        private void Attendance_View_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Attendance";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewAttendance.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVASearch_Click(object sender, EventArgs e)
        {
            int i = 0;

            try
            {
                dataGridViewAttendance.Columns.Clear();
                dataGridViewAttendance.Refresh();

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Attendance WHERE OfficeID_No LIKE '%" + txtVASearch.Text + "%' OR Date LIKE '%" + txtVASearch.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                i = Convert.ToInt32(dt.Rows.Count.ToString());

                dataGridViewAttendance.DataSource = dt;
                
                con.Close();

                if (i == 0)
                {
                    labelSR.Text = "Sorry! No informations found \n      Please search again";
                }
                else
                {
                    labelSR.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtVASearch_KeyUp(object sender, KeyEventArgs e)
        {
            lblSearch.Text = "";

            int i = 0;

            try
            {
                dataGridViewAttendance.Columns.Clear();
                dataGridViewAttendance.Refresh();

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Attendance WHERE OfficeID_No LIKE '%" + txtVASearch.Text + "%' OR Date LIKE '%" + txtVASearch.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                i = Convert.ToInt32(dt.Rows.Count.ToString());

                dataGridViewAttendance.DataSource = dt;

                con.Close();

                if (i == 0)
                {
                    labelSR.Text = "Sorry! No informations found \n      Please search again";
                }
                else
                {
                    labelSR.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
