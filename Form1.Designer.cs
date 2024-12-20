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
            panel2 = new Panel();
            panel3 = new Panel();
            Sales = new Button();
            Employees = new Button();
            Products = new Button();
            Purchases = new Button();
            Suppliers = new Button();
            Customers = new Button();
            panel4 = new Panel();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.ForeColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1904, 57);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(1, 1010);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1904, 32);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
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
            Sales.Location = new Point(25, 28);
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
            Employees.Location = new Point(25, 535);
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
            Products.Location = new Point(25, 431);
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
            Purchases.Location = new Point(25, 331);
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
            Suppliers.Location = new Point(25, 230);
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
            Customers.Location = new Point(25, 129);
            Customers.Margin = new Padding(2, 1, 2, 1);
            Customers.Name = "Customers";
            Customers.Size = new Size(301, 75);
            Customers.TabIndex = 1;
            Customers.UseVisualStyleBackColor = false;
            Customers.Click += Customers_Click;
            // 
            // panel4
            // 
            panel4.Location = new Point(390, 59);
            panel4.Margin = new Padding(2, 1, 2, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1515, 949);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
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
            panel3.ResumeLayout(false);
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
    }
}
