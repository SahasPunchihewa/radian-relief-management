using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Relief_System
{
    public class db:Program
    {
        public static void dbase()
        {
            con = new MySqlConnection("server=localhost;database=radian-relief;uid=root;pwd=;");
            cmd = con.CreateCommand();
            cmd2 = con.CreateCommand();
            try
            {
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
