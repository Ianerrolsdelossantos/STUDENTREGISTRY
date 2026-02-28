using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            for (int day = 1; day <= 31; day++)
            {
                cboDay.Items.Add(day);
            }

           
            for (int month = 1; month <= 12; month++)
            {
                cboMonth.Items.Add(month);
            }

            
            int currentYear = DateTime.Now.Year;

            for (int year = 1900; year <= currentYear; year++)
            {
                cboYear.Items.Add(year);
            }
        }
        
        
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdoMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string middleName = txtMiddelName.Text;

            // Decision statement for Gender
            string gender = "";

            if (rdoMale.Checked)
            {
                gender = "Male";
            }
            else if (rdoFemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Not Selected";
            }

            // Decision statement for ComboBoxes
            string day = "";
            string month = "";
            string year = "";

            if (cboDay.SelectedItem != null)
                day = cboDay.SelectedItem.ToString();

            if (cboMonth.SelectedItem != null)
                month = cboMonth.SelectedItem.ToString();

            if (cboYear.SelectedItem != null)
                year = cboYear.SelectedItem.ToString();

            string birthDate = month + "/" + day + "/" + year;

            // Display all information
            MessageBox.Show(
                "Student Information\n\n" +
                "First Name: " + firstName + "\n" +
                "Last Name: " + lastName + "\n" +
                "Middle Name: " + middleName + "\n" +
                "Gender: " + gender + "\n" +
                "Date of Birth: " + birthDate,
                "Registration Summary",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
        
    

