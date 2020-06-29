using System;
using System.Drawing;
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
            textBox1.Text = Program.classname;
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
            if(textBox1.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Valied Class !");
            }
            else
            {
                Program.classname = textBox1.Text;
                Relief.timetablesearch();
                Relief.resetter();
                Relief.classload();
                Relief.teachertime();
            }
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
            label12.ForeColor = Color.White;
            label13.ForeColor = Color.White;
            label14.ForeColor = Color.White;
            label15.ForeColor = Color.White;
            label16.ForeColor = Color.White;
            label17.ForeColor = Color.White;
            label18.ForeColor = Color.White;
            label19.ForeColor = Color.White;
            label20.ForeColor = Color.White;
            label21.ForeColor = Color.White;
            label22.ForeColor = Color.White;
            label23.ForeColor = Color.White;
            label24.ForeColor = Color.White;
            label25.ForeColor = Color.White;
            label26.ForeColor = Color.White;
            label27.ForeColor = Color.White;
            for(int j=0;j<8;j++)
            {
                Program.bluesub[j] = 0;
            }
        }
        public void classshow()
        {
            Relief.resetter();
            Relief.classload();
            Relief.teachertime();
            Relief.relieftime();
            Relief.redsubshow();
            Relief.bluesubshow();
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
                if(Program.bluesub[j]==1)
                {
                    if (j == 0)
                    {
                        label12.ForeColor = Color.Blue;
                    }
                    if (j == 1)
                    {
                        label13.ForeColor = Color.Blue;
                    }
                    if (j == 2)
                    {
                        label14.ForeColor = Color.Blue;
                    }
                    if (j == 3)
                    {
                        label15.ForeColor = Color.Blue;
                    }
                    if (j == 4)
                    {
                        label16.ForeColor = Color.Blue;
                    }
                    if (j == 5)
                    {
                        label17.ForeColor = Color.Blue;
                    }
                    if (j == 6)
                    {
                        label18.ForeColor = Color.Blue;
                    }
                    if (j == 7)
                    {
                        label19.ForeColor = Color.Blue;
                    }
                }
            }
            label12.Text = Convert.ToString(Program.rarr[0]);
            label13.Text = Convert.ToString(Program.rarr[1]);
            label14.Text = Convert.ToString(Program.rarr[2]);
            label15.Text = Convert.ToString(Program.rarr[3]);
            label16.Text = Convert.ToString(Program.rarr[4]);
            label17.Text = Convert.ToString(Program.rarr[5]);
            label18.Text = Convert.ToString(Program.rarr[6]);
            label19.Text = Convert.ToString(Program.rarr[7]);
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
