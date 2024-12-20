namespace SuprememartPOS
{
    partial class addcustomer
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
            dataGridViewaddcus = new DataGridView();
            adcust = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewaddcus).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewaddcus
            // 
            dataGridViewaddcus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewaddcus.Location = new Point(16, 74);
            dataGridViewaddcus.Margin = new Padding(2, 0, 2, 0);
            dataGridViewaddcus.Name = "dataGridViewaddcus";
            dataGridViewaddcus.RowHeadersWidth = 82;
            dataGridViewaddcus.Size = new Size(1494, 749);
            dataGridViewaddcus.TabIndex = 4;
            // 
            // adcust
            // 
            adcust.AutoSize = true;
            adcust.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            adcust.Location = new Point(16, 28);
            adcust.Margin = new Padding(2, 0, 2, 0);
            adcust.Name = "adcust";
            adcust.Size = new Size(146, 28);
            adcust.TabIndex = 5;
            adcust.Text = "Add Customer";
            adcust.Click += label1_Click;
            // 
            // addcustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(adcust);
            Controls.Add(dataGridViewaddcus);
            Margin = new Padding(2, 1, 2, 1);
            Name = "addcustomer";
            Size = new Size(1540, 922);
            ((System.ComponentModel.ISupportInitialize)dataGridViewaddcus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewaddcus;
        private Label adcust;
    }
}
