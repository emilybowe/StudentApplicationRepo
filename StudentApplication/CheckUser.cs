using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Security.Cryptography;

namespace BIZ
{
    public class CheckUser
    {
        public bool VerifyUser(string user, string pass)
        {
            string passHash = PassHash(pass); //innovation 2 - encrypt the password
            CheckLogin c = new CheckLogin();    // check match
            bool status = c.CheckUser(user, passHash);

            
            return status;
            
        }



        public string PassHash(string pass) //innovation 2 - encrypt the password
        {
            SHA1 sha = SHA1.Create();
            byte[] hashdata = sha.ComputeHash(Encoding.Default.GetBytes(pass));
            StringBuilder returnValue = new StringBuilder();

            for (int i = 0; i < hashdata.Length; i++)
            {
                returnValue.Append(hashdata[i].ToString());
            }
            return returnValue.ToString();
        }
    }
}
