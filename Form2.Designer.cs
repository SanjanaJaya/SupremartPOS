﻿namespace SuprememartPOS
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel4 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            logout = new Button();
            Products = new Button();
            Purchases = new Button();
            Customers = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.Location = new Point(376, 58);
            panel4.Margin = new Padding(2, 1, 2, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(1515, 949);
            panel4.TabIndex = 7;
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
            label4.Font = new Font("Segoe UI Black", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.MenuText;
            label4.Location = new Point(435, 334);
            label4.Name = "label4";
            label4.Size = new Size(654, 128);
            label4.TabIndex = 1;
            label4.Text = "SUPREMART";
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
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(logout);
            panel3.Controls.Add(Products);
            panel3.Controls.Add(Purchases);
            panel3.Controls.Add(Customers);
            panel3.Location = new Point(-12, 58);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(386, 950);
            panel3.TabIndex = 6;
            // 
            // logout
            // 
            logout.BackColor = Color.Transparent;
            logout.BackgroundImage = (Image)resources.GetObject("logout.BackgroundImage");
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatStyle = FlatStyle.Flat;
            logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            logout.ForeColor = Color.White;
            logout.Location = new Point(34, 854);
            logout.Margin = new Padding(2, 1, 2, 1);
            logout.Name = "logout";
            logout.Size = new Size(301, 75);
            logout.TabIndex = 6;
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // Products
            // 
            Products.BackColor = Color.Transparent;
            Products.BackgroundImage = (Image)resources.GetObject("Products.BackgroundImage");
            Products.FlatAppearance.BorderSize = 0;
            Products.FlatStyle = FlatStyle.Flat;
            Products.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Products.ForeColor = Color.White;
            Products.Location = new Point(34, 367);
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
            Purchases.Location = new Point(34, 240);
            Purchases.Margin = new Padding(2, 1, 2, 1);
            Purchases.Name = "Purchases";
            Purchases.Size = new Size(301, 75);
            Purchases.TabIndex = 3;
            Purchases.UseVisualStyleBackColor = false;
            Purchases.Click += Purchases_Click;
            // 
            // Customers
            // 
            Customers.BackColor = Color.Transparent;
            Customers.BackgroundImage = (Image)resources.GetObject("Customers.BackgroundImage");
            Customers.FlatAppearance.BorderSize = 0;
            Customers.FlatStyle = FlatStyle.Flat;
            Customers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Customers.ForeColor = Color.White;
            Customers.Location = new Point(34, 492);
            Customers.Margin = new Padding(2, 1, 2, 1);
            Customers.Name = "Customers";
            Customers.Size = new Size(301, 75);
            Customers.TabIndex = 1;
            Customers.UseVisualStyleBackColor = false;
            Customers.Click += Customers_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-13, 1009);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1904, 32);
            panel2.TabIndex = 5;
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
            label2.Location = new Point(824, 4);
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
            label1.Location = new Point(935, 4);
            label1.Name = "label1";
            label1.Size = new Size(326, 21);
            label1.TabIndex = 0;
            label1.Text = "Group BQ Information Management Retrieval";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label6);
            panel1.ForeColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(-13, -1);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1931, 57);
            panel1.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(840, 3);
            label6.Name = "label6";
            label6.Size = new Size(371, 45);
            label6.TabIndex = 0;
            label6.Text = "SUPREMART (Cashier)";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.Click += label6_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private Button logout;
        private Button Products;
        private Button Purchases;
        private Button Customers;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label6;
    }
}