using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Relief_System
{
    class Relief:Program
    {
        public static void teachertime()
        {
            ca = 0;
            try
            {
                cmd.CommandText = "SELECT * FROM class where No='" + clzno + "'";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    tarr[0] = r.GetInt32("One");
                    tarr[1] = r.GetInt32("Two");
                    tarr[2] = r.GetInt32("Three");
                    tarr[3] = r.GetInt32("Four");
                    tarr[4] = r.GetInt32("Five");
                    tarr[5] = r.GetInt32("Six");
                    tarr[6] = r.GetInt32("Seven");
                    tarr[7] = r.GetInt32("Eight");
                    ca = 1;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+" MSG 1");
            }
            r.Close();
            if (ca == 1)
            {
                try
                {
                    cmd2.CommandText = "update teacher set One='" + clzno + "' where No='" + tarr[0] + "'";
                    cmd2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    cmd2.CommandText = "update teacher set Two='" + clzno + "' where No='" + tarr[1] + "'";
                    cmd2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    cmd2.CommandText = "update teacher set Three='" + clzno + "' where No='" + tarr[2] + "'";
                    cmd2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    cmd2.CommandText = "update teacher set Four='" + clzno + "' where No='" + tarr[3] + "'";
                    cmd2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    cmd2.CommandText = "update teacher set Five='" + clzno + "' where No='" + tarr[4] + "'";
                    cmd2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    cmd2.CommandText = "update teacher set Six='" + clzno + "' where No='" + tarr[5] + "'";
                    cmd2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    cmd2.CommandText = "update teacher set Seven='" + clzno + "' where No='" + tarr[6] + "'";
                    cmd2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    cmd2.CommandText = "update teacher set Eight='" + clzno + "' where No='" + tarr[7] + "'";
                    cmd2.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                clzno++;
                teachertime();
            }
        }
        public static void classload()
        {
            try
            {
                cmd.CommandText = "SELECT Name FROM class where No='"+classno+"'";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    classname = r.GetString(0);
                }
                r.Close();
            }
            catch (Exception ex)
            {
                r.Close();
            }
        }
        public static void timeget()
        {
            try
            {
                cmd.CommandText = "SELECT * FROM class where No='" + classno + "'";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    testarr[0] = r.GetInt32("One");
                    testarr[0] = r.GetInt32("Two");
                    testarr[0] = r.GetInt32("Three");
                    testarr[0] = r.GetInt32("Four");
                    testarr[0] = r.GetInt32("Five");
                    testarr[0] = r.GetInt32("Six");
                    testarr[0] = r.GetInt32("Seven");
                    testarr[0] = r.GetInt32("Eight");
                }
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void abscheck()
        {
            for(i=0;i<8;i++)
            {
                present = 0;
                try
                {
                    cmd.CommandText = "SELECT Present FROM class where No='" + testarr[i] + "'";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        present = r.GetInt32(0);
                        if(present==0)
                        {
                            randfound();
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
        public static void randfound()
        {
            try
            {
                cmd.CommandText = "SELECT No FROM `teacher` WHERE Present=1 ORDER BY RAND() LIMIT 1";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    rtmp = r.GetInt32(0);

                    
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
