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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Program.classno = 1001;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.classname = textBox1.Text;
            Program.timearr[0] = Convert.ToInt32(textBox2.Text) + 1000;
            Program.timearr[1] = Convert.ToInt32(textBox3.Text) + 1000;
            Program.timearr[2] = Convert.ToInt32(textBox4.Text) + 1000;
            Program.timearr[3] = Convert.ToInt32(textBox5.Text) + 1000;
            Program.timearr[4] = Convert.ToInt32(textBox6.Text) + 1000;
            Program.timearr[5] = Convert.ToInt32(textBox7.Text) + 1000;
            Program.timearr[6] = Convert.ToInt32(textBox8.Text) + 1000;
            Program.timearr[7] = Convert.ToInt32(textBox9.Text) + 1000;
            Program.time2arr[0] = Convert.ToInt32(textBox10.Text) + 1000;
            Program.time2arr[1] = Convert.ToInt32(textBox11.Text) + 1000;
            Program.time2arr[2] = Convert.ToInt32(textBox12.Text) + 1000;
            Program.time2arr[3] = Convert.ToInt32(textBox13.Text) + 1000;
            Program.time2arr[4] = Convert.ToInt32(textBox14.Text) + 1000;
            Program.time2arr[5] = Convert.ToInt32(textBox15.Text) + 1000;
            Program.time2arr[6] = Convert.ToInt32(textBox16.Text) + 1000;
            Program.time2arr[7] = Convert.ToInt32(textBox17.Text) + 1000;
            Timetable.timeadd();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text.Length==4)
            {
                MessageBox.Show("retrr");
            }
            
        }
    }
}
