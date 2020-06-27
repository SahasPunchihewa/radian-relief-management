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
            Relief.classmax();
            Relief.classcount();
            button4.Hide();
            Program.classno = 1001;
            Program.clzno = 1001;
            if(Program.maxclz==Program.classno)
            {
                button2.Hide();
            }
            classshow();
            for(int j=0;j<Program.countc;j++)
            {
                Relief.teacherclear();
                Relief.timeget();
                Relief.abscheck();
                for(int k=0;k<8;k++)
                {
                    Relief.trelupdater();
                }
                Relief.reliefclz();
                Program.classno++;
                Program.clzno++;
                
            }
            textBox1.Text = Program.classname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Relief.teacherclear();
            Relief.timeget();
            Relief.abscheck();
            label12.ForeColor = Color.Black;
            label13.ForeColor = Color.Black;
            label14.ForeColor = Color.Black;
            label15.ForeColor = Color.Black;
            label16.ForeColor = Color.Black;
            label17.ForeColor = Color.Black;
            label18.ForeColor = Color.Black;
            label19.ForeColor = Color.Black;
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
                        label12.ForeColor = Color.Blue;
                    }
                    if (j == 1)
                    {
                        label13.Text = Convert.ToString(Program.reliefarr[j]);
                        label13.ForeColor = Color.Blue;
                    }
                    if (j == 2)
                    {
                        label14.Text = Convert.ToString(Program.reliefarr[j]);
                        label14.ForeColor = Color.Blue;
                    }
                    if (j == 3)
                    {
                        label15.Text = Convert.ToString(Program.reliefarr[j]);
                        label15.ForeColor = Color.Blue;
                    }
                    if (j == 4)
                    {
                        label16.Text = Convert.ToString(Program.reliefarr[j]);
                        label16.ForeColor = Color.Blue;
                    }
                    if (j == 5)
                    {
                        label17.Text = Convert.ToString(Program.reliefarr[j]);
                        label17.ForeColor = Color.Blue;
                    }
                    if (j == 6)
                    {
                        label18.Text = Convert.ToString(Program.reliefarr[j]);
                        label18.ForeColor = Color.Blue;
                    }
                    if (j == 7)
                    {
                        label19.Text = Convert.ToString(Program.reliefarr[j]);
                        label19.ForeColor = Color.Blue;
                    }
                }
                
            }
            Relief.reliefclz();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if((Program.classno+1)==Program.maxclz)
            {
                button2.Hide();
            }
            button4.Show();
            forecolorblack();
            Program.classno++;
            Program.clzno = Program.classno;
            classshow();
            textBox1.Text = Program.classname;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.classname = textBox1.Text;
            Relief.timetablesearch();
            Relief.resetter();
            Relief.classload();
            Relief.teachertime();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if((Program.classno-1)==1001)
            {
                button4.Hide();
            }
            button2.Show();
            forecolorblack();
            Program.classno--;
            Program.clzno = Program.classno;
            classshow();
            textBox1.Text = Program.classname;
        }
        public void forecolorblack()
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
            label20.ForeColor = Color.Black;
            label21.ForeColor = Color.Black;
            label22.ForeColor = Color.Black;
            label23.ForeColor = Color.Black;
            label24.ForeColor = Color.Black;
            label25.ForeColor = Color.Black;
            label26.ForeColor = Color.Black;
            label27.ForeColor = Color.Black;
        }
        public void classshow()
        {
            Relief.resetter();
            Relief.classload();
            Relief.teachertime();
            Relief.redsubshow();
            for (int j = 0; j < 8; j++)
            {
                if (Program.redsub[j] == 0)
                {
                    if (j == 0)
                    {
                        label20.ForeColor = Color.Red;
                    }
                    if (j == 1)
                    {
                        label21.ForeColor = Color.Red;
                    }
                    if (j == 2)
                    {
                        label22.ForeColor = Color.Red;
                    }
                    if (j == 3)
                    {
                        label23.ForeColor = Color.Red;
                    }
                    if (j == 4)
                    {
                        label24.ForeColor = Color.Red;
                    }
                    if (j == 5)
                    {
                        label25.ForeColor = Color.Red;
                    }
                    if (j == 6)
                    {
                        label26.ForeColor = Color.Red;
                    }
                    if (j == 7)
                    {
                        label27.ForeColor = Color.Red;
                    }
                }
            }
            label20.Text = Convert.ToString(Program.tarr[0]);
            label21.Text = Convert.ToString(Program.tarr[1]);
            label22.Text = Convert.ToString(Program.tarr[2]);
            label23.Text = Convert.ToString(Program.tarr[3]);
            label24.Text = Convert.ToString(Program.tarr[4]);
            label25.Text = Convert.ToString(Program.tarr[5]);
            label26.Text = Convert.ToString(Program.tarr[6]);
            label27.Text = Convert.ToString(Program.tarr[7]);
        }
    }
}
