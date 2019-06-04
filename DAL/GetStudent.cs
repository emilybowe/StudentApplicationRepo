using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class GetStudent:DAO
    {
        public bool GetStudentFromDB(string id, out string fname, out string sname, out string email,
            out string phone, out string adrs1, out string adrs2, out string city, out string county,
            out string level, out string course)
        {
            SqlDataReader dr;

            fname = sname = email = phone = adrs1 = adrs2 = city = county = level = course = " ";
            bool found = false;
            SqlCommand cmd = new SqlCommand("uspFindStudent", OpenCon());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@stuID", id);

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                found = true;
                fname = dr[1].ToString();
                sname = dr[2].ToString();
                email = dr[3].ToString();
                phone = dr[4].ToString();
                adrs1 = dr[5].ToString();
                adrs2 = dr[6].ToString();
                city = dr[7].ToString();
                county = dr[8].ToString();
                level = dr[9].ToString();
                course = dr[10].ToString();
            }
            return found;
        }
    }
}
