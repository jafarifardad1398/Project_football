using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableFootball.Model;
using System.Web;
using System.Security.Cryptography;
using TableFootball.Classes;

namespace TableFootball.Controller
{
    class Acounting
    {
        #region Fun LogIN 
        //Function for Check out Identity Algoritem Hash Password Use Sha1
        public bool LogIn(string VUser, string VPass)
        {
            try
            {
                DataContext db = new DataContext();
                string Hash = Security.GetHash(VPass);
                if (db.Users.Any(Z => Z.UserName == VUser && Z.Password == Hash))
                {
                    return true;
                }
                else
                {
                    db.Dispose();
                    return false;
                }

            }
            catch (Exception ex)
            {
                string res = ex.Message;
                return false;
            }
        }
        #endregion

    }
}
