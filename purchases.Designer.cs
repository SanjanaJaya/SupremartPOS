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
            dataGridViewPurchase = new DataGridView();
            purchase = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            addcustomer = new Button();
            button1 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPurchase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPurchase
            // 
            dataGridViewPurchase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPurchase.Location = new Point(16, 98);
            dataGridViewPurchase.Margin = new Padding(2, 1, 2, 1);
            dataGridViewPurchase.Name = "dataGridViewPurchase";
            dataGridViewPurchase.RowHeadersWidth = 82;
            dataGridViewPurchase.Size = new Size(1494, 302);
            dataGridViewPurchase.TabIndex = 5;
            // 
            // purchase
            // 
            purchase.AutoSize = true;
            purchase.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purchase.Location = new Point(16, 12);
            purchase.Margin = new Padding(2, 0, 2, 0);
            purchase.Name = "purchase";
            purchase.Size = new Size(194, 50);
            purchase.TabIndex = 6;
            purchase.Text = "Purchases";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(215, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 49);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 516);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1494, 302);
            dataGridView1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 55);
            label1.Name = "label1";
            label1.Size = new Size(156, 37);
            label1.TabIndex = 11;
            label1.Text = "Product List";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 472);
            label2.Name = "label2";
            label2.Size = new Size(180, 37);
            label2.TabIndex = 12;
            label2.Text = "Current Order";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Silver;
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(629, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(374, 43);
            textBox1.TabIndex = 13;
            // 
            // addcustomer
            // 
            addcustomer.BackColor = Color.Transparent;
            addcustomer.BackgroundImage = (Image)resources.GetObject("addcustomer.BackgroundImage");
            addcustomer.FlatAppearance.BorderSize = 0;
            addcustomer.FlatStyle = FlatStyle.Flat;
            addcustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addcustomer.ForeColor = Color.White;
            addcustomer.Location = new Point(1025, 53);
            addcustomer.Margin = new Padding(2, 1, 2, 1);
            addcustomer.Name = "addcustomer";
            addcustomer.Size = new Size(42, 37);
            addcustomer.TabIndex = 23;
            addcustomer.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(611, 419);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(254, 54);
            button1.TabIndex = 24;
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(183, 850);
            label3.Name = "label3";
            label3.Size = new Size(80, 37);
            label3.TabIndex = 25;
            label3.Text = "Total:";
            // 
            // purchases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(addcustomer);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(purchase);
            Controls.Add(dataGridViewPurchase);
            Name = "purchases";
            Size = new Size(1540, 922);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPurchase).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPurchase;
        private Label purchase;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button addcustomer;
        private Button button1;
        private Label label3;
    }
}
