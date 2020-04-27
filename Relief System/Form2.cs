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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Program.tno = 1001;
            Teacher.nameload();
            label1.Text = Program.tname;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Program.present = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Program.present = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher.register();
            Program.tno++;
            Teacher.nameload();
            label1.Text = Program.tname;
        }
    }
}
