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
    public partial class Add_Employees : Form
    {
        string imgLocation = "";
        
        public Add_Employees()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBoxAE.ImageLocation = imgLocation;
            }
            else
            {
                imgLocation = pictureBoxAE.ImageLocation;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employees em = new Employees(txtAEName.Text, txtAEFName.Text, txtAEMName.Text, cmbAEGender.Text, cmbAEDepartment.Text, cmbAEDesignation.Text, txtAEPStatus.Text, txtAECStatus.Text, txtAEPNo.Text, txtAEEmail.Text, txtAEAddress.Text);
            try
            {
                em.imageLocation = imgLocation;
                em.BirthDate = dateTimePickerAEB.Text;
                em.Id = cmbAEID.Text;    

                em.AddEmployees();
                if (em.Message == "Data save successfully")
                {
                    labelMSS.Text = em.Message;
                    txtAEName.Text = "";
                    imgLocation = "";
                    txtAEFName.Text = "";
                    txtAEMName.Text = "";
                    dateTimePickerAEB.Text = "";
                    cmbAEGender.Text = "";
                    cmbAEDepartment.Text = "";
                    cmbAEDesignation.Text = "";
                    cmbAEID.Text = "";
                    txtAEPStatus.Text = "";
                    txtAECStatus.Text = "";
                    txtAEPNo.Text = "";
                    txtAEEmail.Text = "";
                    txtAEAddress.Text = "";
                    labelMSF.Text = "";
                }
                else
                {
                    labelMSF.Text = em.Message;
                    labelMSS.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAEName_KeyUp(object sender, KeyEventArgs e)
        {
            labelMSS.Text = "";
            labelMSF.Text = "";
        }
    }
}
