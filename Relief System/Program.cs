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
        public static int tno,present=0,subno,classno=0,rtmp,i,clzno,ca=0,date;
        public static String tname, sec,subname,sqlaltetable,classname,relno,sqlcmd;
        public static MySqlDataReader r;
        public static int[] timearr = new int[8];
        public static int[] testarr = new int[8];
        public static int[] reliefarr = new int[8];
        public static int[] tarr = new int[8];
        public static int[] newt = new int[8];
        public static ArrayList al1,al2;
        public static int[] subarr;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public Program()
        {
            
            for(i=0;i<8;i++)
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
            Teacher.subload();
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
