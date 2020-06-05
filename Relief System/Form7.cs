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
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Teacher.clear7();
            Teacher.loadrel();
            Teacher.reltime();
            labelseter();

        }
        public void labelseter()
        {
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
    }
}
