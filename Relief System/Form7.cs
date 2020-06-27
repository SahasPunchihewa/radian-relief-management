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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            Relief.classmax();
            Relief.classcount();
            button4.Hide();
            Program.classno = 1001;
            Program.clzno = 1001;
            for (int j = 0; j < Program.countc; j++)
            {
                Relief.classload();
                Relief.teacherclear();
                Relief.timeget();
                Relief.abscheck();
                Relief.teachertime();
                for (int k = 0; k < 8; k++)
                {
                    if (Program.testarr[k] != 0)
                    {
                        Program.newt[k] = Program.testarr[k];
                    }
                    else
                    {
                        Program.newt[k] = Program.reliefarr[k];
                    }
                        Relief.trelupdater();
                }
                Relief.reliefclz();
                Program.classno++;
                Program.clzno = Program.classno;
            }
            for (int k = 0; k < 8; k++)
            {
                Program.newt[k] = 0;
                Program.testarr[k]=0;
                Program.reliefarr[k]=0;
            }

            labelclear();
            Program.relindex = 0;
            shower();
            button1.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
        }
        public void labelseter()
        {
            label1.Text = "Relief For " + Program.al6[Program.relindex];
            for(int j=0;j<8;j++)
            {
                if(Program.trelp[j]>2000)
                {
                    if (j == 0)
                    {
                        label12.Text = Convert.ToString(Program.trelp[j]);
                    }
                    if (j == 1)
                    {
                        label13.Text = Convert.ToString(Program.trelp[j]);
                    }
                    if (j == 2)
                    {
                        label14.Text = Convert.ToString(Program.trelp[j]);
                    }
                    if (j == 3)
                    {
                        label15.Text = Convert.ToString(Program.trelp[j]);
                    }
                    if (j == 4)
                    {
                        label16.Text = Convert.ToString(Program.trelp[j]);
                    }
                    if (j == 5)
                    {
                        label17.Text = Convert.ToString(Program.trelp[j]);
                    }
                    if (j == 6)
                    {
                        label18.Text = Convert.ToString(Program.trelp[j]);
                    }
                    if (j == 7)
                    {
                        label19.Text = Convert.ToString(Program.trelp[j]);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.relindex++;
            shower();
            button1.Show();
            if(Program.relindex==(Program.al5.Count-1))
            {
                button2.Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.relindex--;
            shower();
            button2.Show();
            if(Program.relindex==0)
            {
                button1.Hide();
            }
        }
        public void shower()
        {
            Teacher.clear7();
            labelclear();
            Teacher.loadrel();
            Teacher.reltime();
            labelseter();
            if (Program.al5.Count == 1)
            {
                button2.Hide();
            }
        }
        public void labelclear()
        {
            label12.Text = "-";
            label13.Text = "-";
            label14.Text = "-";
            label15.Text = "-";
            label16.Text = "-";
            label17.Text = "-";
            label18.Text = "-";
            label19.Text = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.tid = textBox1.Text;
            Teacher.relsearch();
            shower();
            button2.Show();
            if (Program.relindex == 0)
            {
                button1.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.relprinter[0] = label12.Text;
            Program.relprinter[1] = label13.Text;
            Program.relprinter[2] = label14.Text;
            Program.relprinter[3] = label15.Text;
            Program.relprinter[4] = label16.Text;
            Program.relprinter[5] = label17.Text;
            Program.relprinter[6] = label18.Text;
            Program.relprinter[7] = label19.Text;
            Program.textname = label1.Text;
            TextPrint.pdfsettings();
            TextPrint.reliefprint();
            
        }
    }
}
