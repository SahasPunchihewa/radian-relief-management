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
            Teacher.subload();
            for (int j=13;j<Program.al1.Count;j++)
            {
                checkedListBox1.Items.Add(Program.al1[j]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.tname = textBox1.Text;
            for (int j = 0; j < (Program.al1.Count - 13); j++)
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
            Teacher.tadd();
            textBox1.Text = "";
            for(int j=0; j<checkedListBox1.Items.Count; j++)
            {
                checkedListBox1.SetItemChecked(j, false);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Program.nic = textBox2.Text;
            Teacher.teacherload();
            textBox1.Text = Program.tname;
            for(int j=0;j<Program.al3.Count; j++)
            {
                if (Convert.ToInt32(Program.al3[j])==1)
                {
                    checkedListBox1.SetItemCheckState(j,CheckState.Checked);
                }
            }
        }
    }
}
