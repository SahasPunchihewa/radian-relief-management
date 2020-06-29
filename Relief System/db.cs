using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Relief_System
{
    public class db:Program
    {
        public static void dbase()
        {
            con = new MySqlConnection("server=localhost;database=radian-relief;uid=root;pwd=;");
            cmd = con.CreateCommand();
            try
            {
                con.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " Error #93");
            }
        }
    }
}
