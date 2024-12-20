namespace SuprememartPOS
{
    partial class products
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
            dataGridViewproducts = new DataGridView();
            prodct = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewproducts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewproducts
            // 
            dataGridViewproducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewproducts.Location = new Point(16, 73);
            dataGridViewproducts.Margin = new Padding(2, 1, 2, 1);
            dataGridViewproducts.Name = "dataGridViewproducts";
            dataGridViewproducts.RowHeadersWidth = 82;
            dataGridViewproducts.Size = new Size(1494, 749);
            dataGridViewproducts.TabIndex = 4;
            // 
            // prodct
            // 
            prodct.AutoSize = true;
            prodct.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            prodct.Location = new Point(16, 29);
            prodct.Margin = new Padding(2, 0, 2, 0);
            prodct.Name = "prodct";
            prodct.Size = new Size(95, 28);
            prodct.TabIndex = 5;
            prodct.Text = "Products";
            // 
            // products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(prodct);
            Controls.Add(dataGridViewproducts);
            Name = "products";
            Size = new Size(1540, 922);
            ((System.ComponentModel.ISupportInitialize)dataGridViewproducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewproducts;
        private Label prodct;
    }
}
