using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public static int DCR = 25;
        public static decimal BR = 30;
        public Form1()
        {
            InitializeComponent();
        }
        //hello
        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Customer First Name:";

            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;

            CLN.Visible = true;
            A.Visible = true;
            PhoneN.Visible = true;

            Validate();
            panel1.Update();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "Customer Name:";

            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;

            CLN.Visible = false;
            A.Visible = false;
            PhoneN.Visible = false;

            Validate();
            panel1.Update();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TOA.GetItemCheckState(0) == CheckState.Checked)
            {
                NOD.Visible = true;
                label12.Visible = true;
            }
            if (TOA.GetItemCheckState(0) == CheckState.Unchecked)
            {
                NOD.Visible = false;
                label12.Visible = false;
            }

            if (TOA.GetItemCheckState(1) == CheckState.Checked)
            {
                NOC.Visible = true;
                label13.Visible = true;
            }

            if (TOA.GetItemCheckState(1) == CheckState.Unchecked)
            {
                NOC.Visible = false;
                label13.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DC.Visible = true;
            B.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            B.Visible = true;
            DC.Visible = false;
        }

        private void NOD_ValueChanged(object sender, EventArgs e)
        {
            if (NOD.Visible == true)
            {
                DC.Text += (25 * NOD.Value);
            }            
        }

        private void NOC_ValueChanged(object sender, EventArgs e)
        {
            if (NOC.Visible == true)
            {
                DC.Text += (25 * NOD.Value);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] row = { textBox1.Text, Convert.ToString(numericUpDown1.Value), richTextBox1.Text };
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
            textBox1.Clear();
            numericUpDown1.ResetText();
            richTextBox1.Clear();
            DC.Text += DCR;
            B.Text += BR;
        }
    }
}
