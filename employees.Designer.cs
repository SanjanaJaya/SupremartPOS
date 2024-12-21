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
            empnic = new TextBox();
            empcon = new TextBox();
            label5 = new Label();
            label4 = new Label();
            emplname = new TextBox();
            label3 = new Label();
            empfname = new TextBox();
            label2 = new Label();
            updateemp = new Button();
            deleteemp = new Button();
            addemp = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmplyoee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewEmplyoee
            // 
            dataGridViewEmplyoee.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewEmplyoee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmplyoee.Location = new Point(16, 73);
            dataGridViewEmplyoee.Margin = new Padding(2, 1, 2, 1);
            dataGridViewEmplyoee.Name = "dataGridViewEmplyoee";
            dataGridViewEmplyoee.RowHeadersWidth = 82;
            dataGridViewEmplyoee.Size = new Size(1494, 449);
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
            // empnic
            // 
            empnic.BackColor = SystemColors.ScrollBar;
            empnic.Font = new Font("Segoe UI", 15.75F);
            empnic.Location = new Point(237, 799);
            empnic.Name = "empnic";
            empnic.Size = new Size(350, 35);
            empnic.TabIndex = 21;
            // 
            // empcon
            // 
            empcon.BackColor = SystemColors.ScrollBar;
            empcon.Font = new Font("Segoe UI", 15.75F);
            empcon.Location = new Point(237, 730);
            empcon.Name = "empcon";
            empcon.Size = new Size(350, 35);
            empcon.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F);
            label5.Location = new Point(59, 799);
            label5.Name = "label5";
            label5.Size = new Size(135, 30);
            label5.TabIndex = 19;
            label5.Text = "NIC Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F);
            label4.Location = new Point(59, 733);
            label4.Name = "label4";
            label4.Size = new Size(172, 30);
            label4.TabIndex = 18;
            label4.Text = "Contact Number:";
            // 
            // emplname
            // 
            emplname.BackColor = SystemColors.ScrollBar;
            emplname.Font = new Font("Segoe UI", 15.75F);
            emplname.Location = new Point(237, 652);
            emplname.Name = "emplname";
            emplname.Size = new Size(350, 35);
            emplname.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.Location = new Point(59, 657);
            label3.Name = "label3";
            label3.Size = new Size(117, 30);
            label3.TabIndex = 16;
            label3.Text = "Last Name:";
            // 
            // empfname
            // 
            empfname.BackColor = SystemColors.ScrollBar;
            empfname.Font = new Font("Segoe UI", 15.75F);
            empfname.Location = new Point(237, 585);
            empfname.Name = "empfname";
            empfname.Size = new Size(350, 35);
            empfname.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(59, 585);
            label2.Name = "label2";
            label2.Size = new Size(118, 30);
            label2.TabIndex = 14;
            label2.Text = "First Name:";
            // 
            // updateemp
            // 
            updateemp.BackColor = Color.Transparent;
            updateemp.BackgroundImage = (Image)resources.GetObject("updateemp.BackgroundImage");
            updateemp.FlatAppearance.BorderSize = 0;
            updateemp.FlatStyle = FlatStyle.Flat;
            updateemp.Location = new Point(907, 659);
            updateemp.Name = "updateemp";
            updateemp.Size = new Size(254, 54);
            updateemp.TabIndex = 24;
            updateemp.UseVisualStyleBackColor = false;
            // 
            // deleteemp
            // 
            deleteemp.BackColor = Color.Transparent;
            deleteemp.BackgroundImage = (Image)resources.GetObject("deleteemp.BackgroundImage");
            deleteemp.FlatAppearance.BorderSize = 0;
            deleteemp.FlatStyle = FlatStyle.Flat;
            deleteemp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            deleteemp.ForeColor = Color.White;
            deleteemp.Location = new Point(907, 732);
            deleteemp.Margin = new Padding(2, 1, 2, 1);
            deleteemp.Name = "deleteemp";
            deleteemp.Size = new Size(254, 54);
            deleteemp.TabIndex = 23;
            deleteemp.UseVisualStyleBackColor = false;
            // 
            // addemp
            // 
            addemp.BackColor = Color.Transparent;
            addemp.BackgroundImage = (Image)resources.GetObject("addemp.BackgroundImage");
            addemp.FlatAppearance.BorderSize = 0;
            addemp.FlatStyle = FlatStyle.Flat;
            addemp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addemp.ForeColor = Color.White;
            addemp.Location = new Point(907, 587);
            addemp.Margin = new Padding(2, 1, 2, 1);
            addemp.Name = "addemp";
            addemp.Size = new Size(254, 54);
            addemp.TabIndex = 22;
            addemp.UseVisualStyleBackColor = false;
            // 
            // employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(updateemp);
            Controls.Add(deleteemp);
            Controls.Add(addemp);
            Controls.Add(empnic);
            Controls.Add(empcon);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(emplname);
            Controls.Add(label3);
            Controls.Add(empfname);
            Controls.Add(label2);
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
        private TextBox empnic;
        private TextBox empcon;
        private Label label5;
        private Label label4;
        private TextBox emplname;
        private Label label3;
        private TextBox empfname;
        private Label label2;
        private Button updateemp;
        private Button deleteemp;
        private Button addemp;
    }
}
