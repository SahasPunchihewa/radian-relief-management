using System;
using System.Collections.Generic;
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
        public static int tno,present=0,subno,classno=0,rtmp,i,clzno,ca=0;
        public static String tname, sec,subname,sqlaltetable,classname;
        public static MySqlDataReader r;
        public static int[] timearr = new int[8];
        public static int[] testarr = new int[8];
        public static int[] reliefarr = new int[8];
        public static int[] tarr = new int[8];

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
