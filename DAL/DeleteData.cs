using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DeleteData :DAO
    {
        public int DeleteStudent(string id)
        {
            SqlCommand cmd = new SqlCommand("uspDeleteStudent", OpenCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@stuID", id);
            int count = cmd.ExecuteNonQuery();
            CloseCon();
            return count;
        }
    }
}
