namespace SuprememartPOS
{
    partial class employees
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employees));
            dataGridViewEmplyoee = new DataGridView();
            employee = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            updateemp = new Button();
            deleteemp = new Button();
            addemp = new Button();
            button4 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmplyoee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmplyoee
            // 
            dataGridViewEmplyoee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewEmplyoee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmplyoee.Location = new Point(16, 73);
            dataGridViewEmplyoee.Margin = new Padding(2, 1, 2, 1);
            dataGridViewEmplyoee.Name = "dataGridViewEmplyoee";
            dataGridViewEmplyoee.RowHeadersWidth = 82;
            dataGridViewEmplyoee.Size = new Size(1513, 449);
            dataGridViewEmplyoee.TabIndex = 6;
            dataGridViewEmplyoee.CellContentClick += dataGridViewEmplyoee_CellContentClick;
            // 
            // employee
            // 
            employee.AutoSize = true;
            employee.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employee.Location = new Point(16, 12);
            employee.Margin = new Padding(2, 0, 2, 0);
            employee.Name = "employee";
            employee.Size = new Size(209, 50);
            employee.TabIndex = 7;
            employee.Text = "Employees";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(230, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 49);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F);
            label5.Location = new Point(59, 799);
            label5.Name = "label5";
            label5.Size = new Size(135, 30);
            label5.TabIndex = 19;
            label5.Text = "NIC Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F);
            label4.Location = new Point(59, 733);
            label4.Name = "label4";
            label4.Size = new Size(172, 30);
            label4.TabIndex = 18;
            label4.Text = "Contact Number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.Location = new Point(59, 657);
            label3.Name = "label3";
            label3.Size = new Size(91, 30);
            label3.TabIndex = 16;
            label3.Text = "Position:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(59, 585);
            label2.Name = "label2";
            label2.Size = new Size(74, 30);
            label2.TabIndex = 14;
            label2.Text = "Name:";
            // 
            // updateemp
            // 
            updateemp.BackColor = Color.Transparent;
            updateemp.BackgroundImage = (Image)resources.GetObject("updateemp.BackgroundImage");
            updateemp.FlatAppearance.BorderSize = 0;
            updateemp.FlatStyle = FlatStyle.Flat;
            updateemp.Location = new Point(907, 627);
            updateemp.Name = "updateemp";
            updateemp.Size = new Size(254, 54);
            updateemp.TabIndex = 24;
            updateemp.UseVisualStyleBackColor = false;
            updateemp.Click += updateemp_Click;
            // 
            // deleteemp
            // 
            deleteemp.BackColor = Color.Transparent;
            deleteemp.BackgroundImage = (Image)resources.GetObject("deleteemp.BackgroundImage");
            deleteemp.FlatAppearance.BorderSize = 0;
            deleteemp.FlatStyle = FlatStyle.Flat;
            deleteemp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            deleteemp.ForeColor = Color.White;
            deleteemp.Location = new Point(907, 700);
            deleteemp.Margin = new Padding(2, 1, 2, 1);
            deleteemp.Name = "deleteemp";
            deleteemp.Size = new Size(254, 54);
            deleteemp.TabIndex = 23;
            deleteemp.UseVisualStyleBackColor = false;
            deleteemp.Click += deleteemp_Click;
            // 
            // addemp
            // 
            addemp.BackColor = Color.Transparent;
            addemp.BackgroundImage = (Image)resources.GetObject("addemp.BackgroundImage");
            addemp.FlatAppearance.BorderSize = 0;
            addemp.FlatStyle = FlatStyle.Flat;
            addemp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addemp.ForeColor = Color.White;
            addemp.Location = new Point(907, 557);
            addemp.Margin = new Padding(2, 1, 2, 1);
            addemp.Name = "addemp";
            addemp.Size = new Size(254, 54);
            addemp.TabIndex = 22;
            addemp.UseVisualStyleBackColor = false;
            addemp.Click += addemp_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(907, 771);
            button4.Name = "button4";
            button4.Size = new Size(254, 54);
            button4.TabIndex = 32;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ScrollBar;
            textBox4.Font = new Font("Segoe UI", 15.75F);
            textBox4.Location = new Point(245, 797);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(350, 35);
            textBox4.TabIndex = 36;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ScrollBar;
            textBox3.Font = new Font("Segoe UI", 15.75F);
            textBox3.Location = new Point(245, 729);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(350, 35);
            textBox3.TabIndex = 35;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ScrollBar;
            textBox2.Font = new Font("Segoe UI", 15.75F);
            textBox2.Location = new Point(245, 654);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(350, 35);
            textBox2.TabIndex = 34;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Font = new Font("Segoe UI", 15.75F);
            textBox1.Location = new Point(245, 587);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 35);
            textBox1.TabIndex = 33;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(907, 844);
            button1.Name = "button1";
            button1.Size = new Size(254, 54);
            button1.TabIndex = 37;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(updateemp);
            Controls.Add(deleteemp);
            Controls.Add(addemp);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(employee);
            Controls.Add(dataGridViewEmplyoee);
            Name = "employees";
            Size = new Size(1540, 922);
            Load += employees_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmplyoee).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEmplyoee;
        private Label employee;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button updateemp;
        private Button deleteemp;
        private Button addemp;
        private Button button4;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
    }
}
