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
    public partial class Update_Employees : Form
    {
        public int ID;
        public string eName;
        public string FName;
        public string MName;   
        public string Gender;
        public string Department;
        public string Designation;
        public string PStatus;
        public string CStatus;
        public string PNo;
        public string Email;
        public string Address;
        string imgLocation = "";

        public Update_Employees()
        {
            InitializeComponent();
        }

        private void Update_Employees_Load(object sender, EventArgs e)
        {
            txtUEName.Text = eName;
            txtUEFName.Text = FName;
            txtUEMName.Text = MName;
            cmbUEGender.Text = Gender;
            cmbUEDepartment.Text = Department;
            cmbUEDesignation.Text = Designation;
            txtUEPStatus.Text = PStatus;
            txtUECStatus.Text = CStatus;
            txtUEPNo.Text = PNo;
            txtUEEmail.Text = Email;
            txtUEAddress.Text = Address;
        }

        private void btnUPBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBoxUE.ImageLocation = imgLocation;
            }
            else
            {
                imgLocation = pictureBoxUE.ImageLocation;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Employees em = new Employees(txtUEName.Text, txtUEFName.Text, txtUEMName.Text, cmbUEGender.Text, cmbUEDepartment.Text, cmbUEDesignation.Text, txtUEPStatus.Text, txtUECStatus.Text, txtUEPNo.Text, txtUEEmail.Text, txtUEAddress.Text);
            em.imageLocation = imgLocation;
            try
            {
                em.UpdateEmployeesInfo(ID);
                if(em.Message == "")
                {
                    View_Employees ve = new View_Employees();
                    this.Hide();
                    ve.Show();
                }
                else
                {
                    labelUMS.Text = em.Message;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
