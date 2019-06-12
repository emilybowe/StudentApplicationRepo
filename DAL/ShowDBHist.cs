using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class ShowDBHist: DAO
    {
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        SqlDataAdapter da = new SqlDataAdapter();

        public DataTable Read()
        {
            SqlCommand cmd = new SqlCommand("uspStudentHist ", OpenCon());
            cmd.CommandType = CommandType.StoredProcedure;
            da.SelectCommand = cmd;
            da.Fill(dt);
            bs.DataSource = dt;
            return dt;
        }
    }
}
