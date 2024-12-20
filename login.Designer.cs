namespace SuprememartPOS
{
    partial class login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label5;
            Label label1;
            Label label2;
            Label label3;
            Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            loginbtn = new Panel();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            loginbtn.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(140, 404);
            label5.Name = "label5";
            label5.Size = new Size(627, 128);
            label5.TabIndex = 3;
            label5.Text = "SUPREMART";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(284, 532);
            label1.Name = "label1";
            label1.Size = new Size(301, 65);
            label1.TabIndex = 4;
            label1.Text = "POS SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(189, 46);
            label2.Name = "label2";
            label2.Size = new Size(356, 65);
            label2.TabIndex = 4;
            label2.Text = "ADMIN LOGIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(66, 222);
            label3.Name = "label3";
            label3.Size = new Size(116, 45);
            label3.TabIndex = 6;
            label3.Text = "E-Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(66, 363);
            label4.Name = "label4";
            label4.Size = new Size(163, 45);
            label4.TabIndex = 8;
            label4.Text = "Password";
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.Transparent;
            loginbtn.BackgroundImage = (Image)resources.GetObject("loginbtn.BackgroundImage");
            loginbtn.Controls.Add(button1);
            loginbtn.Controls.Add(label4);
            loginbtn.Controls.Add(textBox2);
            loginbtn.Controls.Add(label3);
            loginbtn.Controls.Add(textBox1);
            loginbtn.Controls.Add(label2);
            loginbtn.Location = new Point(946, 168);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(745, 734);
            loginbtn.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(280, 510);
            button1.Name = "button1";
            button1.Size = new Size(174, 66);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(66, 411);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(617, 46);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(66, 270);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(617, 46);
            textBox1.TabIndex = 5;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(loginbtn);
            Controls.Add(label1);
            Controls.Add(label5);
            Name = "login";
            Text = "login";
            loginbtn.ResumeLayout(false);
            loginbtn.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel loginbtn;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}