using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BIZ;
using System.Configuration;

namespace StudentApp
{

    //public enum SampleEnum
    //{
    //    Rose,
    //    Red,
    //    Violet,
    //    Blue
    //}
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
            //comboBox1.DataSource = Enum.GetValues(typeof(SampleEnum));
            cboCounty.DataSource = Enum.GetValues(typeof(County));
            cboCourse.DataSource = Enum.GetValues(typeof(Course));
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string fname = txtFn.Text;
            string sname = txtSn.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string adrs1 = txtAd1.Text;
            string adrs2 = txtAd2.Text;
            string city = txtCity.Text;

            string county = cboCounty.SelectedItem.ToString();
            string course = cboCourse.SelectedItem.ToString();
            string level = "Undergrad";
            if (rdoPostgrad.Checked)
            {
                level = "Postgrad";
            }

            Student student = new Student(fname, sname, email, phone, adrs1, adrs2, city, county, level, course);
            string count = student.AddStudentToDB();

            if (count == "n")
            {
                MessageBox.Show("First name and Surname required", "Add Student");
            }
            else
            {

                txtFn.Clear();
                txtSn.Clear();
                txtEmail.Clear();
                txtPhone.Clear();
                txtAd1.Clear();
                txtAd2.Clear();
                txtCity.Clear();
            }
            MessageBox.Show("New Student Id is: " + count, "New Student Added");
            this.Close();
            ShowStudents ss = new ShowStudents();
            ss.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            ShowStudents ss = new ShowStudents();
            ss.Show();
        }
    }


}
