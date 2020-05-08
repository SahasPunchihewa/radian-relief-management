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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                cmd.CommandText = "insert into teacher(No,Name) values('" + tno + "','" + tname + "')";
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
    }
}
