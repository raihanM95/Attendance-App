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
    class Attendance
    {
        public string ID_No;
        public string Date;
        public string Time;

        public string Message = "";

        public Attendance(string Id, string D, string T)
        {
            ID_No = Id;
            Date = D;
            Time = T;
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SoftCareIT_Data.mdf;Integrated Security=True");

        public void Entry()
        {
            if (ID_No != "" && Date != "" && Time != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO Attendance (OfficeID_No, Date, Entry_Time) VALUES ('" + ID_No + "','" + Date + "','" + Time + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Message = "Please submit all info";
            }
        }

        public void Exit()
        {
            if(ID_No != "" && Date != "" && Time != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Attendance SET Exit_Time = '" + Time + "' WHERE OfficeID_No = '" + ID_No + "' AND Date = '" + Date + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Message = "Please submit all info";
            }
        }
    }
}
