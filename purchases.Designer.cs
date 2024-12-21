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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            purchs = new Label();
            pictureBox1 = new PictureBox();
            summry = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1494, 265);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(16, 519);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1494, 265);
            dataGridView2.TabIndex = 1;
            // 
            // purchs
            // 
            purchs.AutoSize = true;
            purchs.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purchs.Location = new Point(16, 14);
            purchs.Margin = new Padding(2, 0, 2, 0);
            purchs.Name = "purchs";
            purchs.Size = new Size(194, 50);
            purchs.TabIndex = 6;
            purchs.Text = "Purchases";
            purchs.Click += prodct_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Buying;
            pictureBox1.Location = new Point(215, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // summry
            // 
            summry.AutoSize = true;
            summry.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            summry.Location = new Point(29, 451);
            summry.Margin = new Padding(2, 0, 2, 0);
            summry.Name = "summry";
            summry.Size = new Size(189, 50);
            summry.TabIndex = 8;
            summry.Text = "Summary";
            summry.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Delete_mployee;
            pictureBox2.Location = new Point(1234, 381);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(262, 65);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // purchases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox2);
            Controls.Add(summry);
            Controls.Add(pictureBox1);
            Controls.Add(purchs);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "purchases";
            Size = new Size(1540, 922);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label purchs;
        private PictureBox pictureBox1;
        private Label summry;
        private PictureBox pictureBox2;
    }
}
