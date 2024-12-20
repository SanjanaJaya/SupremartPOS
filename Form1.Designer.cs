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
            Employees = new Button();
            Products = new Button();
            Purchases = new Button();
            Suppliers = new Button();
            Customers = new Button();
            Sales = new Button();
            panel4 = new Panel();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.ForeColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1905, 45);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(0, 973);
            panel2.Name = "panel2";
            panel2.Size = new Size(1905, 35);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(Employees);
            panel3.Controls.Add(Products);
            panel3.Controls.Add(Purchases);
            panel3.Controls.Add(Suppliers);
            panel3.Controls.Add(Customers);
            panel3.Controls.Add(Sales);
            panel3.Location = new Point(2, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(358, 929);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // Employees
            // 
            Employees.BackColor = Color.Transparent;
            Employees.BackgroundImage = (Image)resources.GetObject("Employees.BackgroundImage");
            Employees.FlatStyle = FlatStyle.Popup;
            Employees.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Employees.ForeColor = Color.White;
            Employees.Location = new Point(44, 673);
            Employees.Name = "Employees";
            Employees.Size = new Size(271, 87);
            Employees.TabIndex = 5;
            Employees.Text = "Employees";
            Employees.UseVisualStyleBackColor = false;
            Employees.Click += Employees_Click;
            // 
            // Products
            // 
            Products.BackColor = Color.Transparent;
            Products.BackgroundImage = (Image)resources.GetObject("Products.BackgroundImage");
            Products.FlatStyle = FlatStyle.Popup;
            Products.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Products.ForeColor = Color.White;
            Products.Location = new Point(44, 547);
            Products.Name = "Products";
            Products.Size = new Size(271, 87);
            Products.TabIndex = 4;
            Products.Text = "Products";
            Products.UseVisualStyleBackColor = false;
            // 
            // Purchases
            // 
            Purchases.BackColor = Color.Transparent;
            Purchases.BackgroundImage = (Image)resources.GetObject("Purchases.BackgroundImage");
            Purchases.FlatStyle = FlatStyle.Popup;
            Purchases.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Purchases.ForeColor = Color.White;
            Purchases.Location = new Point(44, 420);
            Purchases.Name = "Purchases";
            Purchases.Size = new Size(271, 87);
            Purchases.TabIndex = 3;
            Purchases.Text = "Purchases";
            Purchases.UseVisualStyleBackColor = false;
            // 
            // Suppliers
            // 
            Suppliers.BackColor = Color.Transparent;
            Suppliers.BackgroundImage = (Image)resources.GetObject("Suppliers.BackgroundImage");
            Suppliers.FlatStyle = FlatStyle.Popup;
            Suppliers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Suppliers.ForeColor = Color.White;
            Suppliers.Location = new Point(44, 294);
            Suppliers.Name = "Suppliers";
            Suppliers.Size = new Size(271, 87);
            Suppliers.TabIndex = 2;
            Suppliers.Text = "Suppliers";
            Suppliers.UseVisualStyleBackColor = false;
            // 
            // Customers
            // 
            Customers.BackColor = Color.Transparent;
            Customers.BackgroundImage = (Image)resources.GetObject("Customers.BackgroundImage");
            Customers.FlatStyle = FlatStyle.Popup;
            Customers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Customers.ForeColor = Color.White;
            Customers.Location = new Point(44, 165);
            Customers.Name = "Customers";
            Customers.Size = new Size(271, 87);
            Customers.TabIndex = 1;
            Customers.Text = "Customers";
            Customers.UseVisualStyleBackColor = false;
            Customers.Click += Customers_Click;
            // 
            // Sales
            // 
            Sales.BackColor = Color.Transparent;
            Sales.BackgroundImage = (Image)resources.GetObject("Sales.BackgroundImage");
            Sales.FlatStyle = FlatStyle.Popup;
            Sales.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Sales.ForeColor = Color.White;
            Sales.Location = new Point(44, 33);
            Sales.Name = "Sales";
            Sales.Size = new Size(271, 87);
            Sales.TabIndex = 0;
            Sales.Text = "Sales";
            Sales.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Location = new Point(361, 47);
            panel4.Name = "panel4";
            panel4.Size = new Size(1539, 922);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 1009);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
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
