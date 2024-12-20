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
            dataGridView1.Size = new Size(1494, 749);
            dataGridView1.TabIndex = 2;
            // 
            // addcustomer
            // 
            addcustomer.BackColor = Color.Transparent;
            addcustomer.BackgroundImage = (Image)resources.GetObject("addcustomer.BackgroundImage");
            addcustomer.FlatAppearance.BorderSize = 0;
            addcustomer.FlatStyle = FlatStyle.Flat;
            addcustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addcustomer.ForeColor = Color.White;
            addcustomer.Location = new Point(627, 847);
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
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}
