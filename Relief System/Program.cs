using System;
using System.Collections;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;

namespace Relief_System
{
    public class Program
    {
        public static MySqlConnection con;
        public static MySqlCommand cmd;
        public static int tno,present=0,subno,classno=0,rtmp,i,clzno,ca=0,ransub=0,subcount=0,niccheck=0,secno=0,checktest=0,maxno=0,maxsub=0,countc=0,nc=0;
        public static int nameup = 0,maxclz=0,secc=0,relindex;
        public static String tname, sec,subname,sqlaltetable,classname,relno,sqlcmd,tid,tpno,oldsub,timet,date,reltext,path,dir,textname;
        public static MySqlDataReader r;
        public static int[] timearr = new int[8],redsub=new int[8],time2arr = new int[8],tsubarr = new int[8],testarr = new int[8],rarr=new int[8],bluesub=new int[8];
        public static int[] reliefarr = new int[8],tarr = new int[8],newt = new int[8],tindex = new int[8],relload=new int[8],trelp=new int[8];
        public static ArrayList al1,al2,al3,al4,al5,al6;
        public static ArrayList t1, t2, t3, t4, t5, t6, t7, t8;
        public static ArrayList tn1, tn2, tn3, tn4, tn5, tn6, tn7, tn8;
        public static String[] subarr;
        public static String[] time = new string[8],relprinter = new string[8],tnames = new string[8];
        public static StreamWriter sw;
        public static PrintDialog pd;
        public static ProcessStartInfo info;
        public static Process pp;
        public static DialogResult res;
        public static Regex rgx;




        /// <summary>
        /// The main entry point for the application.
        /// </summary>


        static void Main2(object state)
        {
            Application.Run((Form)state);
        }
        public Program()
        {
            Load lod = new Load();
            Thread thread = new Thread(Main2);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start(lod);
            initializer();
            thread.Abort(lod);
        }

        public static void initializer()
        {
            rgx = new Regex("[^a-zA-Z0-9]");
            dir = @"C:\Users\Public\Documents\RadianLabs\ReliefText";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            time[0] = "One";
            time[1] = "Two";
            time[2] = "Three";
            time[3] = "Four";
            time[4] = "Five";
            time[5] = "Six";
            time[6] = "Seven";
            time[7] = "Eight";
            for (i = 0; i < 8; i++)
            {
                reliefarr[i] = 0;
                relload[i] = 0;
                bluesub[i] = 0;
            }
            db.dbase();
            /*try
            {
                cmd.CommandText = "UPDATE `teacher` SET One = 0 WHERE One> 2000; UPDATE `teacher` SET Two = 0 WHERE Two> 2000; UPDATE `teacher` SET Three = 0 WHERE Three> 2000; UPDATE `teacher` SET Four = 0 WHERE Four> 2000; UPDATE `teacher` SET Five = 0 WHERE Five> 2000; UPDATE `teacher` SET Six = 0 WHERE Six> 2000; UPDATE `teacher` SET Seven = 0 WHERE Seven> 2000; UPDATE `teacher` SET Eight = 0 WHERE Eight> 2000;";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            date = DateTime.Now.ToString("yyyy.MM.dd");
            pd = new PrintDialog();
            pp = new Process();
            al1 = new ArrayList();
            al2 = new ArrayList();
            al3 = new ArrayList();
            al4 = new ArrayList();
            al5 = new ArrayList();
            al6 = new ArrayList();
            t1 = new ArrayList();
            t2 = new ArrayList();
            t3 = new ArrayList();
            t4 = new ArrayList();
            t5 = new ArrayList();
            t6 = new ArrayList();
            t7 = new ArrayList();
            t8 = new ArrayList();
            tn1 = new ArrayList();
            tn2 = new ArrayList();
            tn3 = new ArrayList();
            tn4 = new ArrayList();
            tn5 = new ArrayList();
            tn6 = new ArrayList();
            tn7 = new ArrayList();
            tn8 = new ArrayList();
            try
            {
                cmd.CommandText = "SELECT COUNT(No) FROM subject";
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    subcount = r.GetInt32(0);
                }
                r.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error #1");
            }
            subarr = new String[subcount];
            for (i = 0; i < subcount; i++)
            {
                try
                {
                    cmd.CommandText = "SELECT Name FROM subject where No='" + (i + 1000) + "'";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        subarr[i] = r.GetString(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + " Error #2");
                }
                r.Close();
            }
        }
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Program();
            Application.Run(new Switch());
            con.Close();
        }
    }
}
