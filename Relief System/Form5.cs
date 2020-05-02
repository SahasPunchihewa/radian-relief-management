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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            Program.classno = 1001;
            Program.clzno = 1001;
            Relief.resetter();
            Relief.classload();
            Relief.teachertime();
            label1.Text = Program.classname;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Relief.timeget();
            Relief.abscheck();
            for (int j = 0;j< 8;j++)
            {
                if(Program.testarr[j]!=0)
                {
                    Program.newt[j] = Program.testarr[j];
                    if (j == 0)
                    {
                        label12.Text = Convert.ToString(Program.testarr[j]);
                    }
                    if (j == 1)
                    {
                        label13.Text = Convert.ToString(Program.testarr[j]);
                    }
                    if (j == 2)
                    {
                        label14.Text = Convert.ToString(Program.testarr[j]);
                    }
                    if (j == 3)
                    {
                        label15.Text = Convert.ToString(Program.testarr[j]);
                    }
                    if (j == 4)
                    {
                        label16.Text = Convert.ToString(Program.testarr[j]);
                    }
                    if (j == 5)
                    {
                        label17.Text = Convert.ToString(Program.testarr[j]);
                    }
                    if (j == 6)
                    {
                        label18.Text = Convert.ToString(Program.testarr[j]);
                    }
                    if (j == 7)
                    {
                        label19.Text = Convert.ToString(Program.testarr[j]);
                    }
                }
                else
                {
                    Program.newt[j] = Program.reliefarr[j];
                    if (j == 0)
                    {
                        label12.Text = Convert.ToString(Program.reliefarr[j]);
                        label12.ForeColor = Color.Red;
                    }
                    if (j == 1)
                    {
                        label13.Text = Convert.ToString(Program.reliefarr[j]);
                        label13.ForeColor = Color.Red;
                    }
                    if (j == 2)
                    {
                        label14.Text = Convert.ToString(Program.reliefarr[j]);
                        label14.ForeColor = Color.Red;
                    }
                    if (j == 3)
                    {
                        label15.Text = Convert.ToString(Program.reliefarr[j]);
                        label15.ForeColor = Color.Red;
                    }
                    if (j == 4)
                    {
                        label16.Text = Convert.ToString(Program.reliefarr[j]);
                        label16.ForeColor = Color.Red;
                    }
                    if (j == 5)
                    {
                        label17.Text = Convert.ToString(Program.reliefarr[j]);
                        label17.ForeColor = Color.Red;
                    }
                    if (j == 6)
                    {
                        label18.Text = Convert.ToString(Program.reliefarr[j]);
                        label18.ForeColor = Color.Red;
                    }
                    if (j == 7)
                    {
                        label19.Text = Convert.ToString(Program.reliefarr[j]);
                        label19.ForeColor = Color.Red;
                    }
                }
                Relief.trelupdater();
            }
            Relief.reliefclz();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label12.ForeColor = Color.Black;
            label13.ForeColor = Color.Black;
            label14.ForeColor = Color.Black;
            label15.ForeColor = Color.Black;
            label16.ForeColor = Color.Black;
            label17.ForeColor = Color.Black;
            label18.ForeColor = Color.Black;
            label19.ForeColor = Color.Black;
            Program.classno++;
            Program.clzno = Program.classno;
            Relief.resetter();
            Relief.classload();
            Relief.teachertime();
            label1.Text = Program.classname;
        }
    }
}
