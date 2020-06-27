using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Relief_System
{
    class Relief : Program
    {
        public static void resetter()
        {
            for (i = 0; i < 8; i++)
            {
                timearr[i] = 0;
                testarr[i] = 0;
                reliefarr[i] = 0;
                tarr[i] = 0;
            }
        }
        public static void classcount()
        {
            try
            {
                cmd.CommandText = "SELECT COUNT(No) FROM `class` WHERE No<2000";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    countc = r.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " MSG 12121");
            }
            r.Close();
        }
        public static void teachertime()
        {
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " MSG 1");
            }
            r.Close();
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
                Console.WriteLine(ex.Message);
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
            try
            {
                cmd.CommandText = "SELECT * FROM class where No='" + (classno+2000) + "'";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    tsubarr[0] = r.GetInt32("One");
                    tsubarr[1] = r.GetInt32("Two");
                    tsubarr[2] = r.GetInt32("Three");
                    tsubarr[3] = r.GetInt32("Four");
                    tsubarr[4] = r.GetInt32("Five");
                    tsubarr[5] = r.GetInt32("Six");
                    tsubarr[6] = r.GetInt32("Seven");
                    tsubarr[7] = r.GetInt32("Eight");
                }
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " MSG 33");
            }
        }
        public static void redsubshow()
        {
            for(i=0;i<8;i++)
            {
               
                try
                {
                    cmd.CommandText = "SELECT Present FROM teacher where No='" + tarr[i] + "'";
                    r = cmd.ExecuteReader();
                    
                    while (r.Read())
                    {
                        redsub[i] = r.GetInt32(0);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                r.Close();
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
                            r.Close();
                            randfoundsub();
                            if(ransub==0)
                            {
                                randfoundclass();
                                if(ransub==0)
                                {
                                    randfound();
                                }
                            }
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
        public static void randfoundsub()
        {
            ransub = 0;
            if (i == 0)
            {
                try
                {
                    cmd.CommandText = "SELECT No FROM `teacher` WHERE Present=1 AND One=0  AND " + subarr[(tsubarr[i] - 1000)] + "=1 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                        ransub = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message+" I 0 1 ");
                }
            }
            if (i == 1)
            {
                try
                {
                    cmd.CommandText = "SELECT No FROM `teacher` WHERE Present=1 AND Two=0  AND " + subarr[(tsubarr[i]-1000)] + "=1 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                        ransub = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " I 1 2");
                }
            }
            if (i == 2)
            {
                try
                {
                    cmd.CommandText = "SELECT No FROM `teacher` WHERE Present=1 AND Three=0  AND " + subarr[(tsubarr[i]-1000)] + "=1 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                        ransub = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " I 2 3");
                }
            }
            if (i == 3)
            {
                try
                {
                    cmd.CommandText = "SELECT No FROM `teacher` WHERE Present=1 AND Four=0  AND " + subarr[(tsubarr[i]-1000)] + "=1 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                        ransub = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " I 3 4");
                }
            }
            if (i == 4)
            {
                try
                {
                    cmd.CommandText = "SELECT No FROM `teacher` WHERE Present=1 AND Five=0  AND " + subarr[(tsubarr[i]-1000)] + "=1 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                        ransub = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " I 4 5");
                }
            }
            if (i == 5)
            {
                try
                {
                    cmd.CommandText = "SELECT No FROM `teacher` WHERE Present=1 AND Six=0  AND " + subarr[(tsubarr[i]-1000)] + "=1 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                        ransub = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " I 5 6");
                }
            }
            if (i == 6)
            {
                try
                {
                    cmd.CommandText = "SELECT No FROM `teacher` WHERE Present=1 AND Seven=0  AND " + subarr[(tsubarr[i]-1000)] + "=1 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                        ransub = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " I 6 7");
                }
            }
            if (i == 7)
            {
                try
                {
                    cmd.CommandText = "SELECT No FROM `teacher` WHERE Present=1 AND Eight=0  AND " + subarr[(tsubarr[i]-1000)] + "=1 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                        ransub = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " I 7 8");
                }
            }
            r.NextResult();
        }
        public static void randfoundclass()
        {
            r.Close();
            ransub = 0;
            if (i == 0)
            {
                try
                {
                    cmd.CommandText = "SELECT No,Name FROM `teacher` WHERE (One=" + classno + " OR Two=" + classno+ " OR Three=" + classno + " OR Four=" + classno + " OR Five=" + classno + " OR Six=" + classno + " OR Seven=" + classno + " OR Eight=" + classno + ") And Present=1 AND One=0 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                        ransub = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " I 0 ");
                }
            }
            if (i == 1)
            {
                try
                {
                    cmd.CommandText = "SELECT No,Name FROM `teacher` WHERE (One=" + classno + " OR Two=" + classno + " OR Three=" + classno + " OR Four=" + classno + " OR Five=" + classno + " OR Six=" + classno + " OR Seven=" + classno + " OR Eight=" + classno + ") And Present=1 AND Two=0 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                        ransub = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " I 1 ");
                }
            }
            if (i == 2)
            {
                try
                {
                    cmd.CommandText = "SELECT No,Name FROM `teacher` WHERE (One=" + classno + " OR Two=" + classno + " OR Three=" + classno + " OR Four=" + classno + " OR Five=" + classno + " OR Six=" + classno + " OR Seven=" + classno + " OR Eight=" + classno + ") And Present=1 AND Three=0 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                        ransub = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " I 2 ");
                }
            }
            if (i == 3)
            {
                try
                {
                    cmd.CommandText = "SELECT No,Name FROM `teacher` WHERE (One=" + classno + " OR Two=" + classno + " OR Three=" + classno + " OR Four=" + classno + " OR Five=" + classno + " OR Six=" + classno + " OR Seven=" + classno + " OR Eight=" + classno + ") And Present=1 AND Four=0 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                        ransub = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " I 3 ");
                }
            }
            if (i == 4)
            {
                try
                {
                    cmd.CommandText = "SELECT No,Name FROM `teacher` WHERE (One=" + classno + " OR Two=" + classno + " OR Three=" + classno + " OR Four=" + classno + " OR Five=" + classno + " OR Six=" + classno + " OR Seven=" + classno + " OR Eight=" + classno + ") And Present=1 AND Five=0 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                        ransub = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " I 4 ");
                }
            }
            if (i == 5)
            {
                try
                {
                    cmd.CommandText = "SELECT No,Name FROM `teacher` WHERE (One=" + classno + " OR Two=" + classno + " OR Three=" + classno + " OR Four=" + classno + " OR Five=" + classno + " OR Six=" + classno + " OR Seven=" + classno + " OR Eight=" + classno + ") And Present=1 AND Six=0 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                        ransub = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " I 5 ");
                }
            }
            if (i == 6)
            {
                try
                {
                    cmd.CommandText = "SELECT No,Name FROM `teacher` WHERE (One=" + classno + " OR Two=" + classno + " OR Three=" + classno + " OR Four=" + classno + " OR Five=" + classno + " OR Six=" + classno + " OR Seven=" + classno + " OR Eight=" + classno + ") And Present=1 AND Seven=0 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                        ransub = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " I 6 ");
                }
            }
            if (i == 7)
            {
                try
                {
                    cmd.CommandText = "SELECT No,Name FROM `teacher` WHERE (One=" + classno + " OR Two=" + classno + " OR Three=" + classno + " OR Four=" + classno + " OR Five=" + classno + " OR Six=" + classno + " OR Seven=" + classno + " OR Eight=" + classno + ") And Present=1 AND Eight=0 ORDER BY RAND() LIMIT 1";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        reliefarr[i] = r.GetInt32(0);
                        ransub = 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " I 7 ");
                }
            }
            r.NextResult();
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
        public static void trelupdater()
        {
            for (i = 0; i < 8; i++)
            {
                if (reliefarr[i] != 0)
                {
                    if(i==0)
                    {
                        try
                        {
                            cmd.CommandText = "update teacher set One='" + (classno + 1000) + "' where No='" + reliefarr[i] + "'";
                            cmd.ExecuteNonQuery();
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
                            cmd.CommandText = "update teacher set Two='" + (classno + 1000) + "' where No='" + reliefarr[i] + "'";
                            cmd.ExecuteNonQuery();
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
                            cmd.CommandText = "update teacher set Three='" + (classno + 1000) + "' where No='" + reliefarr[i] + "'";
                            cmd.ExecuteNonQuery();
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
                            cmd.CommandText = "update teacher set Four='" + (classno + 1000) + "' where No='" + reliefarr[i] + "'";
                            cmd.ExecuteNonQuery();
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
                            cmd.CommandText = "update teacher set Five='" + (classno + 1000) + "' where No='" + reliefarr[i] + "'";
                            cmd.ExecuteNonQuery();
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
                            cmd.CommandText = "update teacher set Six='" + (classno + 1000) + "' where No='" + reliefarr[i] + "'";
                            cmd.ExecuteNonQuery();
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
                            cmd.CommandText = "update teacher set Seven='" + (classno + 1000) + "' where No='" + reliefarr[i] + "'";
                            cmd.ExecuteNonQuery();
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
                            cmd.CommandText = "update teacher set Eight='" + (classno + 1000) + "' where No='" + reliefarr[i] + "'";
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
            }
        }
        public static void reliefclz()
        {
            try
            {
                cmd.CommandText = "insert into class(No,Name,One,Two,Three,Four,Five,Six,Seven,Eight) values('" + (classno+1000) + "','" + classname + "','" + newt[0] + "','" + newt[1] + "','" + newt[2] + "','" + newt[3] + "','" + newt[4] + "','" + newt[5] + "','" + newt[6] + "','" + newt[7] + "')";
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                try
                {
                    cmd.CommandText = "update class set One='" + newt[0] + "',Two='" + newt[1] + "',Three='" + newt[2] + "',Four='" + newt[3] + "',Five='" + newt[4] + "',Six='" + newt[5] + "',Seven='" + newt[6] + "',Eight='" + newt[0] + "' where No='" + (classno + 1000)+"'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message);
                }
            }
        }

        public static void teacherclear()
        {
            for(i=0; i<8; i++)
            {
                try
                {
                    cmd.CommandText = "update teacher set "+time[i]+"=0 where "+time[i]+"='" + (classno + 1000) + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message);
                }
            }
            try
            {
                cmd.CommandText = "DELETE FROM `class` WHERE NO ='"+(classno+1000)+"'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
        }
        public static void timetablesearch()
        {
            try
            {
                cmd.CommandText = "SELECT No FROM `class` WHERE Name='"+classname+"' AND No<2000";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    classno= r.GetInt32(0);
                    clzno = r.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void classmax()
        {
            try
            {
                cmd.CommandText = "SELECT MAX(No) FROM `class` WHERE No<2000";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    maxclz = r.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            r.Close();
        }
    }
}
