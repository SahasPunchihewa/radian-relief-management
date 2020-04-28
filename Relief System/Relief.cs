using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Relief_System
{
    class Relief:Program
    {
        public static void classload()
        {
            try
            {
                cmd.CommandText = "SELECT Name FROM class where No='"+classno+"'";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    classname = r.GetString(0);
                }
                r.Close();
            }
            catch (Exception ex)
            {
                r.Close();
            }
        }
    }
}
