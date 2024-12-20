namespace SuprememartPOS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            Sales = new Button();
            Employees = new Button();
            Products = new Button();
            Purchases = new Button();
            Suppliers = new Button();
            Customers = new Button();
            panel4 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            logout = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label6);
            panel1.ForeColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1904, 57);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(918, 9);
            label6.Name = "label6";
            label6.Size = new Size(187, 40);
            label6.TabIndex = 0;
            label6.Text = "SUPREMART";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 1010);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1904, 32);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(912, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(827, 4);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 1;
            label2.Text = "Copyrights";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(932, 4);
            label1.Name = "label1";
            label1.Size = new Size(326, 21);
            label1.TabIndex = 0;
            label1.Text = "Group BQ Information Management Retrieval";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(logout);
            panel3.Controls.Add(Sales);
            panel3.Controls.Add(Employees);
            panel3.Controls.Add(Products);
            panel3.Controls.Add(Purchases);
            panel3.Controls.Add(Suppliers);
            panel3.Controls.Add(Customers);
            panel3.Location = new Point(2, 59);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(386, 950);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // Sales
            // 
            Sales.BackColor = Color.Silver;
            Sales.BackgroundImage = (Image)resources.GetObject("Sales.BackgroundImage");
            Sales.FlatAppearance.BorderSize = 0;
            Sales.FlatStyle = FlatStyle.Flat;
            Sales.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Sales.ForeColor = Color.White;
            Sales.Location = new Point(28, 40);
            Sales.Margin = new Padding(2, 1, 2, 1);
            Sales.Name = "Sales";
            Sales.Size = new Size(301, 75);
            Sales.TabIndex = 0;
            Sales.UseVisualStyleBackColor = false;
            Sales.Click += Sales_Click;
            // 
            // Employees
            // 
            Employees.BackColor = Color.Transparent;
            Employees.BackgroundImage = (Image)resources.GetObject("Employees.BackgroundImage");
            Employees.FlatAppearance.BorderSize = 0;
            Employees.FlatStyle = FlatStyle.Flat;
            Employees.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Employees.ForeColor = Color.White;
            Employees.Location = new Point(28, 654);
            Employees.Margin = new Padding(2, 1, 2, 1);
            Employees.Name = "Employees";
            Employees.Size = new Size(301, 75);
            Employees.TabIndex = 5;
            Employees.UseVisualStyleBackColor = false;
            Employees.Click += Employees_Click;
            // 
            // Products
            // 
            Products.BackColor = Color.Transparent;
            Products.BackgroundImage = (Image)resources.GetObject("Products.BackgroundImage");
            Products.FlatAppearance.BorderSize = 0;
            Products.FlatStyle = FlatStyle.Flat;
            Products.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Products.ForeColor = Color.White;
            Products.Location = new Point(28, 530);
            Products.Margin = new Padding(2, 1, 2, 1);
            Products.Name = "Products";
            Products.Size = new Size(301, 75);
            Products.TabIndex = 4;
            Products.UseVisualStyleBackColor = false;
            Products.Click += Products_Click;
            // 
            // Purchases
            // 
            Purchases.BackColor = Color.Transparent;
            Purchases.BackgroundImage = (Image)resources.GetObject("Purchases.BackgroundImage");
            Purchases.FlatAppearance.BorderSize = 0;
            Purchases.FlatStyle = FlatStyle.Flat;
            Purchases.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Purchases.ForeColor = Color.White;
            Purchases.Location = new Point(28, 407);
            Purchases.Margin = new Padding(2, 1, 2, 1);
            Purchases.Name = "Purchases";
            Purchases.Size = new Size(301, 75);
            Purchases.TabIndex = 3;
            Purchases.UseVisualStyleBackColor = false;
            Purchases.Click += Purchases_Click;
            // 
            // Suppliers
            // 
            Suppliers.BackColor = Color.Transparent;
            Suppliers.BackgroundImage = (Image)resources.GetObject("Suppliers.BackgroundImage");
            Suppliers.FlatAppearance.BorderSize = 0;
            Suppliers.FlatStyle = FlatStyle.Flat;
            Suppliers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Suppliers.ForeColor = Color.White;
            Suppliers.Location = new Point(28, 286);
            Suppliers.Margin = new Padding(2, 1, 2, 1);
            Suppliers.Name = "Suppliers";
            Suppliers.Size = new Size(301, 75);
            Suppliers.TabIndex = 2;
            Suppliers.UseVisualStyleBackColor = false;
            Suppliers.Click += Suppliers_Click;
            // 
            // Customers
            // 
            Customers.BackColor = Color.Transparent;
            Customers.BackgroundImage = (Image)resources.GetObject("Customers.BackgroundImage");
            Customers.FlatAppearance.BorderSize = 0;
            Customers.FlatStyle = FlatStyle.Flat;
            Customers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Customers.ForeColor = Color.White;
            Customers.Location = new Point(28, 163);
            Customers.Margin = new Padding(2, 1, 2, 1);
            Customers.Name = "Customers";
            Customers.Size = new Size(301, 75);
            Customers.TabIndex = 1;
            Customers.UseVisualStyleBackColor = false;
            Customers.Click += Customers_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(390, 59);
            panel4.Margin = new Padding(2, 1, 2, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1515, 949);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(549, 519);
            label5.Name = "label5";
            label5.Size = new Size(422, 86);
            label5.TabIndex = 2;
            label5.Text = "POS SYSTEM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 72F, FontStyle.Bold | FontStyle.Italic | FontStyle.Strikeout, GraphicsUnit.Point, 0);
            label4.Location = new Point(458, 331);
            label4.Name = "label4";
            label4.Size = new Size(655, 128);
            label4.TabIndex = 1;
            label4.Text = "SUPREMART";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(583, 192);
            label3.Name = "label3";
            label3.Size = new Size(355, 86);
            label3.TabIndex = 0;
            label3.Text = "Welcome !";
            // 
            // logout
            // 
            logout.BackColor = Color.Transparent;
            logout.BackgroundImage = (Image)resources.GetObject("logout.BackgroundImage");
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatStyle = FlatStyle.Flat;
            logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            logout.ForeColor = Color.White;
            logout.Location = new Point(28, 780);
            logout.Margin = new Padding(2, 1, 2, 1);
            logout.Name = "logout";
            logout.Size = new Size(301, 75);
            logout.TabIndex = 6;
            logout.UseVisualStyleBackColor = false;
            logout.Click += button1_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button Sales;
        private Button Customers;
        private Button Purchases;
        private Button Suppliers;
        private Button Products;
        private Button Employees;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button logout;
    }
}
