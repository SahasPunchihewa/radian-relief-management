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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Program.subno = 1001;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.subname = textBox1.Text;
            Subject.subadd();
            textBox1.Text = "";
        }
    }
}
