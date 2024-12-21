namespace SuprememartPOS
{
    partial class addcustomersucess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addcustomersucess));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            sucessbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(541, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 49);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(595, 86);
            label1.Name = "label1";
            label1.Size = new Size(391, 54);
            label1.TabIndex = 11;
            label1.Text = "Add New Customer";
            // 
            // sucessbox
            // 
            sucessbox.BackColor = SystemColors.ScrollBar;
            sucessbox.Font = new Font("Segoe UI", 15F);
            sucessbox.Location = new Point(595, 444);
            sucessbox.Name = "sucessbox";
            sucessbox.Size = new Size(350, 34);
            sucessbox.TabIndex = 13;
            // 
            // addcustomersucess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(sucessbox);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "addcustomersucess";
            Size = new Size(1540, 922);
            Load += addcustomersucess_Load_2;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox sucessbox;
    }
}
