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
            Program.tindex[0] = comboBox1.SelectedIndex;
            Program.tindex[1] = comboBox2.SelectedIndex;
            Program.tindex[2] = comboBox3.SelectedIndex;
            Program.tindex[3] = comboBox4.SelectedIndex;
            Program.tindex[4] = comboBox5.SelectedIndex;
            Program.tindex[5] = comboBox6.SelectedIndex;
            Program.tindex[6] = comboBox7.SelectedIndex;
            Program.tindex[7] = comboBox8.SelectedIndex;
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
            comboBox1.DataSource = null;
            comboBox2.DataSource = null;
            comboBox3.DataSource = null;
            comboBox4.DataSource = null;
            comboBox5.DataSource = null;
            comboBox6.DataSource = null;
            comboBox7.DataSource = null;
            comboBox8.DataSource = null;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Program.timearr[0] = Convert.ToInt32(textBox2.Text) + 1000;
                Program.subno = Convert.ToInt32(textBox2.Text) + 1000;
                Program.t1.Clear();
                Program.tn1.Clear();
                Program.timet = "One";
                Timetable.subnameload();
                Timetable.tloadone();
                comboBox1.DataSource = Program.tn1;
            }
            catch(Exception)
            {
                Program.t1.Clear();
                Program.tn1.Clear();
                comboBox1.DataSource = null;
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Program.timearr[1] = Convert.ToInt32(textBox3.Text) + 1000;
                Program.subno = Convert.ToInt32(textBox3.Text) + 1000;
                Program.t2.Clear();
                Program.tn2.Clear();
                Program.timet = "Two";
                Timetable.subnameload();
                Timetable.tloadone();
                comboBox2.DataSource = Program.tn2;
            }
            catch (Exception)
            {
                Program.t2.Clear();
                Program.tn2.Clear();
                comboBox2.DataSource = null;
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Program.timearr[2] = Convert.ToInt32(textBox4.Text) + 1000;
                Program.subno = Convert.ToInt32(textBox4.Text) + 1000;
                Program.t3.Clear();
                Program.tn3.Clear();
                Program.timet = "Three";
                Timetable.subnameload();
                Timetable.tloadone();
                comboBox3.DataSource = Program.tn3;
            }
            catch (Exception)
            {
                Program.t3.Clear();
                Program.tn3.Clear();
                comboBox3.DataSource = null;
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            try
            {
                Program.timearr[3] = Convert.ToInt32(textBox5.Text) + 1000;
                Program.subno = Convert.ToInt32(textBox5.Text) + 1000;
                Program.t4.Clear();
                Program.tn4.Clear();
                Program.timet = "Four";
                Timetable.subnameload();
                Timetable.tloadone();
                comboBox4.DataSource = Program.tn4;
            }
            catch (Exception)
            {
                Program.t4.Clear();
                Program.tn4.Clear();
                comboBox4.DataSource = null;
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Program.timearr[4] = Convert.ToInt32(textBox6.Text) + 1000;
                Program.subno = Convert.ToInt32(textBox6.Text) + 1000;
                Program.t5.Clear();
                Program.tn5.Clear();
                Program.timet = "Five";
                Timetable.subnameload();
                Timetable.tloadone();
                comboBox5.DataSource = Program.tn5;
            }
            catch (Exception)
            {
                Program.t5.Clear();
                Program.tn5.Clear();
                comboBox5.DataSource = null;
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Program.timearr[5] = Convert.ToInt32(textBox7.Text) + 1000;
                Program.subno = Convert.ToInt32(textBox7.Text) + 1000;
                Program.t6.Clear();
                Program.tn6.Clear();
                Program.timet = "Six";
                Timetable.subnameload();
                Timetable.tloadone();
                comboBox6.DataSource = Program.tn6;
            }
            catch (Exception)
            {
                Program.t6.Clear();
                Program.tn6.Clear();
                comboBox6.DataSource = null;
            }
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Program.timearr[6] = Convert.ToInt32(textBox8.Text) + 1000;
                Program.subno = Convert.ToInt32(textBox8.Text) + 1000;
                Program.t7.Clear();
                Program.tn7.Clear();
                Program.timet = "Seven";
                Timetable.subnameload();
                Timetable.tloadone();
                comboBox7.DataSource = Program.tn7;
            }
            catch (Exception)
            {
                Program.t7.Clear();
                Program.tn7.Clear();
                comboBox7.DataSource = null;
            }
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Program.timearr[7] = Convert.ToInt32(textBox9.Text) + 1000;
                Program.subno = Convert.ToInt32(textBox9.Text) + 1000;
                Program.t8.Clear();
                Program.tn8.Clear();
                Program.timet = "Eight";
                Timetable.subnameload();
                Timetable.tloadone();
                comboBox8.DataSource = Program.tn8;
            }
            catch (Exception)
            {
                Program.t8.Clear();
                Program.tn8.Clear();
                comboBox8.DataSource = null;
            }
        }
    }
}
