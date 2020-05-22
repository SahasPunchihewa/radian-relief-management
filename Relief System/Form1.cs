using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Relief_System
{

    public partial class Form1 :Form
    {
        public Form1()
        {
            InitializeComponent();
            Program.tno = 1001;
            checkedListBox1.Items.Clear();
            Program.al1.Clear();
            Program.al2.Clear();
            Program.al4.Clear();
            Program.al4.Add("- Select One -");
            Teacher.secload();
            Teacher.subload();
            for (int j=14;j<Program.al1.Count;j++)
            {
                checkedListBox1.Items.Add(Program.al1[j]);
            }
            comboBox1.DataSource = Program.al4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.checktest = 0;
            Teacher.nicchecked();
            Program.tname = textBox2.Text;
            Program.tid = textBox1.Text;
            Program.tpno = textBox3.Text;
            for (int j = 0; j < (Program.al1.Count - 14); j++)
            {
                try
                {
                    Program.al2[j] = 0;
                }
                catch
                {
                    Program.al2.Add(0);
                }
                if (checkedListBox1.GetItemCheckState(j) == CheckState.Checked)
                {
                    Program.checktest = 1;
                    try
                    {
                        Program.al2[j] = 1;
                    }
                    catch
                    {
                        Program.al2.Add(1);
                    }
                }
            }
            Program.secno=comboBox1.SelectedIndex;
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Teacher ID !");
            }
            else if (textBox2.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Teacher Name !");
            }
            else if(Program.secno==0)
            {
                MessageBox.Show("Please Select a Section !");
            }
            else if(textBox3.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Telephone Number !");
            }
            else if (Program.checktest==0)
            {
                MessageBox.Show("Please Select Atleast One Subject !");
            }
            else
            {
                Teacher.tadd();
                Program.tname = "";
                Program.tno = 0;
                Program.tid = "";
                Program.tpno = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                for (int j = 0; j < checkedListBox1.Items.Count; j++)
                {
                    checkedListBox1.SetItemChecked(j, false);
                }
            }
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Teacher ID");
            }
            else
            {
                if(comboBox1.SelectedIndex!=0)
                {
                    Program.secno = comboBox1.SelectedIndex;
                }
                Program.tid = textBox1.Text;
                Teacher.teacherload();
                textBox2.Text = Program.tname;
                textBox3.Text = Program.tpno;
                for (int j = 0; j < Program.al3.Count; j++)
                {
                    try
                    {
                        Program.al2[j] = 0;
                    }
                    catch
                    {
                        Program.al2.Add(0);
                    }
                    if (Convert.ToInt32(Program.al3[j]) == 1)
                    {
                        checkedListBox1.SetItemCheckState(j, CheckState.Checked);
                        try
                        {
                            Program.al2[j] = 1;
                        }
                        catch
                        {
                            Program.al2.Add(1);
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teacher.teacherdelete();
            tclear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tclear();
        }
        public void tclear()
        {
            Program.tname = "";
            Program.tid = "";
            Program.secno = 0;
            Program.tpno = "";
            for (int j = 0; j < checkedListBox1.Items.Count; j++)
            {
                checkedListBox1.SetItemChecked(j, false);
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
