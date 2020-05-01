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
                    if(j==0)
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
            }
        }
    }
}
