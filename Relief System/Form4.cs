﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Relief_System
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Program.classno = 1001;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.classname = textBox1.Text;
            Program.timearr[0] = Convert.ToInt32(textBox2.Text) + 1000;
            Program.timearr[1] = Convert.ToInt32(textBox3.Text) + 1000;
            Program.timearr[2] = Convert.ToInt32(textBox4.Text) + 1000;
            Program.timearr[3] = Convert.ToInt32(textBox5.Text) + 1000;
            Program.timearr[4] = Convert.ToInt32(textBox6.Text) + 1000;
            Program.timearr[5] = Convert.ToInt32(textBox7.Text) + 1000;
            Program.timearr[6] = Convert.ToInt32(textBox8.Text) + 1000;
            Program.timearr[7] = Convert.ToInt32(textBox9.Text) + 1000;
            Timetable.timeadd();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }
    }
}
