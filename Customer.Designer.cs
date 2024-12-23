namespace SuprememartPOS
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            cust = new Label();
            dataGridView1 = new DataGridView();
            addcustomer = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dltcustomer = new Button();
            updateproduct = new Button();
            button4 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cust
            // 
            cust.AutoSize = true;
            cust.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cust.Location = new Point(16, 12);
            cust.Margin = new Padding(2, 0, 2, 0);
            cust.Name = "cust";
            cust.Size = new Size(189, 50);
            cust.TabIndex = 0;
            cust.Text = "Customer";
            cust.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 73);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1494, 449);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // addcustomer
            // 
            addcustomer.BackColor = Color.Transparent;
            addcustomer.BackgroundImage = (Image)resources.GetObject("addcustomer.BackgroundImage");
            addcustomer.FlatAppearance.BorderSize = 0;
            addcustomer.FlatStyle = FlatStyle.Flat;
            addcustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addcustomer.ForeColor = Color.White;
            addcustomer.Location = new Point(909, 557);
            addcustomer.Margin = new Padding(2, 1, 2, 1);
            addcustomer.Name = "addcustomer";
            addcustomer.Size = new Size(254, 54);
            addcustomer.TabIndex = 3;
            addcustomer.UseVisualStyleBackColor = false;
            addcustomer.Click += addcustomer_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(210, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 49);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Font = new Font("Segoe UI", 15.75F);
            textBox1.Location = new Point(238, 588);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 35);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(60, 588);
            label2.Name = "label2";
            label2.Size = new Size(118, 30);
            label2.TabIndex = 6;
            label2.Text = "First Name:";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ScrollBar;
            textBox2.Font = new Font("Segoe UI", 15.75F);
            textBox2.Location = new Point(238, 655);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(350, 35);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.Location = new Point(60, 660);
            label3.Name = "label3";
            label3.Size = new Size(117, 30);
            label3.TabIndex = 8;
            label3.Text = "Last Name:";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ScrollBar;
            textBox4.Font = new Font("Segoe UI", 15.75F);
            textBox4.Location = new Point(238, 801);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(350, 35);
            textBox4.TabIndex = 13;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ScrollBar;
            textBox3.Font = new Font("Segoe UI", 15.75F);
            textBox3.Location = new Point(238, 733);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(350, 35);
            textBox3.TabIndex = 12;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F);
            label5.Location = new Point(60, 801);
            label5.Name = "label5";
            label5.Size = new Size(135, 30);
            label5.TabIndex = 11;
            label5.Text = "NIC Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F);
            label4.Location = new Point(60, 736);
            label4.Name = "label4";
            label4.Size = new Size(172, 30);
            label4.TabIndex = 10;
            label4.Text = "Contact Number:";
            // 
            // dltcustomer
            // 
            dltcustomer.BackColor = Color.Transparent;
            dltcustomer.BackgroundImage = (Image)resources.GetObject("dltcustomer.BackgroundImage");
            dltcustomer.FlatAppearance.BorderSize = 0;
            dltcustomer.FlatStyle = FlatStyle.Flat;
            dltcustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dltcustomer.ForeColor = Color.White;
            dltcustomer.Location = new Point(909, 702);
            dltcustomer.Margin = new Padding(2, 1, 2, 1);
            dltcustomer.Name = "dltcustomer";
            dltcustomer.Size = new Size(254, 54);
            dltcustomer.TabIndex = 14;
            dltcustomer.UseVisualStyleBackColor = false;
            dltcustomer.Click += dltcustomer_Click;
            // 
            // updateproduct
            // 
            updateproduct.BackColor = Color.Transparent;
            updateproduct.BackgroundImage = (Image)resources.GetObject("updateproduct.BackgroundImage");
            updateproduct.FlatAppearance.BorderSize = 0;
            updateproduct.FlatStyle = FlatStyle.Flat;
            updateproduct.Location = new Point(909, 629);
            updateproduct.Name = "updateproduct";
            updateproduct.Size = new Size(254, 54);
            updateproduct.TabIndex = 18;
            updateproduct.UseVisualStyleBackColor = false;
            updateproduct.Click += updateproduct_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(909, 774);
            button4.Name = "button4";
            button4.Size = new Size(254, 54);
            button4.TabIndex = 20;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(909, 847);
            button1.Name = "button1";
            button1.Size = new Size(254, 54);
            button1.TabIndex = 21;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(updateproduct);
            Controls.Add(dltcustomer);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(addcustomer);
            Controls.Add(dataGridView1);
            Controls.Add(cust);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Customer";
            Size = new Size(1540, 922);
            Load += Customer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label cust;
        private DataGridView dataGridView1;
        private Button addcustomer;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label5;
        private Label label4;
        private Button dltcustomer;
        private Button updateproduct;
        private Button button4;
        private Button button1;
    }
}
