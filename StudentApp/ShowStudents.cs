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
    }
}
