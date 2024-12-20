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
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // Shehara
            // 
            Shehara.BackColor = SystemColors.MenuHighlight;
            Shehara.Location = new Point(345, 354);
            Shehara.Margin = new Padding(6, 6, 6, 6);
            Shehara.Name = "Shehara";
            Shehara.Size = new Size(139, 49);
            Shehara.TabIndex = 0;
            Shehara.Text = "Shehara";
            Shehara.UseVisualStyleBackColor = false;
            Shehara.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(812, 384);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(312, 177);
            button1.TabIndex = 1;
            button1.Text = "Pakaya";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(1306, 384);
            checkBox1.Margin = new Padding(6, 6, 6, 6);
            checkBox1.Name = "checkBox1";
<<<<<<< Updated upstream
            checkBox1.Size = new Size(83, 19);
=======
            checkBox1.Size = new Size(159, 36);
>>>>>>> Stashed changes
            checkBox1.TabIndex = 2;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(199, 213);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< Updated upstream
            ClientSize = new Size(1020, 473);
            Controls.Add(monthCalendar1);
=======
            ClientSize = new Size(1894, 1009);
>>>>>>> Stashed changes
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(Shehara);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Shehara;
        private Button button1;
        private CheckBox checkBox1;
        private MonthCalendar monthCalendar1;
    }
}
