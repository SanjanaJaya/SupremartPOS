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
            dataGridViewPurchase = new DataGridView();
            purchase = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPurchase).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPurchase
            // 
            dataGridViewPurchase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPurchase.Location = new Point(16, 73);
            dataGridViewPurchase.Margin = new Padding(2, 1, 2, 1);
            dataGridViewPurchase.Name = "dataGridViewPurchase";
            dataGridViewPurchase.RowHeadersWidth = 82;
            dataGridViewPurchase.Size = new Size(1494, 749);
            dataGridViewPurchase.TabIndex = 5;
            // 
            // purchase
            // 
            purchase.AutoSize = true;
            purchase.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            purchase.Location = new Point(16, 12);
            purchase.Margin = new Padding(2, 0, 2, 0);
            purchase.Name = "purchase";
            purchase.Size = new Size(106, 28);
            purchase.TabIndex = 6;
            purchase.Text = "Purchases";
            // 
            // purchases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(purchase);
            Controls.Add(dataGridViewPurchase);
            Name = "purchases";
            Size = new Size(1540, 922);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPurchase).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPurchase;
        private Label purchase;
    }
}
