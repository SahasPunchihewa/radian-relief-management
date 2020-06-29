using System;
using System.Windows.Forms;

namespace Relief_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Program.subno = 1001;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Subject Name !");
            }
            else
            {
                Program.subname = textBox2.Text;
                if (textBox1.Text.Equals(""))
                {
                    Subject.subadd();
                }
                else
                {
                    Program.subno = Convert.ToInt32(textBox1.Text);
                    Subject.oldsubget();
                    Subject.subupdate();
                }
                textBox2.Text = "";
                textBox1.Text = "";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Subject Number !");
            }
            Program.subno = Convert.ToInt32(textBox1.Text);
            Subject.subfind();
            textBox2.Text = Program.subname;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Subject.subdelete();
            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            Program.subno = 0;
            Program.subname = "";
        }
    }
}
