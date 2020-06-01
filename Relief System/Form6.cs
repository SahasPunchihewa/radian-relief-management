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
            Teacher.seccheck();
            Program.sec = textBox1.Text;
            if (Program.secc==1)
            {
                Teacher.secupdate();
            }
            else
            {
                Teacher.secadder();
            }
            textBox1.Text = "";
            label2.Text = "";
            Program.sec = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a Name To Search !");
            }
            else
            {
                Program.sec = textBox1.Text;
                Teacher.secsearch();
                if(Program.secno==0)
                {
                    MessageBox.Show("Cannot Find Any Record For Section Name " + Program.sec);
                }
                else
                {
                    label2.Text="Record Found, You can Edit Section Name";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.sec = textBox1.Text;
            Teacher.secdelete();
            textBox1.Text = "";
            label2.Text = "";
            Program.sec = "";
        }
    }
}
