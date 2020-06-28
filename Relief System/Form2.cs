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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registermark();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                registermark();
            }
        }
        public void registermark()
        {
            Program.tid = textBox1.Text;
            Teacher.nameload();
            if(Program.nc==1)
            {
                Program.res = MessageBox.Show("Are You Sure To Mark " + Program.tname + " As Present ?", "Register", MessageBoxButtons.YesNo);
                if (Program.res == DialogResult.Yes)
                {
                    Teacher.register();
                    textBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please Enter a valied TeacherID");
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }
    }
}
