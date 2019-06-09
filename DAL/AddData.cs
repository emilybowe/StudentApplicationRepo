using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class AddData:DAO
    {
        public string AddNewStudent(string fname, string sname, string email, string phone, string adrs1, string adrs2, string city, string county, string level, string course)
        {

            // usp to insert student

            SqlCommand cmd = new SqlCommand("uspAddStudent", OpenCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fName", fname);
            cmd.Parameters.AddWithValue("@sName", sname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@adrs1", adrs1);
            cmd.Parameters.AddWithValue("@adrs2", adrs2);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@county", county);
            cmd.Parameters.AddWithValue("@level", level);
            cmd.Parameters.AddWithValue("@course", course);
            string count = "";
            count = cmd.ExecuteNonQuery().ToString();
            CloseCon();
            return count;

        }
    }
}
