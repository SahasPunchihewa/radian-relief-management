using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Relief_System
{
    class Timetable:Program
    {
        public static void timeadd()
        {
            try
            {
                cmd.CommandText = "SELECT MAX(No) FROM class";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    classno = r.GetInt32(0) + 1;
                }
                r.Close();
            }
            catch (Exception ex)
            {
                r.Close();
            }
            try
            {
                cmd.CommandText = "insert into class(No,Name,One,Two,Three,Four,Five,Six,Seven,Eight) values('" + classno + "','" + classname + "','" + timearr[0] + "','" + timearr[1] + "','" + timearr[2] + "','" + timearr[3] + "','" + timearr[4] + "','" + timearr[5] + "','" + timearr[6] + "','" + timearr[7] + "')";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
