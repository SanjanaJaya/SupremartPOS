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
            Shehara = new Button();
            button1 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // Shehara
            // 
            Shehara.BackColor = SystemColors.MenuHighlight;
            Shehara.Location = new Point(186, 166);
            Shehara.Name = "Shehara";
            Shehara.Size = new Size(75, 23);
            Shehara.TabIndex = 0;
            Shehara.Text = "Shehara";
            Shehara.UseVisualStyleBackColor = false;
            Shehara.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(437, 180);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(168, 83);
            button1.TabIndex = 1;
            button1.Text = "Pakaya";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(703, 180);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 473);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(Shehara);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Shehara;
        private Button button1;
        private CheckBox checkBox1;
    }
}
