namespace Final_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CN = new System.Windows.Forms.TextBox();
            this.CLN = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.TextBox();
            this.PhoneN = new System.Windows.Forms.MaskedTextBox();
            this.TOR = new System.Windows.Forms.ComboBox();
            this.DOR = new System.Windows.Forms.DateTimePicker();
            this.DOB = new System.Windows.Forms.RichTextBox();
            this.PN = new System.Windows.Forms.TextBox();
            this.EA = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label15 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.MaskedTextBox();
            this.DC = new System.Windows.Forms.MaskedTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NOC = new System.Windows.Forms.NumericUpDown();
            this.NOD = new System.Windows.Forms.NumericUpDown();
            this.TOA = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.EA)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOD)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "New Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Existing Customer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CN
            // 
            this.CN.Location = new System.Drawing.Point(168, 62);
            this.CN.Name = "CN";
            this.CN.Size = new System.Drawing.Size(200, 20);
            this.CN.TabIndex = 2;
            // 
            // CLN
            // 
            this.CLN.Location = new System.Drawing.Point(168, 88);
            this.CLN.Name = "CLN";
            this.CLN.Size = new System.Drawing.Size(200, 20);
            this.CLN.TabIndex = 3;
            this.CLN.Visible = false;
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(168, 116);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(200, 20);
            this.A.TabIndex = 4;
            this.A.Visible = false;
            // 
            // PhoneN
            // 
            this.PhoneN.Location = new System.Drawing.Point(169, 142);
            this.PhoneN.Mask = "(999) 000-0000";
            this.PhoneN.Name = "PhoneN";
            this.PhoneN.Size = new System.Drawing.Size(100, 20);
            this.PhoneN.TabIndex = 27;
            this.PhoneN.Visible = false;
            // 
            // TOR
            // 
            this.TOR.FormattingEnabled = true;
            this.TOR.Items.AddRange(new object[] {
            "Email",
            "Phone",
            "Walk-In"});
            this.TOR.Location = new System.Drawing.Point(168, 168);
            this.TOR.Name = "TOR";
            this.TOR.Size = new System.Drawing.Size(200, 21);
            this.TOR.TabIndex = 7;
            // 
            // DOR
            // 
            this.DOR.Location = new System.Drawing.Point(168, 295);
            this.DOR.Name = "DOR";
            this.DOR.Size = new System.Drawing.Size(200, 20);
            this.DOR.TabIndex = 9;
            // 
            // DOB
            // 
            this.DOB.Location = new System.Drawing.Point(168, 326);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(200, 46);
            this.DOB.TabIndex = 10;
            this.DOB.Text = "";
            // 
            // PN
            // 
            this.PN.Location = new System.Drawing.Point(168, 382);
            this.PN.Name = "PN";
            this.PN.Size = new System.Drawing.Size(200, 20);
            this.PN.TabIndex = 11;
            // 
            // EA
            // 
            this.EA.Location = new System.Drawing.Point(168, 411);
            this.EA.Name = "EA";
            this.EA.Size = new System.Drawing.Size(200, 20);
            this.EA.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(718, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Type of Reservation:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Type of Animal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Customer Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date of Reservation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description of Breed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pet Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Estimated Age:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Type of Customer:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Phone Number:";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Address:";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Customer Last Name:";
            this.label9.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.B);
            this.panel1.Controls.Add(this.DC);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.NOC);
            this.panel1.Controls.Add(this.NOD);
            this.panel1.Controls.Add(this.PhoneN);
            this.panel1.Controls.Add(this.TOA);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.A);
            this.panel1.Controls.Add(this.CLN);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TOR);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EA);
            this.panel1.Controls.Add(this.PN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DOB);
            this.panel1.Controls.Add(this.CN);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.DOR);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 532);
            this.panel1.TabIndex = 14;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(582, 132);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 39;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(442, 198);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 23);
            this.button6.TabIndex = 44;
            this.button6.Text = "Add Pet";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(439, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Estimated Age:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(439, 237);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(263, 86);
            this.listView1.TabIndex = 41;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pet Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Estimated Age";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Description of Breed";
            this.columnHeader3.Width = 115;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(436, 162);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Description of Breed:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(582, 159);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(120, 72);
            this.richTextBox1.TabIndex = 40;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(582, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(439, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Pet Name:";
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(602, 378);
            this.B.Mask = "$000.00";
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(100, 20);
            this.B.TabIndex = 35;
            this.B.Visible = false;
            // 
            // DC
            // 
            this.DC.Location = new System.Drawing.Point(439, 378);
            this.DC.Mask = "$000.00";
            this.DC.Name = "DC";
            this.DC.Size = new System.Drawing.Size(100, 20);
            this.DC.TabIndex = 34;
            this.DC.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(627, 329);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 33;
            this.button5.Text = "Boarding";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(439, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 32;
            this.button4.Text = "DayCare";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(436, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Number of Cats:";
            this.label13.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(436, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Number of Dogs:";
            this.label12.Visible = false;
            // 
            // NOC
            // 
            this.NOC.Location = new System.Drawing.Point(582, 69);
            this.NOC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NOC.Name = "NOC";
            this.NOC.Size = new System.Drawing.Size(120, 20);
            this.NOC.TabIndex = 29;
            this.NOC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NOC.Visible = false;
            this.NOC.ValueChanged += new System.EventHandler(this.NOC_ValueChanged);
            // 
            // NOD
            // 
            this.NOD.Location = new System.Drawing.Point(582, 38);
            this.NOD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NOD.Name = "NOD";
            this.NOD.Size = new System.Drawing.Size(120, 20);
            this.NOD.TabIndex = 28;
            this.NOD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NOD.Visible = false;
            this.NOD.ValueChanged += new System.EventHandler(this.NOD_ValueChanged);
            // 
            // TOA
            // 
            this.TOA.FormattingEnabled = true;
            this.TOA.Items.AddRange(new object[] {
            "Dog",
            "Cat",
            "Bird"});
            this.TOA.Location = new System.Drawing.Point(168, 195);
            this.TOA.Name = "TOA";
            this.TOA.Size = new System.Drawing.Size(120, 94);
            this.TOA.TabIndex = 7;
            this.TOA.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 532);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.EA)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NOD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox TOR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DOR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox DOB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PN;
        private System.Windows.Forms.NumericUpDown EA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox CLN;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox TOA;
        private System.Windows.Forms.MaskedTextBox PhoneN;
        private System.Windows.Forms.NumericUpDown NOC;
        private System.Windows.Forms.NumericUpDown NOD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox B;
        private System.Windows.Forms.MaskedTextBox DC;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

