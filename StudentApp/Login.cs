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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        CheckLogin c = new CheckLogin();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            bool status = c.CheckUser(user, pass);
            if (!status)
            {
                MessageBox.Show("Invalid Login");
            }
            else
            {

                
                //show grid of all students before getting menu choice
                ShowStudents ss = new ShowStudents();
                ss.Show();
            }
            txtUser.Clear();
            txtPass.Clear();
        }



        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblUser.Show();
            txtUser.Show();
            lblPass.Show();
            txtPass.Show();
            btnLogin.Show();
        }


                                     

        private void NewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addStu = new AddStudent();
            addStu.Show();
        }







        //ignore
        private void AccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
