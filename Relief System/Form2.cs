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
            label2.Text = Program.tname;
            textBox1.Text = Program.tid;
            button3.Hide();
            Teacher.maxfind();
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
            button3.Show();
            Teacher.register();
            if(Program.tno<Program.maxno)
            {
                Program.tno++;
                Teacher.nameload();
                label2.Text = Program.tname;
                textBox1.Text = Program.tid;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Program.tid = textBox1.Text;
            Teacher.nameloadtid();
            label2.Text = Program.tname;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Show();
            if(Program.tno>1001)
            {
                Program.tno--;
                Teacher.nameload();
                label2.Text = Program.tname;
                textBox1.Text = Program.tid;
            }
            if(Program.tno==1001)
            {
                button3.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Show();
            /*if (Program.tno > 1001)
            {*/
            Program.tno++;
            Teacher.nameload();
            label2.Text = Program.tname;
            textBox1.Text = Program.tid;
            if(Program.tno==Program.maxno)
            {
                button4.Hide();
            }
            //}
        }
    }
}
