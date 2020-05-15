using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Relief_System
{
    public class Teacher:Program
    {
        public static void tadd()
        {
            try
            {
                cmd.CommandText = "SELECT MAX(No) FROM teacher";
                r = cmd.ExecuteReader();
                while(r.Read())
                {
                    tno = r.GetInt32(0) + 1;
                }
                r.Close();
            }
            catch(Exception)
            {
                r.Close();
            }
            try
            {
                sqlcmd = "insert into teacher(No,Name";
                for(i=12; i<al1.Count; i++)
                {
                    sqlcmd = sqlcmd + "," + Convert.ToString(al1[i]);
                }
                sqlcmd=sqlcmd+") values('" + tno + "', '" + tname + "'";
                for (i = 0; i < al2.Count; i++)
                {
                    sqlcmd = sqlcmd + "," + Convert.ToString(al2[i]);
                }
                sqlcmd = sqlcmd + ")";
                cmd.CommandText = sqlcmd;
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+"MSG 22");
            }
        }
        public static void nameload()
        {
            try
            {
                cmd.CommandText = "SELECT Name FROM teacher where No='"+tno+"'";
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
                cmd.CommandText = "update teacher SET Present = '"+present+"'where No = '"+tno+"'";
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
                cmd.CommandText = "SELECT * FROM `teacher` WHERE NIC="+nic;
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    tname = r.GetString("Name");
                    for (i = 13; i<al1.Count; i++)
                    {
                        al3.Add(r.GetInt32(Convert.ToString(al1[i])));
                    }
                }
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
