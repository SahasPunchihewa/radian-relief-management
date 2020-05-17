using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Relief_System
{
    public class Teacher : Program
    {
        public static void nicchecked()
        {
            niccheck = 0;
            try
            {
                cmd.CommandText = "SELECT * FROM teacher where NIC=" + nic;
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    niccheck = 1;
                }
                r.Close();
            }
            catch (Exception)
            {
                r.Close();
            }
        }
        public static void tadd()
        {
            if (niccheck == 0)
            {
                try
                {
                    cmd.CommandText = "SELECT MAX(No) FROM teacher";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        tno = r.GetInt32(0) + 1;
                    }
                    r.Close();
                }
                catch (Exception)
                {
                    r.Close();
                }
                try
                {
                    sqlcmd = "insert into teacher(No,Name,NIC,Section";
                    for (i = 13; i < al1.Count; i++)
                    {
                        sqlcmd = sqlcmd + "," + Convert.ToString(al1[i]);
                    }
                    sqlcmd = sqlcmd + ") values('" + tno + "', '" + tname + "','" + nic + "','"+secno+"'";
                    for (i = 0; i < al2.Count; i++)
                    {
                        sqlcmd = sqlcmd + "," + Convert.ToString(al2[i]);
                    }
                    sqlcmd = sqlcmd + ")";
                    cmd.CommandText = sqlcmd;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "MSG 22");
                }
            }
            if (niccheck == 1)
            {
                try
                {
                    sqlcmd = "update teacher set Name='" + tname + "',NIC=" + nic + ",Section="+secno+"";
                    for (i = 13; i < al1.Count; i++)
                    {
                        sqlcmd = sqlcmd + "," + Convert.ToString(al1[i]) + "=" + Convert.ToString(al2[i - 13]);
                    }
                    sqlcmd = sqlcmd + " where No=" + tno;
                    cmd.CommandText = sqlcmd;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(sqlcmd);
                    MessageBox.Show(ex.Message + "MSG 23");
                }
            }

        }
        public static void nameload()
        {
            try
            {
                cmd.CommandText = "SELECT Name FROM teacher where No='" + tno + "'";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    tname = r.GetString(0);
                }
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void register()
        {
            try
            {
                cmd.CommandText = "update teacher SET Present = '" + present + "'where No = '" + tno + "'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void subload()
        {
            try
            {
                cmd.CommandText = "select COLUMN_NAME from information_schema.columns where TABLE_SCHEMA='radian-relief' And TABLE_NAME='teacher'";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    al1.Add(r.GetString(0));
                }
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void teacherload()
        {
            al3.Clear();
            try
            {
                cmd.CommandText = "SELECT * FROM `teacher` WHERE NIC='" + nic+"'";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    tname = r.GetString("Name");
                    tno = r.GetInt32("No");
                    secno = r.GetInt32("Section");
                    for (i = 13; i < al1.Count; i++)
                    {
                        al3.Add(r.GetInt32(Convert.ToString(al1[i])));
                    }
                }
                r.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot Find Any Record For "+nic+" For NIC");
            }
        }
        public static void secadder()
        {
            try
            {
                cmd.CommandText = "SELECT MAX(No) FROM section";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    secno = r.GetInt32(0) + 1;
                }
                r.Close();
            }
            catch (Exception)
            {
                r.Close();
            }
            try
            {
                cmd.CommandText = "insert into section(No,Name) values('" + secno + "', '" + sec + "')";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "MSG 24");
            }
        }
        public static void secload()
        {
            try
            {
                cmd.CommandText = "SELECT Name FROM `section`";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    al4.Add(r.GetString(0));
                }
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void teacherdelete()
        {
            try
            {
                cmd.CommandText = "DELETE FROM `teacher` WHERE No="+tno+"";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "MSG 245");
            }
        }
    }
}
