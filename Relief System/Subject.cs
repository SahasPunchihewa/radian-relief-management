using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Relief_System
{
    class Subject:Program
    {
        public static void subadd()
        {
            try
            {
                cmd.CommandText = "SELECT MAX(No) FROM subject";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    subno = r.GetInt32(0) + 1;
                }
                r.Close();
            }
            catch (Exception ex)
            {
                r.Close();
            }
            try
            {
                cmd.CommandText = "insert into subject(No,Name) values('" + subno + "','" + subname +"')";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+" MSG 2");
            }
            try
            {
                sqlaltetable = "alter table teacher add " + subname + " int(11) NULL after Present";
                cmd.CommandText = sqlaltetable;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"MSG 3");
            }
        }
    }
}
