using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relief_System
{

    public partial class Form1 :Form
    {
        public Form1()
        {
            InitializeComponent();
            Program.tno = 1001;
            checkedListBox1.Items.Clear();
            for(int j=12;j<Program.al1.Count;j++)
            {
                checkedListBox1.Items.Add(Program.al1[j]);
            }
            Program.subarr = new int[Program.al1.Count];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.tname = textBox1.Text;
            //Teacher.tadd();
            // textBox1.Text = "";
            for (int j = 0; j < Program.al1.Count; j++)
            {
                MessageBox.Show(Convert.ToString(Program.subarr[j]));
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (int cindex1 in checkedListBox1.CheckedIndices)
            {
                for (int j = 0; j < Program.al1.Count; j++)
                {
                    if (cindex1 == j)
                    {
                        Program.subarr[j] = 1;
                    }
                }
            }
        }
    }
}
