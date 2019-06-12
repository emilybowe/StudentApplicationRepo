using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StudentApp
{
    public partial class ShowHist : Form
    {
        public ShowHist()
        {
            InitializeComponent();
        }

        private void ShowHist_Load(object sender, EventArgs e)
        {
            UpdateGrid();

            if (dgvStudents.Columns.Count > 0)
            {
                dgvStudents.Columns[0].HeaderText = "Action";
                dgvStudents.Columns[1].HeaderText = "Sequence Number";


                dgvStudents.Columns[2].HeaderText = "Student Number";
                dgvStudents.Columns[3].HeaderText = "First Name";
                dgvStudents.Columns[4].HeaderText = "Surname";
                dgvStudents.Columns[5].HeaderText = "Email";

                dgvStudents.Columns[6].HeaderText = "Phone";
                dgvStudents.Columns[7].HeaderText = "Address Line 1";
                dgvStudents.Columns[8].HeaderText = "Address Line 2";
                dgvStudents.Columns[9].HeaderText = "City";
                dgvStudents.Columns[10].HeaderText = "County";
                dgvStudents.Columns[11].HeaderText = "Level";
                dgvStudents.Columns[12].HeaderText = "Course";

            }
        }
            private void UpdateGrid()
            {
                ShowDBHist sd = new ShowDBHist();   //need to refresh the entire table 

                dgvStudents.DataSource = sd.Read();

            }
        
    }
}
