using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class CheckLogin:DAO
    {
        public bool CheckUser(string user, string pass)
        {
            SqlDataReader dr = null;
            bool status = false;

            SqlCommand cmd = new SqlCommand("uspFindUser", OpenCon());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                status = true;
            }

            CloseCon();
            return status;

        }
    }
}
