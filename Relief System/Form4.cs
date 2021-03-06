﻿using System;
using System.Windows.Forms;

namespace Relief_System
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Program.classno = 1001;
            Subject.maxfindsub();
            Program.maxsub = Program.maxsub - 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a name for the class!");
            }
            else if (textBox2.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a subject number for the 1st period!");
            }
            else if (textBox3.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a subject number for the 2nd period!");
            }
            else if (textBox4.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a subject number for the 3rd period!");
            }
            else if (textBox5.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a subject number for the 4th period!");
            }
            else if (textBox6.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a subject number for the 5th period!");
            }
            else if (textBox7.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a subject number for the 6th period!");
            }
            else if (textBox8.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a subject number for the 7th period!");
            }
            else if (textBox9.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a subject number for the 8th period!");
            }
            else
            {
                Program.classname =(textBox1.Text).ToUpper();
                Program.classname = Program.rgx.Replace(Program.classname, "");
                Console.WriteLine(Program.classname);
                Timetable.cnamecheck();
                if (Program.nameup == 0)
                {
                    Program.tindex[0] = comboBox1.SelectedIndex;
                    Program.tindex[1] = comboBox2.SelectedIndex;
                    Program.tindex[2] = comboBox3.SelectedIndex;
                    Program.tindex[3] = comboBox4.SelectedIndex;
                    Program.tindex[4] = comboBox5.SelectedIndex;
                    Program.tindex[5] = comboBox6.SelectedIndex;
                    Program.tindex[6] = comboBox7.SelectedIndex;
                    Program.tindex[7] = comboBox8.SelectedIndex;

                    if(comboBox1.DataSource==null)
                    {
                        MessageBox.Show("Please Select a teacher for the 1st period!");
                    }
                    else if (comboBox2.DataSource == null)
                    {
                        MessageBox.Show("Please Select a teacher for the 2nd period!");
                    }
                    else if (comboBox3.DataSource == null)
                    {
                        MessageBox.Show("Please Select a teacher for the 3rd period!");
                    }
                    else if (comboBox4.DataSource == null)
                    {
                        MessageBox.Show("Please Select a teacher for the 4th period!");
                    }
                    else if (comboBox5.DataSource == null)
                    {
                        MessageBox.Show("Please Select a teacher for the 5th period!");
                    }
                    else if (comboBox6.DataSource == null)
                    {
                        MessageBox.Show("Please Select a teacher for the 6th period!");
                    }
                    else if (comboBox7.DataSource == null)
                    {
                        MessageBox.Show("Please Select a teacher for the 7th period!");
                    }
                    else if (comboBox8.DataSource == null)
                    {
                        MessageBox.Show("Please Select a teacher for the 8th period!");
                    }
                    else
                    {
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
                        Program.classname = "";
                    }
                }
                else
                {
                    MessageBox.Show("This class is exisiting try anothe name!");
                }
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox2.Text) <= Program.maxsub)
                {
                    try
                    {
                        Program.timearr[0] = Convert.ToInt32(textBox2.Text) + 1000;
                        Program.subno = Convert.ToInt32(textBox2.Text) + 1000;
                        Program.timet = "One";
                        Timetable.subnameload();
                        Program.t1.Clear();
                        Program.tn1.Clear();
                        Timetable.tloadone();
                        comboBox1.DataSource = null;
                        comboBox1.DataSource = Program.tn1;
                        comboBox1.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Program.t1.Clear();
                        Program.tn1.Clear();
                        comboBox1.DataSource = null;
                    }
                }
                else
                {
                    Program.t1.Clear();
                    Program.tn1.Clear();
                    comboBox1.DataSource = null;
                    MessageBox.Show("Please Enter Valied Subject No");
                }
            }
            catch(Exception ex)
            {
                if(!textBox2.Text.Equals(""))
                {
                    Console.WriteLine(ex.Message);
                    Program.t1.Clear();
                    Program.tn1.Clear();
                    comboBox1.DataSource = null;
                    MessageBox.Show("Please Enter Valied Subject No");
                }
            }
            
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox3.Text) <= Program.maxsub)
                {
                    try
                    {
                        Program.timearr[1] = Convert.ToInt32(textBox3.Text) + 1000;
                        Program.subno = Convert.ToInt32(textBox3.Text) + 1000;
                        Program.timet = "Two";
                        Timetable.subnameload();
                        Program.t2.Clear();
                        Program.tn2.Clear();
                        Timetable.tloadone();
                        comboBox2.DataSource = null;
                        comboBox2.DataSource = Program.tn2;
                        comboBox2.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Program.t2.Clear();
                        Program.tn2.Clear();
                        comboBox2.DataSource = null;
                    }
                }
                else
                {
                    Program.t2.Clear();
                    Program.tn2.Clear();
                    comboBox2.DataSource = null;
                    MessageBox.Show("Please Enter Valied Subject No");
                }
            }
            catch (Exception ex)
            {
                if (!textBox3.Text.Equals(""))
                {
                    Console.WriteLine(ex.Message);
                    Program.t2.Clear();
                    Program.tn2.Clear();
                    comboBox2.DataSource = null;
                    MessageBox.Show("Please Enter Valied Subject No");
                }
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox4.Text) <= Program.maxsub)
                {
                    try
                    {
                        Program.timearr[2] = Convert.ToInt32(textBox4.Text) + 1000;
                        Program.subno = Convert.ToInt32(textBox4.Text) + 1000;
                        Program.timet = "Three";
                        Timetable.subnameload();
                        Program.t3.Clear();
                        Program.tn3.Clear();
                        Timetable.tloadone();
                        comboBox3.DataSource = null;
                        comboBox3.DataSource = Program.tn3;
                        comboBox3.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Program.t3.Clear();
                        Program.tn3.Clear();
                        comboBox3.DataSource = null;
                    }
                }
                else
                {
                    Program.t3.Clear();
                    Program.tn3.Clear();
                    comboBox3.DataSource = null;
                    MessageBox.Show("Please Enter Valied Subject No");
                }
            }
            catch (Exception ex)
            {
                if (!textBox4.Text.Equals(""))
                {
                    Console.WriteLine(ex.Message);
                    Program.t3.Clear();
                    Program.tn3.Clear();
                    comboBox3.DataSource = null;
                    MessageBox.Show("Please Enter Valied Subject No");
                }
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox5.Text) <= Program.maxsub)
                {
                    try
                    {
                        Program.timearr[3] = Convert.ToInt32(textBox5.Text) + 1000;
                        Program.subno = Convert.ToInt32(textBox5.Text) + 1000;
                        Program.timet = "Four";
                        Timetable.subnameload();
                        Program.t4.Clear();
                        Program.tn4.Clear();
                        Timetable.tloadone();
                        comboBox4.DataSource = null;
                        comboBox4.DataSource = Program.tn4;
                        comboBox4.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Program.t4.Clear();
                        Program.tn4.Clear();
                        comboBox4.DataSource = null;
                    }
                }
                else
                {
                    Program.t4.Clear();
                    Program.tn4.Clear();
                    comboBox4.DataSource = null;
                    MessageBox.Show("Please Enter Valied Subject No");
                }
            }
            catch (Exception ex)
            {
                if (!textBox5.Text.Equals(""))
                {
                    Console.WriteLine(ex.Message);
                    Program.t4.Clear();
                    Program.tn4.Clear();
                    comboBox4.DataSource = null;
                    MessageBox.Show("Please Enter Valied Subject No");
                }
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox6.Text) <= Program.maxsub)
                {
                    try
                    {
                        Program.timearr[4] = Convert.ToInt32(textBox6.Text) + 1000;
                        Program.subno = Convert.ToInt32(textBox6.Text) + 1000;
                        Program.timet = "Five";
                        Timetable.subnameload();
                        Program.t5.Clear();
                        Program.tn5.Clear();
                        Timetable.tloadone();
                        comboBox5.DataSource = null;
                        comboBox5.DataSource = Program.tn5;
                        comboBox5.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Program.t5.Clear();
                        Program.tn5.Clear();
                        comboBox5.DataSource = null;
                    }
                }
                else
                {
                    Program.t5.Clear();
                    Program.tn5.Clear();
                    comboBox5.DataSource = null;
                    MessageBox.Show("Please Enter Valied Subject No");
                }
            }
            catch (Exception ex)
            {
                if (!textBox6.Text.Equals(""))
                {
                    Console.WriteLine(ex.Message);
                    Program.t5.Clear();
                    Program.tn5.Clear();
                    comboBox5.DataSource = null;
                    MessageBox.Show("Please Enter Valied Subject No");
                }
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox7.Text) <= Program.maxsub)
                {
                    try
                    {
                        Program.timearr[5] = Convert.ToInt32(textBox7.Text) + 1000;
                        Program.subno = Convert.ToInt32(textBox7.Text) + 1000;
                        Program.timet = "Six";
                        Timetable.subnameload();
                        Program.t6.Clear();
                        Program.tn6.Clear();
                        Timetable.tloadone();
                        comboBox6.DataSource = null;
                        comboBox6.DataSource = Program.tn6;
                        comboBox6.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Program.t6.Clear();
                        Program.tn6.Clear();
                        comboBox6.DataSource = null;
                    }
                }
                else
                {
                    Program.t6.Clear();
                    Program.tn6.Clear();
                    comboBox6.DataSource = null;
                    MessageBox.Show("Please Enter Valied Subject No");
                }
            }
            catch (Exception ex)
            {
                if (!textBox7.Text.Equals(""))
                {
                    Console.WriteLine(ex.Message);
                    Program.t6.Clear();
                    Program.tn6.Clear();
                    comboBox6.DataSource = null;
                    MessageBox.Show("Please Enter Valied Subject No");
                }
            }
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox8.Text) <= Program.maxsub)
                {
                    try
                    {
                        Program.timearr[6] = Convert.ToInt32(textBox8.Text) + 1000;
                        Program.subno = Convert.ToInt32(textBox8.Text) + 1000;
                        Program.timet = "Seven";
                        Timetable.subnameload();
                        Program.t7.Clear();
                        Program.tn7.Clear();
                        Timetable.tloadone();
                        comboBox7.DataSource = null;
                        comboBox7.DataSource = Program.tn7;
                        comboBox7.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Program.t7.Clear();
                        Program.tn7.Clear();
                        comboBox7.DataSource = null;
                    }
                }
                else
                {
                    Program.t7.Clear();
                    Program.tn7.Clear();
                    comboBox7.DataSource = null;
                    MessageBox.Show("Please Enter Valied Subject No");
                }
            }
            catch (Exception ex)
            {
                if (!textBox8.Text.Equals(""))
                {
                    Console.WriteLine(ex.Message);
                    Program.t7.Clear();
                    Program.tn7.Clear();
                    comboBox7.DataSource = null;
                    MessageBox.Show("Please Enter Valied Subject No");
                }
            }
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox9.Text) <= Program.maxsub)
                {
                    try
                    {
                        Program.timearr[7] = Convert.ToInt32(textBox9.Text) + 1000;
                        Program.subno = Convert.ToInt32(textBox9.Text) + 1000;
                        Program.timet = "Eight";
                        Timetable.subnameload();
                        Program.t8.Clear();
                        Program.tn8.Clear();
                        Timetable.tloadone();
                        comboBox8.DataSource = null;
                        comboBox8.DataSource = Program.tn8;
                        comboBox8.SelectedIndex = 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Program.t8.Clear();
                        Program.tn8.Clear();
                        comboBox8.DataSource = null;
                    }
                }
                else
                {
                    Program.t8.Clear();
                    Program.tn8.Clear();
                    comboBox8.DataSource = null;
                    MessageBox.Show("Please Enter Valied Subject No");
                }
            }
            catch (Exception ex)
            {
                if (!textBox9.Text.Equals(""))
                {
                    Console.WriteLine(ex.Message);
                    Program.t8.Clear();
                    Program.tn8.Clear();
                    comboBox8.DataSource = null;
                    MessageBox.Show("Please Enter Valied Subject No");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Valied Class Name !");
            }
            else
            {
                Program.classname = textBox1.Text;
                Timetable.timesearch();
                textBox2.Text = Convert.ToString(Program.timearr[0] - 1000);
                textBox3.Text = Convert.ToString(Program.timearr[1] - 1000);
                textBox4.Text = Convert.ToString(Program.timearr[2] - 1000);
                textBox5.Text = Convert.ToString(Program.timearr[3] - 1000);
                textBox6.Text = Convert.ToString(Program.timearr[4] - 1000);
                textBox7.Text = Convert.ToString(Program.timearr[5] - 1000);
                textBox8.Text = Convert.ToString(Program.timearr[6] - 1000);
                textBox9.Text = Convert.ToString(Program.timearr[7] - 1000);
                comboBox1.DataSource = null;
                comboBox2.DataSource = null;
                comboBox3.DataSource = null;
                comboBox4.DataSource = null;
                comboBox5.DataSource = null;
                comboBox6.DataSource = null;
                comboBox7.DataSource = null;
                comboBox8.DataSource = null;
                Program.tn1.Clear();
                Program.tn2.Clear();
                Program.tn3.Clear();
                Program.tn4.Clear();
                Program.tn5.Clear();
                Program.tn6.Clear();
                Program.tn7.Clear();
                Program.tn8.Clear();
                Program.tn1.Add(Program.tnames[0]);
                Program.tn2.Add(Program.tnames[1]);
                Program.tn3.Add(Program.tnames[2]);
                Program.tn4.Add(Program.tnames[3]);
                Program.tn5.Add(Program.tnames[4]);
                Program.tn6.Add(Program.tnames[5]);
                Program.tn7.Add(Program.tnames[6]);
                Program.tn8.Add(Program.tnames[7]);
                Program.t1.Clear();
                Program.t2.Clear();
                Program.t3.Clear();
                Program.t4.Clear();
                Program.t5.Clear();
                Program.t6.Clear();
                Program.t7.Clear();
                Program.t8.Clear();
                Program.t1.Add(Program.time2arr[0]);
                Program.t2.Add(Program.time2arr[1]);
                Program.t3.Add(Program.time2arr[2]);
                Program.t4.Add(Program.time2arr[3]);
                Program.t5.Add(Program.time2arr[4]);
                Program.t6.Add(Program.time2arr[5]);
                Program.t7.Add(Program.time2arr[6]);
                Program.t8.Add(Program.time2arr[7]);
                comboBox1.DataSource = Program.tn1;
                comboBox2.DataSource = Program.tn2;
                comboBox3.DataSource = Program.tn3;
                comboBox4.DataSource = Program.tn4;
                comboBox5.DataSource = Program.tn5;
                comboBox6.DataSource = Program.tn6;
                comboBox7.DataSource = Program.tn7;
                comboBox8.DataSource = Program.tn8;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Timetable.timedelete();
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
            Program.t1.Clear();
            Program.t2.Clear();
            Program.t3.Clear();
            Program.t4.Clear();
            Program.t5.Clear();
            Program.t6.Clear();
            Program.t7.Clear();
            Program.t8.Clear();
            Program.tn1.Clear();
            Program.tn2.Clear();
            Program.tn3.Clear();
            Program.tn4.Clear();
            Program.tn5.Clear();
            Program.tn6.Clear();
            Program.tn7.Clear();
            Program.tn8.Clear();
            Program.classname = "";
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
