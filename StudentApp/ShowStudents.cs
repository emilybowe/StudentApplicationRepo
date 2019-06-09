using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace StudentApp
{
    public partial class ShowStudents : Form
    {
        public ShowStudents()
        {
            InitializeComponent();
        }
        ShowData sd = new ShowData();
        public static string edID;
        private void ShowStudents_Load(object sender, EventArgs e)
        {
            UpdateGrid();

            if (dgvStudents.Columns.Count > 0)
            {
                dgvStudents.Columns[0].HeaderText = "Student Number";
                dgvStudents.Columns[1].HeaderText = "First Name";
                dgvStudents.Columns[2].HeaderText = "Surname";
                dgvStudents.Columns[3].HeaderText = "Email";

                dgvStudents.Columns[4].HeaderText = "Phone";
                dgvStudents.Columns[5].HeaderText = "Address Line 1";
                dgvStudents.Columns[6].HeaderText = "Address Line 2";
                dgvStudents.Columns[7].HeaderText = "City";
                dgvStudents.Columns[8].HeaderText = "County";
                dgvStudents.Columns[9].HeaderText = "Level";
                dgvStudents.Columns[10].HeaderText = "Course";

            }


        }

        private void UpdateGrid()
        {
            dgvStudents.DataSource = sd.Read();

        }

        private void NewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addStu = new StudentApp.AddStudent();
            addStu.Show();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string delID = "";
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select Student to Delete", "Delete Student");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Delete Student", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    delID = dgvStudents.SelectedRows[0].Cells[0].Value.ToString();
                    DeleteData student = new DeleteData();
                    int count = student.DeleteStudent(delID);
                    MessageBox.Show("Student Deleted");

                    UpdateGrid();
                }
            }
        }

        private void EditStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edID = "";
            if (dgvStudents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select Student to Edit", "Edit Student");
            }
            else
            {
                edID = dgvStudents.SelectedRows[0].Cells[0].Value.ToString();

                EditStudent edStudent = new EditStudent();
                edStudent.Show();
            }
        }
    }
}
