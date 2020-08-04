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
                if(ex.Message.Equals("Unable to connect to any of the specified MySQL hosts."))
                {
                    res = TopMSGBox.Show("Cannot Find Database. Are You Want to Retry? ", "Database Not Found", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        dbase();
                    }
                    else if(res==DialogResult.No)
                    {
                        System.Environment.Exit(0);
                    }
                }
                else
                {
                    MessageBox.Show(ex.Message + " Error #93");
                }
            }
        }
    }
}
