namespace SuprememartPOS
{
    partial class employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employees));
            dataGridViewEmplyoee = new DataGridView();
            employee = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmplyoee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmplyoee
            // 
            dataGridViewEmplyoee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmplyoee.Location = new Point(16, 73);
            dataGridViewEmplyoee.Margin = new Padding(2, 1, 2, 1);
            dataGridViewEmplyoee.Name = "dataGridViewEmplyoee";
            dataGridViewEmplyoee.RowHeadersWidth = 82;
            dataGridViewEmplyoee.Size = new Size(1494, 749);
            dataGridViewEmplyoee.TabIndex = 6;
            // 
            // employee
            // 
            employee.AutoSize = true;
            employee.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employee.Location = new Point(16, 12);
            employee.Margin = new Padding(2, 0, 2, 0);
            employee.Name = "employee";
            employee.Size = new Size(209, 50);
            employee.TabIndex = 7;
            employee.Text = "Employees";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(230, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 49);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(employee);
            Controls.Add(dataGridViewEmplyoee);
            Name = "employees";
            Size = new Size(1540, 922);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmplyoee).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewEmplyoee;
        private Label employee;
        private PictureBox pictureBox1;
    }
}
