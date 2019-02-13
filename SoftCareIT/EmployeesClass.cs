using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SoftCareIT
{
    public class Employees : EProperty
    {
        public string imageLocation;
        public string Message = "";

        public Employees(string N, string FN, string MN, string G, string Dpt, string Dgn, string PS, string CS, string PNo, string E, string Ads)
        {
            Name = N;
            FatherName = FN;
            MotherName = MN;
            Gender = G;
            Department = Dpt;
            Designation = Dgn;
            PStatus = PS;
            CStatus = CS;
            PhoneNo = PNo;
            Email = E;
            Address = Ads;
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SoftCareIT_Data.mdf;Integrated Security=True");

        public void AddEmployees()
        {
            if (Name != "" && BirthDate != "" && Gender != "" && Department != "" && Designation != "" && Id != "" && PhoneNo != "" && Address != "")
            {
                if (imageLocation != "")
                {
                    try
                    {
                        byte[] images = null;
                        FileStream strm = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(strm);
                        images = br.ReadBytes((int)strm.Length);

                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO Employees_Info VALUES('" + Name + "','" + FatherName + "','" + MotherName + "','" + BirthDate + "','" + Gender + "','" + Department + "','" + Designation + "','" + Id + "','" + PStatus + "','" + CStatus + "','" + PhoneNo + "','" + Email + "','" + Address + "', @images)";
                        cmd.Parameters.Add(new SqlParameter("@images", images));
                        cmd.ExecuteNonQuery();
                        con.Close();

                        Message = "Data save successfully";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO Employees_Info (Name, Fathers_Name, Mothers_Name, Date_of_Birth, Gender, Department, Designation, DID, Previous_Status, Current_Status, PHone_No, Email, Address) VALUES ('" + Name + "','" + FatherName + "','" + MotherName + "','" + BirthDate + "','" + Gender + "','" + Department + "','" + Designation + "','" + Id + "','" + PStatus + "','" + CStatus + "','" + PhoneNo + "','" + Email + "','" + Address + "')";
                        cmd.ExecuteNonQuery();
                        con.Close();

                        Message = "Data save successfully";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                Message = "Please submit all info";
            }
        }
        
        public void ViewEmployees()
        {
            
        }

        public void UpdateEmployeesInfo(int Id)
        {
            if (Name != "" && Gender != "" && Department != "" && Designation != "" && PhoneNo != "" && Address != "")
            {
                if (imageLocation != "")
                {
                    try
                    {
                        byte[] images = null;
                        FileStream strm = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(strm);
                        images = br.ReadBytes((int)strm.Length);

                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "UPDATE Employees_Info SET Name = '" + Name + "', Fathers_Name = '" + FatherName + "', Mothers_Name = '" + MotherName + "', Gender = '" + Gender + "', Department = '" + Department + "', Designation = '" + Designation + "', Previous_Status = '" + PStatus + "', Current_Status = '" + CStatus + "', Phone_No = '" + PhoneNo + "', Email = '" + Email + "', Address = '" + Address + "', Image = @images WHERE Id = " + Id + "";
                        cmd.Parameters.Add(new SqlParameter("@images", images));
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Data update successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "UPDATE Employees_Info SET Name = '" + Name + "', Fathers_Name = '" + FatherName + "', Mothers_Name = '" + MotherName + "', Gender = '" + Gender + "', Department = '" + Department + "', Designation = '" + Designation + "', Previous_Status = '" + PStatus + "', Current_Status = '" + CStatus + "', Phone_No = '" + PhoneNo + "', Email = '" + Email + "', Address = '" + Address + "' WHERE Id = " + Id + "";
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("Data update successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                Message = "Please submit all info";
            }
        }

        public void SearchEmployeesInfo()
        {

        }
    }
}
