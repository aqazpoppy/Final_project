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
            this.NewCustomer = new System.Windows.Forms.Button();
            this.ExistingCustomer = new System.Windows.Forms.Button();
            this.CN = new System.Windows.Forms.TextBox();
            this.CLN = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.TextBox();
            this.PhoneN = new System.Windows.Forms.MaskedTextBox();
            this.TOR = new System.Windows.Forms.ComboBox();
            this.DOR = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.total = new System.Windows.Forms.MaskedTextBox();
            this.AddPetBtn = new System.Windows.Forms.Button();
            this.BreedDescriptInput = new System.Windows.Forms.RichTextBox();
            this.EstAgeInput = new System.Windows.Forms.NumericUpDown();
            this.PetNameInput = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DayCare = new System.Windows.Forms.Button();
            this.Boarding = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DC = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.Both = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstAgeInput)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewCustomer
            // 
            this.NewCustomer.Location = new System.Drawing.Point(157, 27);
            this.NewCustomer.Name = "NewCustomer";
            this.NewCustomer.Size = new System.Drawing.Size(104, 23);
            this.NewCustomer.TabIndex = 0;
            this.NewCustomer.Text = "New Customer";
            this.NewCustomer.UseVisualStyleBackColor = true;
            this.NewCustomer.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExistingCustomer
            // 
            this.ExistingCustomer.Location = new System.Drawing.Point(276, 27);
            this.ExistingCustomer.Name = "ExistingCustomer";
            this.ExistingCustomer.Size = new System.Drawing.Size(99, 23);
            this.ExistingCustomer.TabIndex = 1;
            this.ExistingCustomer.Text = "Existing Customer";
            this.ExistingCustomer.UseVisualStyleBackColor = true;
            this.ExistingCustomer.Click += new System.EventHandler(this.button3_Click);
            // 
            // CN
            // 
            this.CN.Location = new System.Drawing.Point(176, 56);
            this.CN.Name = "CN";
            this.CN.Size = new System.Drawing.Size(200, 20);
            this.CN.TabIndex = 2;
            this.CN.TextChanged += new System.EventHandler(this.CN_TextChanged);
            // 
            // CLN
            // 
            this.CLN.Enabled = false;
            this.CLN.Location = new System.Drawing.Point(176, 82);
            this.CLN.Name = "CLN";
            this.CLN.Size = new System.Drawing.Size(200, 20);
            this.CLN.TabIndex = 3;
            // 
            // A
            // 
            this.A.Enabled = false;
            this.A.Location = new System.Drawing.Point(176, 110);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(200, 20);
            this.A.TabIndex = 4;
            // 
            // PhoneN
            // 
            this.PhoneN.Enabled = false;
            this.PhoneN.Location = new System.Drawing.Point(177, 136);
            this.PhoneN.Mask = "(999) 000-0000";
            this.PhoneN.Name = "PhoneN";
            this.PhoneN.Size = new System.Drawing.Size(100, 20);
            this.PhoneN.TabIndex = 5;
            // 
            // TOR
            // 
            this.TOR.FormattingEnabled = true;
            this.TOR.Items.AddRange(new object[] {
            "Email",
            "Phone",
            "Walk-In"});
            this.TOR.Location = new System.Drawing.Point(176, 162);
            this.TOR.Name = "TOR";
            this.TOR.Size = new System.Drawing.Size(200, 21);
            this.TOR.TabIndex = 6;
            // 
            // DOR
            // 
            this.DOR.Location = new System.Drawing.Point(176, 189);
            this.DOR.Name = "DOR";
            this.DOR.Size = new System.Drawing.Size(200, 20);
            this.DOR.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 71);
            this.button1.TabIndex = 15;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Type of Reservation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Customer ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date of Reservation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description of Breed:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pet Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Estimated Age:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Type of Customer:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Phone Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Customer Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 608);
            this.panel1.TabIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(420, 602);
            this.tabControl1.TabIndex = 47;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Both);
            this.tabPage1.Controls.Add(this.B);
            this.tabPage1.Controls.Add(this.DC);
            this.tabPage1.Controls.Add(this.total);
            this.tabPage1.Controls.Add(this.AddPetBtn);
            this.tabPage1.Controls.Add(this.BreedDescriptInput);
            this.tabPage1.Controls.Add(this.EstAgeInput);
            this.tabPage1.Controls.Add(this.PetNameInput);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.DOR);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.CN);
            this.tabPage1.Controls.Add(this.DayCare);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.Boarding);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.TOR);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.CLN);
            this.tabPage1.Controls.Add(this.A);
            this.tabPage1.Controls.Add(this.PhoneN);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.ExistingCustomer);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.NewCustomer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(412, 576);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Single Pet";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(161, 473);
            this.total.Mask = "$000";
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 20);
            this.total.TabIndex = 53;
            this.total.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            this.total.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBox1_Validating);
            // 
            // AddPetBtn
            // 
            this.AddPetBtn.Location = new System.Drawing.Point(36, 290);
            this.AddPetBtn.Name = "AddPetBtn";
            this.AddPetBtn.Size = new System.Drawing.Size(75, 23);
            this.AddPetBtn.TabIndex = 11;
            this.AddPetBtn.Text = "Add Pet";
            this.AddPetBtn.UseVisualStyleBackColor = true;
            this.AddPetBtn.Click += new System.EventHandler(this.AddPetBtn_Click);
            // 
            // BreedDescriptInput
            // 
            this.BreedDescriptInput.AcceptsTab = true;
            this.BreedDescriptInput.Location = new System.Drawing.Point(176, 270);
            this.BreedDescriptInput.Name = "BreedDescriptInput";
            this.BreedDescriptInput.Size = new System.Drawing.Size(199, 43);
            this.BreedDescriptInput.TabIndex = 10;
            this.BreedDescriptInput.Text = "";
            // 
            // EstAgeInput
            // 
            this.EstAgeInput.Location = new System.Drawing.Point(177, 241);
            this.EstAgeInput.Name = "EstAgeInput";
            this.EstAgeInput.Size = new System.Drawing.Size(199, 20);
            this.EstAgeInput.TabIndex = 9;
            // 
            // PetNameInput
            // 
            this.PetNameInput.Location = new System.Drawing.Point(176, 218);
            this.PetNameInput.Name = "PetNameInput";
            this.PetNameInput.Size = new System.Drawing.Size(200, 20);
            this.PetNameInput.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Both";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(39, 319);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(337, 86);
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
            // DayCare
            // 
            this.DayCare.Location = new System.Drawing.Point(37, 411);
            this.DayCare.Name = "DayCare";
            this.DayCare.Size = new System.Drawing.Size(75, 23);
            this.DayCare.TabIndex = 12;
            this.DayCare.Text = "DayCare";
            this.DayCare.UseVisualStyleBackColor = true;
            this.DayCare.Click += new System.EventHandler(this.button4_Click);
            // 
            // Boarding
            // 
            this.Boarding.Location = new System.Drawing.Point(301, 411);
            this.Boarding.Name = "Boarding";
            this.Boarding.Size = new System.Drawing.Size(75, 23);
            this.Boarding.TabIndex = 14;
            this.Boarding.Text = "Boarding";
            this.Boarding.UseVisualStyleBackColor = true;
            this.Boarding.Click += new System.EventHandler(this.button5_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(412, 576);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(406, 570);
            this.dataGridView1.TabIndex = 0;
            // 
            // DC
            // 
            this.DC.AutoSize = true;
            this.DC.Location = new System.Drawing.Point(69, 447);
            this.DC.Name = "DC";
            this.DC.Size = new System.Drawing.Size(13, 13);
            this.DC.TabIndex = 54;
            this.DC.Text = "0";
            this.DC.Visible = false;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(333, 447);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(13, 13);
            this.B.TabIndex = 55;
            this.B.Text = "0";
            this.B.Visible = false;
            // 
            // Both
            // 
            this.Both.AutoSize = true;
            this.Both.Location = new System.Drawing.Point(204, 447);
            this.Both.Name = "Both";
            this.Both.Size = new System.Drawing.Size(13, 13);
            this.Both.TabIndex = 56;
            this.Both.Text = "0";
            this.Both.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 608);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "`";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstAgeInput)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox TOR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DOR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox CLN;
        private System.Windows.Forms.Button ExistingCustomer;
        private System.Windows.Forms.Button NewCustomer;
        private System.Windows.Forms.MaskedTextBox PhoneN;
        private System.Windows.Forms.Button Boarding;
        private System.Windows.Forms.Button DayCare;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddPetBtn;
        private System.Windows.Forms.RichTextBox BreedDescriptInput;
        private System.Windows.Forms.NumericUpDown EstAgeInput;
        private System.Windows.Forms.TextBox PetNameInput;
        private System.Windows.Forms.MaskedTextBox total;
        private System.Windows.Forms.Label Both;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label DC;
    }
}

