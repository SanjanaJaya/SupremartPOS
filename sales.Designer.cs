namespace SuprememartPOS
{
    partial class sales
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sales));
            salesss = new Label();
            dataGridViewsales = new DataGridView();
            Sales_Id = new DataGridViewTextBoxColumn();
            Customer_Id = new DataGridViewTextBoxColumn();
            Discounts = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewsales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // salesss
            // 
            salesss.AutoSize = true;
            salesss.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salesss.Location = new Point(16, 12);
            salesss.Margin = new Padding(2, 0, 2, 0);
            salesss.Name = "salesss";
            salesss.Size = new Size(110, 50);
            salesss.TabIndex = 1;
            salesss.Text = "Sales";
            salesss.Click += label1_Click;
            // 
            // dataGridViewsales
            // 
            dataGridViewsales.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkBlue;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewsales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewsales.ColumnHeadersHeight = 50;
            dataGridViewsales.Columns.AddRange(new DataGridViewColumn[] { Sales_Id, Customer_Id, Discounts, Column1 });
            dataGridViewsales.EnableHeadersVisualStyles = false;
            dataGridViewsales.Location = new Point(16, 73);
            dataGridViewsales.Margin = new Padding(2, 1, 2, 1);
            dataGridViewsales.Name = "dataGridViewsales";
            dataGridViewsales.RowHeadersWidth = 82;
            dataGridViewsales.Size = new Size(1494, 749);
            dataGridViewsales.TabIndex = 3;
            dataGridViewsales.CellContentClick += dataGridViewsales_CellContentClick;
            // 
            // Sales_Id
            // 
            Sales_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sales_Id.FillWeight = 3F;
            Sales_Id.HeaderText = "Sales ID";
            Sales_Id.Name = "Sales_Id";
            // 
            // Customer_Id
            // 
            Customer_Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Customer_Id.FillWeight = 5F;
            Customer_Id.HeaderText = "Customer ID";
            Customer_Id.Name = "Customer_Id";
            // 
            // Discounts
            // 
            Discounts.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Discounts.FillWeight = 5F;
            Discounts.HeaderText = "Discounts";
            Discounts.Name = "Discounts";
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 5F;
            Column1.HeaderText = "Total Cost";
            Column1.Name = "Column1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(131, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 49);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // sales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictureBox1);
            Controls.Add(dataGridViewsales);
            Controls.Add(salesss);
            Margin = new Padding(2, 1, 2, 1);
            Name = "sales";
            Size = new Size(1540, 922);
            ((System.ComponentModel.ISupportInitialize)dataGridViewsales).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label salesss;
        private DataGridView dataGridViewsales;
        private DataGridViewTextBoxColumn Sales_Id;
        private DataGridViewTextBoxColumn Customer_Id;
        private DataGridViewTextBoxColumn Discounts;
        private DataGridViewTextBoxColumn Column1;
        private PictureBox pictureBox1;
    }
}
