using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableFootball.Classes
{
   static class calcAge
    {
        public static string Getage(string date)
        {
            DateTime dt = Convert.ToDateTime(date);
            TimeSpan tm = (DateTime.Now - dt);
            int age = (tm.Days / 365);
            return age.ToString();
        }
    }
}
