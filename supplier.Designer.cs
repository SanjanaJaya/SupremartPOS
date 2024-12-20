namespace SuprememartPOS
{
    partial class supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplier));
            dataGridViewSuppliers = new DataGridView();
            supplir = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSuppliers
            // 
            dataGridViewSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSuppliers.Location = new Point(16, 73);
            dataGridViewSuppliers.Margin = new Padding(2, 1, 2, 1);
            dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewSuppliers.RowHeadersWidth = 82;
            dataGridViewSuppliers.Size = new Size(1494, 749);
            dataGridViewSuppliers.TabIndex = 4;
            // 
            // supplir
            // 
            supplir.AutoSize = true;
            supplir.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supplir.Location = new Point(16, 12);
            supplir.Margin = new Padding(2, 0, 2, 0);
            supplir.Name = "supplir";
            supplir.Size = new Size(184, 50);
            supplir.TabIndex = 5;
            supplir.Text = "Suppliers";
            supplir.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(205, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 49);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // supplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(supplir);
            Controls.Add(dataGridViewSuppliers);
            Name = "supplier";
            Size = new Size(1539, 922);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSuppliers;
        private Label supplir;
        private PictureBox pictureBox1;
    }
}
