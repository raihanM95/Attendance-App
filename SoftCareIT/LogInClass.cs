using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SoftCareIT
{
    class LogIns
    {
        public string Message = "";

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SoftCareIT_Data.mdf;Integrated Security=True");
        int count = 0;

        public void Registration(string Name, string Email, string Username, string Password, string RPassword)
        {
            try
            {
                if (Email != "" && Username != "" && Password != "" && RPassword != "")
                {
                    if (Password == RPassword)
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO LogIn VALUES ('" + Name + "','" + Email + "','" + Username + "','" + RPassword + "')";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("You have successfully create an account");
                    }
                    else
                    {
                        Message = "Please input same password";
                    }
                }
                else
                {
                    Message = "Sorry! you cann't entry null information";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int LogIn(string Username, string Password)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM LogIn WHERE Username = '" + Username + "' and Password = '" + Password + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                con.Close();

                if (count == 0)
                {
                    Message = "Username or password doesn't match";
                }
                else
                {
                    //MessageBox.Show("Username and password match");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return count;
        }

        public void RecoveryPassword(string Email, string Password, string RPassword)
        {
            try
            {
                if (Password != "")
                {
                    if (Password == RPassword)
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "UPDATE LogIn SET Password = '" + RPassword + "' WHERE Email = '" + Email + "'";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("You successfully recovery your account");
                    }
                    else
                    {
                        Message = "Please input same password";
                    }
                }
                else
                {
                    Message = "Sorry! you cann't entry null password";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ChangePassword(string OldPassword, string NewPassword, string RPassword)
        {
            try
            {
                if (NewPassword != "")
                {
                    if (NewPassword == RPassword)
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        //cmd.CommandText = "DELETE LogIn WHERE Password = '" + OldPassword + "'";
                        cmd.CommandText = "UPDATE LogIn SET Password = '" + RPassword + "' WHERE Password = '" + OldPassword + "'";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("You have successfully change password");
                    }
                    else
                    {
                        Message = "Please input same password";
                    }
                }
                else
                {
                    Message = "Sorry! you cann't entry null password";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
