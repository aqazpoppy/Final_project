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
        public int DCT = 0;
        public static int BR = 30;
        public int BRT = 0;
        public string gender;

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
            Address.Enabled = true;
            PhoneNumber.Enabled = true;

            Validate();
            panel1.Update();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "Customer ID:";
            label9.Text = "Customer Name:";
            CLN.Enabled = false;
            Address.Enabled = false;
            PhoneNumber.Enabled = false;

            Validate();
            panel1.Update();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DC.Visible = true;
            B.Visible = false;
            Both.Visible = false;
            Total.Text = DC.Text;
            Validate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            B.Visible = true;
            DC.Visible = false;
            Both.Visible = false;
            Total.Text = B.Text;

            Validate();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            B.Visible = true;
            DC.Visible = true;
            Both.Visible = true;
            Total.Text = Both.Text;
            Validate();
        }

        private void AddPetBtn_Click(object sender, EventArgs e)
        {
            string[] row = {PetNameInput.Text, Convert.ToString(EstAgeInput.Value), BreedDescriptInput.Text, gender };
            var listViewItem = new ListViewItem(row);
            listView1.Items.Add(listViewItem);
            PetNameInput.Clear();
            EstAgeInput.ResetText();
            BreedDescriptInput.Clear();

            DCT += DCR;
            BRT += BR;
            Both.Text = Convert.ToString(DCT + BRT);
            DC.Text = Convert.ToString(DCT);
            B.Text = Convert.ToString(BRT);

            if ((DC.Visible.Equals(true)) && (B.Visible.Equals(false)))
            {
                Total.Text = DC.Text;
                Validate();
            }
            if ((B.Visible.Equals(true)) && (DC.Visible.Equals(true)))
            {
                Total.Text = B.Text;
                Validate();
            }
            if (Both.Visible.Equals(true))
            {
                Total.Text = Both.Text;
                Validate();
            }
        }

        private void CN_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (Total.Text.Length.Equals(3))
            {
                label3.Text = "worked";
            }
            Validate();
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }
    }
}
