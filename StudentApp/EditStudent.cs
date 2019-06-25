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
using DAL;
using System.Configuration;
using System.Xml.Serialization;
using System.Xml;

namespace StudentApp
{
    public partial class EditStudent : Form
    {
        public EditStudent()
        {
            InitializeComponent();
        }




        private void EditStudent_Load(object sender, EventArgs e)
        {
            string fname, sname, email, phone, adrs1, adrs2, city, county, level, course;
            GetStudent student = new GetStudent();
            bool found = student.GetStudentFromDB(ShowStudents.edID, out fname, out sname, out email, out phone, out adrs1,
                out adrs2, out city, out county, out level, out course);
            if (found)
            {
                txtFn.Text = fname;
                txtSn.Text = sname;
                txtEmail.Text = email;
                txtPhone.Text = phone;
                txtAd1.Text = adrs1;
                txtAd2.Text = adrs2;
                txtCity.Text = city;


                int countyNumber = (int)Enum.Parse(typeof(County), county);
                cboCounty.DataSource = Enum.GetValues(typeof(County));
                cboCounty.SelectedIndex = countyNumber;

                if (level == "Postgrad")
                {
                    rdoPostgrad.Checked = true;
                }
                else
                {
                    rdoUndergrad.Checked = true;
                }
                cboCourse.Text = course;

            }
            else
            {
                MessageBox.Show("Student not found");
            }

        }


            //ignore
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

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

            string level = "Undergrad";
            if (rdoPostgrad.Checked)
            {
                level = "Postgrad";
            }

            string course = cboCourse.Text.ToString();
            Student student = new Student(fname, sname, email, phone, adrs1, adrs2, city, county, level, course);

            student.UpdateStudentInDB(ShowStudents.edID);
            txtFn.Clear();
            txtSn.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAd1.Clear();
            txtAd2.Clear();
            txtCity.Clear();
            cboCounty.SelectedIndex = -1;

            MessageBox.Show("Student Updated");
            this.Close();
            ShowStudents ss = new ShowStudents();
            ss.Show();
        }
        private void BtnSerialise_Click(object sender, EventArgs e)
        {
            string fname = txtFn.Text;
            string sname = txtSn.Text;
            string email = txtEmail.Text;

            string phone = txtPhone.Text;

            string adrs1 = txtAd1.Text;
            string adrs2 = txtAd2.Text;
            string city = txtCity.Text;

            string county = cboCounty.SelectedItem.ToString();

            string level = "Undergrad";
            if (rdoPostgrad.Checked)
            {
                level = "Postgrad";
            }

            string course = cboCourse.Text.ToString();

            Student student = new Student(fname, sname, email, phone, adrs1, adrs2, city, county, level, course);

            XmlSerializer serialiser;
            XmlWriter xmlWriter;
            string filePath = string.Empty;

            sfd.InitialDirectory = "C:\\";
            sfd.Filter = "xml files (*.xml)|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filePath = sfd.FileName;
                serialiser = new XmlSerializer(typeof(Student));
                xmlWriter = XmlWriter.Create(filePath);
                serialiser.Serialize(xmlWriter, student);
                MessageBox.Show("Details serialised");
            }
            else
            {
                MessageBox.Show("Unable to Serialise");
            }

        }
    

        

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {

        }

        private void TxtEmail_Validated(object sender, EventArgs e)
        {

        }

        private void TxtPhone_Validating(object sender, CancelEventArgs e)
        {

        }

        private void TxtPhone_Validated(object sender, EventArgs e)
        {

        }


    }
}
