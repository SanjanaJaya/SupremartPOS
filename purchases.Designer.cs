
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(purchases));
            dataGridViewPurchases = new DataGridView();
            purchaseslabel = new Label();
            pictureBox1 = new PictureBox();
            productlistlabel = new Label();
            currentorderlabel = new Label();
            searchbar = new TextBox();
            search = new Button();
            addtoorder = new Button();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPurchases).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPurchases
            // 
            dataGridViewPurchases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPurchases.Location = new Point(16, 98);
            dataGridViewPurchases.Margin = new Padding(2, 1, 2, 1);
            dataGridViewPurchases.Name = "dataGridViewPurchases";
            dataGridViewPurchases.RowHeadersWidth = 82;
            dataGridViewPurchases.Size = new Size(1494, 302);
            dataGridViewPurchases.TabIndex = 5;
            dataGridViewPurchases.CellContentClick += dataGridViewPurchase_CellContentClick;
            // 
            // purchaseslabel
            // 
            purchaseslabel.AutoSize = true;
            purchaseslabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            purchaseslabel.Location = new Point(16, 12);
            purchaseslabel.Margin = new Padding(2, 0, 2, 0);
            purchaseslabel.Name = "purchaseslabel";
            purchaseslabel.Size = new Size(194, 50);
            purchaseslabel.TabIndex = 6;
            purchaseslabel.Text = "Purchases";
            purchaseslabel.Click += purchase_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(215, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 49);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // productlistlabel
            // 
            productlistlabel.AutoSize = true;
            productlistlabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productlistlabel.Location = new Point(19, 55);
            productlistlabel.Name = "productlistlabel";
            productlistlabel.Size = new Size(156, 37);
            productlistlabel.TabIndex = 11;
            productlistlabel.Text = "Product List";
            productlistlabel.Click += label1_Click;
            // 
            // currentorderlabel
            // 
            currentorderlabel.AutoSize = true;
            currentorderlabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentorderlabel.Location = new Point(19, 472);
            currentorderlabel.Name = "currentorderlabel";
            currentorderlabel.Size = new Size(180, 37);
            currentorderlabel.TabIndex = 12;
            currentorderlabel.Text = "Current Order";
            // 
            // searchbar
            // 
            searchbar.BackColor = Color.Silver;
            searchbar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchbar.Location = new Point(629, 49);
            searchbar.Name = "searchbar";
            searchbar.Size = new Size(374, 43);
            searchbar.TabIndex = 13;
            searchbar.TextChanged += textBox1_TextChanged;
            // 
            // search
            // 
            search.BackColor = Color.Transparent;
            search.BackgroundImage = (Image)resources.GetObject("search.BackgroundImage");
            search.FlatAppearance.BorderSize = 0;
            search.FlatStyle = FlatStyle.Flat;
            search.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            search.ForeColor = Color.White;
            search.Location = new Point(1025, 53);
            search.Margin = new Padding(2, 1, 2, 1);
            search.Name = "search";
            search.Size = new Size(42, 37);
            search.TabIndex = 23;
            search.UseVisualStyleBackColor = false;
            search.Click += addcustomer_Click;
            // 
            // addtoorder
            // 
            addtoorder.BackColor = Color.Transparent;
            addtoorder.BackgroundImage = (Image)resources.GetObject("addtoorder.BackgroundImage");
            addtoorder.FlatAppearance.BorderSize = 0;
            addtoorder.FlatStyle = FlatStyle.Flat;
            addtoorder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addtoorder.ForeColor = Color.White;
            addtoorder.Location = new Point(611, 419);
            addtoorder.Margin = new Padding(2, 1, 2, 1);
            addtoorder.Name = "addtoorder";
            addtoorder.Size = new Size(254, 54);
            addtoorder.TabIndex = 24;
            addtoorder.UseVisualStyleBackColor = false;
            addtoorder.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(183, 850);
            label3.Name = "label3";
            label3.Size = new Size(80, 37);
            label3.TabIndex = 25;
            label3.Text = "Total:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 519);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1494, 302);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // purchases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(addtoorder);
            Controls.Add(search);
            Controls.Add(searchbar);
            Controls.Add(currentorderlabel);
            Controls.Add(productlistlabel);
            Controls.Add(pictureBox1);
            Controls.Add(purchaseslabel);
            Controls.Add(dataGridViewPurchases);
            Name = "purchases";
            Size = new Size(1540, 922);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPurchases).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView dataGridViewPurchases;
        private Label purchaseslabel;
        private PictureBox pictureBox1;
        private Label productlistlabel;
        private Label currentorderlabel;
        private TextBox searchbar;
        private Button search;
        private Button addtoorder;
        private Label label3;
        private DataGridView dataGridView1;
    }
}
