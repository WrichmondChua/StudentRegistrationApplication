using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public static string LastName = "";
        public static string FirstName = "";
        public static string MiddleName = "";
        public static string Day = "";
        public static string Month = "";
        public static string Year = "";
        public static string Gender = "";

        
        public frmStudentRegistration()
        {

            InitializeComponent();
            for (int day = 1; day <= 31; day++)
            {
                ComboBoxDay.Items.Add(day);
            }
            for (int month = 1; month <= 12; month++)
            {
                ComboBoxMonth.Items.Add(month);
            }
            for (int year = 1900; year <= 2021; year++)
            {
                ComboBoxYear.Items.Add(year);
            }

        }


        private void BtnRegisterStudent_Click(object sender, EventArgs e)
        {
            LastName = TxtboxLastName.Text;
            FirstName = TxtboxFirstName.Text;
            MiddleName = TxtboxMiddleName.Text;
            Day = ComboBoxDay.SelectedItem.ToString();
            Month = ComboBoxMonth.SelectedItem.ToString();
            Year = ComboBoxYear.SelectedItem.ToString();
            if (RadioButtonMale.Checked)
            {
                Gender = RadioButtonMale.Text.ToString();

            }
            else
            {
                Gender = RadioButtonFemale.Text.ToString();
            }

            MessageBox.Show("Student name: " + FirstName + " " + MiddleName + " " + LastName + "\nGender: " + Gender + "\nDate of Birth: " + Day + "/" + Month + "/" + Year);

        }



    }
}
