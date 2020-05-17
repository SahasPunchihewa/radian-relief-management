using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Relief_System
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            Program.secno = 1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.sec = textBox1.Text;
            Teacher.secadder();
            textBox1.Text = "";
        }
    }
}
