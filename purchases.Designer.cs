namespace SuprememartPOS
{
    partial class purchases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(purchases));
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            purchs = new Label();
            pictureBox1 = new PictureBox();
            summry = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            button4 = new Button();
            textBox2 = new TextBox();
            labelLastAmount = new Label();
            labelDiscountAmount = new Label();
            labelDiscountPercentage = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 113);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1494, 265);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(16, 519);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1494, 265);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // purchs
            // 
            purchs.AutoSize = true;
            purchs.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purchs.Location = new Point(16, 14);
            purchs.Margin = new Padding(2, 0, 2, 0);
            purchs.Name = "purchs";
            purchs.Size = new Size(194, 50);
            purchs.TabIndex = 6;
            purchs.Text = "Purchases";
            purchs.Click += prodct_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Buying;
            pictureBox1.Location = new Point(215, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // summry
            // 
            summry.AutoSize = true;
            summry.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            summry.Location = new Point(16, 474);
            summry.Margin = new Padding(2, 0, 2, 0);
            summry.Name = "summry";
            summry.Size = new Size(143, 42);
            summry.TabIndex = 8;
            summry.Text = "Current Bill";
            summry.UseCompatibleTextRendering = true;
            summry.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 68);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 42);
            label1.TabIndex = 9;
            label1.Text = "Product List";
            label1.UseCompatibleTextRendering = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(946, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(347, 39);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1299, 70);
            button1.Name = "button1";
            button1.Size = new Size(42, 37);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(875, 416);
            button2.Name = "button2";
            button2.Size = new Size(254, 54);
            button2.TabIndex = 17;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(1155, 416);
            button3.Name = "button3";
            button3.Size = new Size(254, 54);
            button3.TabIndex = 19;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1350, 791);
            label2.Name = "label2";
            label2.Size = new Size(0, 30);
            label2.TabIndex = 20;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1151, 791);
            label3.Name = "label3";
            label3.Size = new Size(162, 30);
            label3.TabIndex = 21;
            label3.Text = "Order Amount:";
            label3.Click += label3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(757, 805);
            button4.Name = "button4";
            button4.Size = new Size(301, 74);
            button4.TabIndex = 22;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ScrollBar;
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(623, 822);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(79, 39);
            textBox2.TabIndex = 23;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // labelLastAmount
            // 
            labelLastAmount.AutoSize = true;
            labelLastAmount.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            labelLastAmount.Location = new Point(1350, 879);
            labelLastAmount.Name = "labelLastAmount";
            labelLastAmount.Size = new Size(0, 30);
            labelLastAmount.TabIndex = 24;
            // 
            // labelDiscountAmount
            // 
            labelDiscountAmount.AutoSize = true;
            labelDiscountAmount.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            labelDiscountAmount.Location = new Point(1344, 850);
            labelDiscountAmount.Name = "labelDiscountAmount";
            labelDiscountAmount.Size = new Size(0, 30);
            labelDiscountAmount.TabIndex = 25;
            // 
            // labelDiscountPercentage
            // 
            labelDiscountPercentage.AutoSize = true;
            labelDiscountPercentage.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            labelDiscountPercentage.Location = new Point(1359, 820);
            labelDiscountPercentage.Name = "labelDiscountPercentage";
            labelDiscountPercentage.Size = new Size(0, 30);
            labelDiscountPercentage.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1075, 820);
            label4.Name = "label4";
            label4.Size = new Size(244, 30);
            label4.TabIndex = 27;
            label4.Text = "Discounted Percentage:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1102, 850);
            label5.Name = "label5";
            label5.Size = new Size(217, 30);
            label5.TabIndex = 28;
            label5.Text = "Discounted Amount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1165, 880);
            label6.Name = "label6";
            label6.Size = new Size(154, 30);
            label6.TabIndex = 29;
            label6.Text = "Total Amount:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(298, 826);
            label7.Name = "label7";
            label7.Size = new Size(324, 32);
            label7.TabIndex = 30;
            label7.Text = "Enter Discount Percentage:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(703, 826);
            label8.Name = "label8";
            label8.Size = new Size(35, 32);
            label8.TabIndex = 31;
            label8.Text = "%";
            // 
            // purchases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(labelDiscountPercentage);
            Controls.Add(labelDiscountAmount);
            Controls.Add(labelLastAmount);
            Controls.Add(textBox2);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(summry);
            Controls.Add(pictureBox1);
            Controls.Add(purchs);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "purchases";
            Size = new Size(1540, 922);
            Load += purchases_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label purchs;
        private PictureBox pictureBox1;
        private Label summry;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private Button button4;
        private TextBox textBox2;
        private Label labelLastAmount;
        private Label labelDiscountAmount;
        private Label labelDiscountPercentage;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
