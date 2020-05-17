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
        public static int tno,present=0,subno,classno=0,rtmp,i,clzno,ca=0,date,ransub=0,subcount,niccheck;
        public static String tname, sec,subname,sqlaltetable,classname,relno,sqlcmd,nic;
        public static MySqlDataReader r;
        public static int[] timearr = new int[8];
        public static int[] time2arr = new int[8];
        public static int[] tsubarr = new int[8];
        public static int[] testarr = new int[8];
        public static int[] reliefarr = new int[8];
        public static int[] tarr = new int[8];
        public static int[] newt = new int[8];
        public static ArrayList al1,al2,al3;
        public static String[] subarr;
        public static String[] time = new string[8];

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
