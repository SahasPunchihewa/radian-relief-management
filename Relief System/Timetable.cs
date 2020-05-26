using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Relief_System
{
    class Timetable:Program
    {
        public static void cnamecheck()
        {
            nameup = 0;
            try
            {
                cmd.CommandText = "SELECT * FROM class WHERE Name='" + classname + "'";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    nameup = 1;
                }
                r.Close();
            }
            catch (Exception)
            {
                r.Close();
            }
        }
        public static void timeadd()
        {
            if(nameup==1)
            {
                try
                {
                    cmd.CommandText = "update class set Name='"+classname+"',One='"+ t1[tindex[0]] + "',Two='"+ t2[tindex[1]] + "',Three='"+ t3[tindex[2]] + "',Four='"+ t4[tindex[3]] + "',Five='"+ t5[tindex[4]] + "',Six='"+ t6[tindex[5]] + "',Seven='"+ t7[tindex[6]] + "',Eight='"+ t8[tindex[7]] + "' where No='"+classno+"'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message+" MSG 111");
                }
                try
                {
                    cmd.CommandText = "update class set Name='" + classname + "',One='" + timearr[0] + "',Two='" + timearr[1] + "',Three='" + timearr[2] + "',Four='" + timearr[3] + "',Five='" + timearr[4] + "',Six='" + timearr[5] + "',Seven='" + timearr[6] + "',Eight='" + timearr[7] + "' where No='" + (classno+2000) + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message+" MSG 222");
                }
            }
            else
            {
                try
                {
                    cmd.CommandText = "SELECT MAX(No) FROM class WHERE No<2000;";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        classno = r.GetInt32(0) + 1;
                    }
                    r.Close();
                }
                catch (Exception)
                {
                    r.Close();
                }
                try
                {
                    cmd.CommandText = "insert into class(No,Name,One,Two,Three,Four,Five,Six,Seven,Eight) values('" + classno + "','" + classname + "','" + t1[tindex[0]] + "','" + t2[tindex[1]] + "','" + t3[tindex[2]] + "','" + t4[tindex[3]] + "','" + t5[tindex[4]] + "','" + t6[tindex[5]] + "','" + t7[tindex[6]] + "','" + t8[tindex[7]] + "')";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    cmd.CommandText = "insert into class(No,Name,One,Two,Three,Four,Five,Six,Seven,Eight) values('" + (classno + 2000) + "','" + classname + "','" + timearr[0] + "','" + timearr[1] + "','" + timearr[2] + "','" + timearr[3] + "','" + timearr[4] + "','" + timearr[5] + "','" + timearr[6] + "','" + timearr[7] + "')";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            try
            {
                cmd.CommandText = "UPDATE `teacher` SET `One`='"+classno+"' where No='"+ t1[tindex[0]] + "'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                cmd.CommandText = "UPDATE `teacher` SET `Two`='" + classno + "' where No='" + t2[tindex[1]] + "'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                cmd.CommandText = "UPDATE `teacher` SET `Three`='" + classno + "' where No='" + t3[tindex[2]] + "'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                cmd.CommandText = "UPDATE `teacher` SET `Four`='" + classno + "' where No='" + t4[tindex[3]] + "'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                cmd.CommandText = "UPDATE `teacher` SET `Five`='" + classno + "' where No='" + t5[tindex[4]] + "'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                cmd.CommandText = "UPDATE `teacher` SET `Six`='" + classno + "' where No='" + t6[tindex[5]] + "'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                cmd.CommandText = "UPDATE `teacher` SET `Seven`='" + classno + "' where No='" + t7[tindex[6]] + "'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                cmd.CommandText = "UPDATE `teacher` SET `Eight`='" + classno + "' where No='" + t8[tindex[7]] + "'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void subnameload()
        {
            try
            {
                cmd.CommandText = "SELECT Name FROM `subject` where No='"+subno+"'";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    subname = r.GetString(0);
                }
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void tloadone()
        {
            try
            {
                cmd.CommandText = "SELECT * FROM `teacher` where "+subname+"=1 AND "+timet+"=0";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    if(timet.Equals("One"))
                    {
                        t1.Add(r.GetString("No"));
                        tn1.Add(r.GetString("Name"));
                    }
                    if (timet.Equals("Two"))
                    {
                        t2.Add(r.GetString("No"));
                        tn2.Add(r.GetString("Name"));
                    }
                    if (timet.Equals("Three"))
                    {
                        t3.Add(r.GetString("No"));
                        tn3.Add(r.GetString("Name"));
                    }
                    if (timet.Equals("Four"))
                    {
                        t4.Add(r.GetString("No"));
                        tn4.Add(r.GetString("Name"));
                    }
                    if (timet.Equals("Five"))
                    {
                        t5.Add(r.GetString("No"));
                        tn5.Add(r.GetString("Name"));
                    }
                    if (timet.Equals("Six"))
                    {
                        t6.Add(r.GetString("No"));
                        tn6.Add(r.GetString("Name"));
                    }
                    if (timet.Equals("Seven"))
                    {
                        t7.Add(r.GetString("No"));
                        tn7.Add(r.GetString("Name"));
                    }
                    if (timet.Equals("Eight"))
                    {
                        t8.Add(r.GetString("No"));
                        tn8.Add(r.GetString("Name"));
                    }
                }
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void timesearch()
        {
            classno = 0;
            try
            {
                cmd.CommandText = "SELECT * FROM `class` where Name='" + classname + "' AND No<2000";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    classno = r.GetInt32("No");
                    time2arr[0] = r.GetInt32("One");
                    time2arr[1] = r.GetInt32("Two");
                    time2arr[2] = r.GetInt32("Three");
                    time2arr[3] = r.GetInt32("Four");
                    time2arr[4] = r.GetInt32("Five");
                    time2arr[5] = r.GetInt32("Six");
                    time2arr[6] = r.GetInt32("Seven");
                    time2arr[7] = r.GetInt32("Eight");
                }
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                cmd.CommandText = "SELECT * FROM `class` where Name='" + classname + "' AND No>3000";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    timearr[0] = r.GetInt32("One");
                    timearr[1] = r.GetInt32("Two");
                    timearr[2] = r.GetInt32("Three");
                    timearr[3] = r.GetInt32("Four");
                    timearr[4] = r.GetInt32("Five");
                    timearr[5] = r.GetInt32("Six");
                    timearr[6] = r.GetInt32("Seven");
                    timearr[7] = r.GetInt32("Eight");
                }
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            for(i=0; i<8; i++)
            {
                try
                {
                    cmd.CommandText = "SELECT Name FROM `teacher` where No='" + time2arr[i] + "'";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        tnames[i] = r.GetString(0);
                    }
                    r.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public static void timedelete()
        {
            try
            {
                cmd.CommandText = "DELETE FROM `class` WHERE Name = '"+classname+"'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                cmd.CommandText = "UPDATE `teacher` SET One = 0 WHERE One ='" + classno + "'; UPDATE `teacher` SET Two = 0 WHERE Two ='" + classno + "'; UPDATE `teacher` SET Three = 0 WHERE Three ='" + classno + "'; UPDATE `teacher` SET Four = 0 WHERE Four ='" + classno + "'; UPDATE `teacher` SET Five = 0 WHERE Five ='" + classno + "'; UPDATE `teacher` SET Six = 0 WHERE Six ='" + classno + "'; UPDATE `teacher` SET Seven = 0 WHERE Seven ='" + classno + "'; UPDATE `teacher` SET Eight = 0 WHERE Eight ='" + classno + "';";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
