using System.Data.SqlClient;
using System.Data;

namespace SuprememartPOS
{
    public partial class products : UserControl
    {
        public products()
        {
            InitializeComponent();
        }

        private string connectionString = "Server=SANJANAXPRO\\SQLEXPRESS;Database=pos;Integrated Security=True;"; 

        private void products_Load(object sender, EventArgs e)
        {
            LoadProductsData(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        
        private void LoadProductsData()
        {
            string query = "SELECT * FROM Product";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridViewproducts.DataSource = table; 

                        
                        foreach (DataGridViewColumn column in dataGridViewproducts.Columns)
                        {
                            column.ReadOnly = true; 
                        }

                        
                        dataGridViewproducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridViewproducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                       
                        dataGridViewproducts.Columns["ProductID"].HeaderText = "ID";
                        dataGridViewproducts.Columns["ProductName"].HeaderText = "Product Name";
                        dataGridViewproducts.Columns["Price"].HeaderText = "Price (LKR)";
                        dataGridViewproducts.Columns["Size"].HeaderText = "Size";
                        dataGridViewproducts.Columns["Quantity"].HeaderText = "Quantity";

                        
                        dataGridViewproducts.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10); 
                        dataGridViewproducts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold); 
                        dataGridViewproducts.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateGray; 
                        dataGridViewproducts.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White; 

                        
                        dataGridViewproducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        
                        dataGridViewproducts.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                        dataGridViewproducts.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void dataGridViewproducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
               
                DataGridViewRow row = dataGridViewproducts.Rows[e.RowIndex];
                textBox1.Text = row.Cells["ProductName"].Value.ToString();
                textBox2.Text = row.Cells["Price"].Value.ToString();
                textBox3.Text = row.Cells["Size"].Value.ToString();
                textBox4.Text = row.Cells["Quantity"].Value.ToString();

                
                textBox4.Tag = row.Cells["ProductID"].Value;

                
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string productName = textBox1.Text;
            decimal price;
            string size = textBox3.Text;
            int quantity;

          
            if (string.IsNullOrEmpty(productName) ||
                !decimal.TryParse(textBox2.Text, out price) ||
                !int.TryParse(textBox4.Text, out quantity))
            {
                MessageBox.Show("Please fill all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox4.Tag == null) 
            {
               
                string query = "INSERT INTO Product (ProductName, Price, Size, Quantity) VALUES (@ProductName, @Price, @Size, @Quantity)";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ProductName", productName);
                            command.Parameters.AddWithValue("@Price", price);
                            command.Parameters.AddWithValue("@Size", size);
                            command.Parameters.AddWithValue("@Quantity", quantity);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Product added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                int productId = Convert.ToInt32(textBox4.Tag); 
                string query = "UPDATE Product SET ProductName = @ProductName, Price = @Price, Size = @Size, Quantity = @Quantity WHERE ProductID = @ProductID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ProductID", productId);
                            command.Parameters.AddWithValue("@ProductName", productName);
                            command.Parameters.AddWithValue("@Price", price);
                            command.Parameters.AddWithValue("@Size", size);
                            command.Parameters.AddWithValue("@Quantity", quantity);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Product updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadProductsData();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(textBox4.Tag);

            
            if (productId == 0)
            {
                MessageBox.Show("No product selected for deletion.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "DELETE FROM Product WHERE ProductID = @ProductID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", productId);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Product deleted successfully.");
                LoadProductsData(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;

            
            textBox4.Tag = null;
        }
    }
}
