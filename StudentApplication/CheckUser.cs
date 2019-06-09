using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BIZ
{
    public class CheckUser
    {
        public bool VerifyUser(string user, string pass)
        {
            CheckLogin c = new CheckLogin();    // check match
            bool status = c.CheckUser(user, pass);

            return status;
        }
    }
}
