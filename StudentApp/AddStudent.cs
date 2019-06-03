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

    public enum SampleEnum
    {
        Rose,
        Red,
        Violet,
        Blue
    }
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(SampleEnum));
        }
    }
}
