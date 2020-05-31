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
                cmd.CommandText = "SELECT * FROM teacher where TeacherID=" + tid;
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
                    sqlcmd = "insert into teacher(No,Name,TeacherID,Section,TPNo";
                    for (i = 14; i < al1.Count; i++)
                    {
                        sqlcmd = sqlcmd + "," + Convert.ToString(al1[i]);
                    }
                    sqlcmd = sqlcmd + ") values('" + tno + "', '" + tname + "','" + tid + "','"+secno+"','"+tpno+"'";
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
                    sqlcmd = "update teacher set Name='" + tname + "',TeacherID=" + tid + ",Section="+secno+",TPNo='"+tpno+"'";
                    for (i = 14; i < al1.Count; i++)
                    {
                        sqlcmd = sqlcmd + "," + Convert.ToString(al1[i]) + "=" + Convert.ToString(al2[i - 14]);
                    }
                    sqlcmd = sqlcmd + " where No=" + tno;
                    cmd.CommandText = sqlcmd;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "MSG 23");
                }
            }
        }
        public static void nameload()
        {
            try
            {
                cmd.CommandText = "SELECT * FROM teacher where No='" + tno + "'";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    tname = r.GetString("Name");
                    tid = r.GetString("TeacherID");
                }
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void nameloadtid()
        {
            try
            {
                cmd.CommandText = "SELECT * FROM teacher where TeacherID='" + tid + "'";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    tname = r.GetString("Name");
                    tno = r.GetInt32("No");
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
                cmd.CommandText = "SELECT * FROM `teacher` WHERE TeacherID='"+tid+"'";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    tname = r.GetString("Name");
                    tno = r.GetInt32("No");
                    secno = r.GetInt32("Section");
                    tpno = r.GetString("TPNo");
                    for (i = 14; i < al1.Count; i++)
                    {
                        al3.Add(r.GetInt32(Convert.ToString(al1[i])));
                    }
                }
                r.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot Find Any Record For "+tid+" For TeacherID");
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
        public static void maxfind()
        {
            try
            {
                cmd.CommandText = "SELECT MAX(No) FROM teacher";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    maxno = r.GetInt32(0);
                }
                r.Close();
            }
            catch (Exception)
            {
                r.Close();
            }
        }
        public static void teacherdelete()
        {
            maxno = 0;
            try
            {
                cmd.CommandText = "DELETE FROM `teacher` WHERE No="+tno+"";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "MSG 245");
            }
            maxfind();
            if((maxno!=tno)&&(maxno!=0))
            {
                try
                {
                    cmd.CommandText = "update teacher SET No = '" + tno + "'where No = '" + maxno + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message+"MSG 456");
                }
            }
            maxno = 0;
        }
        public static void secsearch()
        {
            try
            {
                cmd.CommandText = "SELECT No FROM section where Name='"+sec+"'";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    secno = r.GetInt32(0);
                }
                r.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                r.Close();
            }
        }
    }
}
