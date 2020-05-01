using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Relief_System
{
    class Relief:Program
    {
        public static void resetter()
        {
            try
            {
                cmd.CommandText = "UPDATE `teacher` SET `One`=0,`Two`=0,`Three`=0,`Four`=0,`Five`=0,`Six`=0,`Seven`=0,`Eight`=0";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
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
                    cmd.CommandText = "update teacher set One='" + clzno + "' where No='" + tarr[0] + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    cmd.CommandText = "update teacher set Two='" + clzno + "' where No='" + tarr[1] + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    cmd.CommandText = "update teacher set Three='" + clzno + "' where No='" + tarr[2] + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    cmd.CommandText = "update teacher set Four='" + clzno + "' where No='" + tarr[3] + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    cmd.CommandText = "update teacher set Five='" + clzno + "' where No='" + tarr[4] + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    cmd.CommandText = "update teacher set Six='" + clzno + "' where No='" + tarr[5] + "'";
                    cmd .ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    cmd.CommandText = "update teacher set Seven='" + clzno + "' where No='" + tarr[6] + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    cmd.CommandText = "update teacher set Eight='" + clzno + "' where No='" + tarr[7] + "'";
                    cmd.ExecuteNonQuery();
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
                    testarr[1] = r.GetInt32("Two");
                    testarr[2] = r.GetInt32("Three");
                    testarr[3] = r.GetInt32("Four");
                    testarr[4] = r.GetInt32("Five");
                    testarr[5] = r.GetInt32("Six");
                    testarr[6] = r.GetInt32("Seven");
                    testarr[7] = r.GetInt32("Eight");
                }
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+" MSG 3");
            }
        }
        public static void abscheck()
        {
            for(i=0;i<8;i++)
            {
                present = 0;
                try
                {
                    cmd.CommandText = "SELECT Present FROM teacher where No='" + testarr[i] + "'";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        present = r.GetInt32(0);
                        if(present==0)
                        {
                            testarr[i] = 0;
                            randfound();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message+" MSG 4"+" "+i);
                }
                r.Close();
            }
            r.Close();
        }
        public static void randfound()
        {
            r.Close();
            if (i == 0)
            {
                try
                {
                    cmd.CommandText = "SELECT No FROM `teacher` WHERE Present=1 AND One=0 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (i == 1)
            {
                try
                {
                    cmd.CommandText = "SELECT No FROM `teacher` WHERE Present=1 AND Two=0 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (i == 2)
            {
                try
                {
                    cmd.CommandText = "SELECT No FROM `teacher` WHERE Present=1 AND Three=0 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (i == 3)
            {
                try
                {
                    cmd.CommandText = "SELECT No FROM `teacher` WHERE Present=1 AND Four=0 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (i == 4)
            {
                try
                {
                    cmd.CommandText = "SELECT No FROM `teacher` WHERE Present=1 AND Five=0 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (i == 5)
            {
                try
                {
                    cmd.CommandText = "SELECT No FROM `teacher` WHERE Present=1 AND Six=0 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (i == 6)
            {
                try
                {
                    cmd.CommandText = "SELECT No FROM `teacher` WHERE Present=1 AND Seven=0 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (i == 7)
            {
                try
                {
                    cmd.CommandText = "SELECT No FROM `teacher` WHERE Present=1 AND Eight=0 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            r.NextResult();
        }
    }
}
