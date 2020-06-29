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
            catch (Exception)
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
                MessageBox.Show(ex.Message + " Error #48");
            }
            try
            {
                sqlaltetable = "alter table teacher add " + subname + " int(11) NULL after Present";
                cmd.CommandText = sqlaltetable;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error #49");
            }
        }
        public static void subupdate()
        {
            try
            {
                cmd.CommandText = "update subject SET Name = '" + subname + "'where No = '" + subno + "'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error #50");
            }
            try
            {
                cmd.CommandText = "ALTER TABLE `teacher` CHANGE " + oldsub + " " + subname + " INT(11) NULL DEFAULT NULL";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error #51");
            }
        }
        public static void oldsubget()
        {
            try
            {
                cmd.CommandText = "SELECT Name FROM subject where No='" + subno + "'";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    oldsub = r.GetString(0);
                }
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error #52");
            }
        }
        public static void subfind()
        {
            try
            {
                cmd.CommandText = "SELECT Name FROM subject where No='"+subno+"'";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    subname = r.GetString(0);
                }
                r.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot Find Any Record For " + subno);
            }
        }
        public static void maxfindsub()
        {
            try
            {
                cmd.CommandText = "SELECT MAX(No) FROM subject";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    maxsub = r.GetInt32(0);
                }
                r.Close();
            }
            catch (Exception)
            {
                r.Close();
            }
        }
        public static void subdelete()
        {
            maxsub = 0;
            try
            {
                cmd.CommandText = "DELETE FROM `subject` WHERE No=" + subno + "";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error #53");
            }
            try
            {
                cmd.CommandText = "ALTER TABLE `teacher` DROP "+subname+"";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error #54");
            }
            maxfindsub();
            if ((maxsub != subno) && (maxsub != 0))
            {
                try
                {
                    cmd.CommandText = "update subject SET No = '" + subno + "'where No = '" + maxsub + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Error #55");
                }
            }
            maxsub = 0;
        }
    }
}
