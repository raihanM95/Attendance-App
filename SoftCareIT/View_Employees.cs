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
    public partial class View_Employees : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SoftCareIT_Data.mdf;Integrated Security=True");
        //string imgLocation = "";

        public View_Employees()
        {
            InitializeComponent();
        }

        private void View_Employees_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Employees_Info";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewEmployees_Info.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVESearch_Click(object sender, EventArgs e)
        {
            int i = 0;

            try
            {
                dataGridViewEmployees_Info.Columns.Clear();
                dataGridViewEmployees_Info.Refresh();

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Employees_Info WHERE Name LIKE '%" + txtVESearch.Text + "%' OR Fathers_Name LIKE '%" + txtVESearch.Text + "%' OR Mothers_Name LIKE '%" + txtVESearch.Text + "%' OR Date_of_Birth LIKE '%" + txtVESearch.Text + "%' OR Gender LIKE '%" + txtVESearch.Text + "%' OR Department LIKE '%" + txtVESearch.Text + "%' OR Designation LIKE '%" + txtVESearch.Text + "%' OR DID LIKE '%" + txtVESearch.Text + "%' OR Address LIKE '%" + txtVESearch.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                i = Convert.ToInt32(dt.Rows.Count.ToString());

                dataGridViewEmployees_Info.DataSource = dt;
                /*
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    byte[] images = ((byte[])dr[11]);
                    if (images == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream mrys = new MemoryStream(images);
                        pictureBox1.Image = Image.FromStream(mrys);
                    }
                }
                else
                {
                    //MessageBox.Show("false");
                }
                */
                con.Close();

                if(i == 0)
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

        private void txtVESearch_KeyUp(object sender, KeyEventArgs e)
        {
            lblSearch.Text = "";

            int i = 0;

            try
            {
                dataGridViewEmployees_Info.Columns.Clear();
                dataGridViewEmployees_Info.Refresh();

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Employees_Info WHERE Name LIKE '%" + txtVESearch.Text + "%' OR Fathers_Name LIKE '%" + txtVESearch.Text + "%' OR Mothers_Name LIKE '%" + txtVESearch.Text + "%' OR Date_of_Birth LIKE '%" + txtVESearch.Text + "%' OR Gender LIKE '%" + txtVESearch.Text + "%' OR Department LIKE '%" + txtVESearch.Text + "%' OR Designation LIKE '%" + txtVESearch.Text + "%' OR DID LIKE '%" + txtVESearch.Text + "%' OR Address LIKE '%" + txtVESearch.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                i = Convert.ToInt32(dt.Rows.Count.ToString());

                dataGridViewEmployees_Info.DataSource = dt;
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

        private void dataGridViewEmployees_Info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("If you Update? click Yes \nIf Sent Email? click No", "Update/Sent Email", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                try
                {
                    int i = Convert.ToInt32(dataGridViewEmployees_Info.SelectedCells[0].Value.ToString());
                    string Name = dataGridViewEmployees_Info.SelectedCells[1].Value.ToString();
                    string FName = dataGridViewEmployees_Info.SelectedCells[2].Value.ToString();
                    string MName = dataGridViewEmployees_Info.SelectedCells[3].Value.ToString();
                    
                    string Gender = dataGridViewEmployees_Info.SelectedCells[5].Value.ToString();
                    string Department = dataGridViewEmployees_Info.SelectedCells[6].Value.ToString();
                    string Designation = dataGridViewEmployees_Info.SelectedCells[7].Value.ToString();
                    string PStatus = dataGridViewEmployees_Info.SelectedCells[9].Value.ToString();
                    string CStatus = dataGridViewEmployees_Info.SelectedCells[10].Value.ToString();
                    string PNo = dataGridViewEmployees_Info.SelectedCells[11].Value.ToString();
                    string Email = dataGridViewEmployees_Info.SelectedCells[12].Value.ToString();
                    string Address = dataGridViewEmployees_Info.SelectedCells[13].Value.ToString();

                    Update_Employees ue = new Update_Employees();
                    ue.ID = i;
                    ue.eName = Name;
                    ue.FName = FName;
                    ue.MName = MName;
                    ue.Gender = Gender;
                    ue.Department = Department;
                    ue.Designation = Designation;
                    ue.PStatus = PStatus;
                    ue.CStatus = CStatus;
                    ue.PNo = PNo;
                    ue.Email = Email;
                    ue.Address = Address;

                    ue.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                string email = dataGridViewEmployees_Info.SelectedCells[12].Value.ToString();
                
                this.Hide();
                Sent_Email sm = new Sent_Email();
                sm.To = email;
                sm.Show();
            }           
        }
    }
}
