using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relief_System
{

    public partial class Form1 : Form
    {
        static int tno;
        static String tname, sec;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tno = 1001;
            tname = textBox1.Text;
            sec = textBox2.Text;
            MessageBox.Show("Hellow\n"+tno+"\n"+tname+"\n"+sec);
        }
    }
}
