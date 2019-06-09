using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class ShowData: DAO
    {
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable Read()
        {
            // select all Students - usp

            SqlCommand cmd = new SqlCommand("uspAllStudents", OpenCon());
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            bs.DataSource = dt;
            return dt;
        }
    }
}
