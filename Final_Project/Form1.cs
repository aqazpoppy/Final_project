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
        public static int BR = 30;
        public Form1()
        {
            InitializeComponent();
        }
        //hello
        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "Customer First Name:";
            label9.Text = "Customer Last Name:";
            CLN.Enabled = true;
            A.Enabled = true;
            PhoneN.Enabled = true;

            Validate();
            panel1.Update();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "Customer ID:";
            label9.Text = "Customer Name:";
            CLN.Enabled = false;
            A.Enabled = false;
            PhoneN.Enabled = false;

            Validate();
            panel1.Update();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DC.Visible = true;
            B.Visible = false;
            Both.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            B.Visible = true;
            DC.Visible = false;
            Both.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            B.Visible = true;
            DC.Visible = true;
            Both.Visible = true;
        }

        private void AddPetBtn_Click(object sender, EventArgs e)
        {
            string[] row = {PetNameInput.Text, Convert.ToString(EstAgeInput.Value), BreedDescriptInput.Text };
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
            PetNameInput.Clear();
            EstAgeInput.ResetText();
            BreedDescriptInput.Clear();

        }

        private void CN_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text.Length.Equals(3))
            {
                label3.Text = "worked";
            }
            Validate();
        }
    }
}
