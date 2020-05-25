using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Relief_System
{
    public class Program
    {
        public static MySqlConnection con;
        public static MySqlCommand cmd;
        public static int tno,present=0,subno,classno=0,rtmp,i,clzno,ca=0,date,ransub=0,subcount=0,niccheck=0,secno=0,checktest=0,maxno=0,maxsub=0;
        public static String tname, sec,subname,sqlaltetable,classname,relno,sqlcmd,tid,tpno,oldsub,timet;
        public static MySqlDataReader r;
        public static int[] timearr = new int[8];
        public static int[] time2arr = new int[8];
        public static int[] tsubarr = new int[8];
        public static int[] testarr = new int[8];
        public static int[] reliefarr = new int[8];
        public static int[] tarr = new int[8];
        public static int[] newt = new int[8];
        public static int[] tindex = new int[8];
        public static ArrayList al1,al2,al3,al4;
        public static ArrayList t1, t2, t3, t4, t5, t6, t7, t8;
        public static ArrayList tn1, tn2, tn3, tn4, tn5, tn6, tn7, tn8;
        public static String[] subarr;
        public static String[] time = new string[8];
        public static String[] tnames = new string[8];

        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public Program()
        {
            time[0] = "One";
            time[1] = "Two";
            time[2] = "Three";
            time[3] = "Four";
            time[4] = "Five";
            time[5] = "Six";
            time[6] = "Seven";
            time[7] = "Eight";
            for (i=0;i<8;i++)
            {
                reliefarr[i] = 0;
            }
            db.dbase();
            try
            {
                cmd.CommandText = "UPDATE `teacher` SET `One`=0,`Two`=0,`Three`=0,`Four`=0,`Five`=0,`Six`=0,`Seven`=0,`Eight`=0";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            date = Convert.ToInt32(DateTime.Now.ToString("dd"));
            al1 = new ArrayList();
            al2 = new ArrayList();
            al3 = new ArrayList();
            al4 = new ArrayList();
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
                MessageBox.Show(ex.Message);
            }
            subarr= new String[subcount];
            for(i=0;i<subcount;i++)
            {
                try
                {
                    cmd.CommandText = "SELECT Name FROM subject where No='"+(i+1000)+"'";
                    r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        subarr[i] = r.GetString(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                r.Close();
            }
        }

        static void Main()
        {
            new Program();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Switch());
            con.Close();
        }
    }
}
