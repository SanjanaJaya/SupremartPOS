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

        private string connectionString = "Server=SANJANAXPRO\\SQLEXPRESS;Database=pos;Integrated Security=True;"; // Connection string

        private void products_Load(object sender, EventArgs e)
        {
            LoadProductsData(); // Load products when the control is loaded
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Your code here for textBox1 TextChanged event
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Your code here for textBox2 TextChanged event
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Your code here for textBox3 TextChanged event
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Your code here for textBox4 TextChanged event
        }

        // Method to load products into the DataGridView
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
                        dataGridViewproducts.DataSource = table; // Bind the data to DataGridView

                        // Make DataGridView columns read-only
                        foreach (DataGridViewColumn column in dataGridViewproducts.Columns)
                        {
                            column.ReadOnly = true; // Prevent editing in the DataGridView directly
                        }

                        // Fit the columns to the content width
                        dataGridViewproducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridViewproducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                        // Change column headers
                        dataGridViewproducts.Columns["ProductID"].HeaderText = "ID";
                        dataGridViewproducts.Columns["ProductName"].HeaderText = "Product Name";
                        dataGridViewproducts.Columns["Price"].HeaderText = "Price (LKR)";
                        dataGridViewproducts.Columns["Size"].HeaderText = "Size";
                        dataGridViewproducts.Columns["Quantity"].HeaderText = "Quantity";

                        // Additional styling (optional)
                        dataGridViewproducts.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10); // Set font
                        dataGridViewproducts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold); // Header style
                        dataGridViewproducts.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateGray; // Header background color
                        dataGridViewproducts.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White; // Header text color

                        // Set row selection mode to full row
                        dataGridViewproducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        // Set alternating row styles
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

        // Handle the click event on the DataGridView row
        private void dataGridViewproducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure the clicked cell is not the header row
            {
                // Get the values from the clicked row and fill the textboxes
                DataGridViewRow row = dataGridViewproducts.Rows[e.RowIndex];
                textBox1.Text = row.Cells["ProductName"].Value.ToString();
                textBox2.Text = row.Cells["Price"].Value.ToString();
                textBox3.Text = row.Cells["Size"].Value.ToString();
                textBox4.Text = row.Cells["Quantity"].Value.ToString();

                // Store the ProductID for future use (for deletion and update)
                textBox4.Tag = row.Cells["ProductID"].Value;

                // Disable textboxes initially to prevent editing
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }
        }

        // Add or Update button click event
        private void button1_Click(object sender, EventArgs e)
        {
            string productName = textBox1.Text;
            decimal price;
            string size = textBox3.Text;
            int quantity;

            // Validate input
            if (string.IsNullOrEmpty(productName) ||
                !decimal.TryParse(textBox2.Text, out price) ||
                !int.TryParse(textBox4.Text, out quantity))
            {
                MessageBox.Show("Please fill all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox4.Tag == null) // No product selected, so it's a new product (insert)
            {
                // Insert new product
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
            else // A product is selected, so it's an update
            {
                int productId = Convert.ToInt32(textBox4.Tag); // Get the ProductID from the Tag
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

            LoadProductsData(); // Refresh DataGridView
        }

        // Update button click event (Enable textboxes for editing)
        private void button2_Click(object sender, EventArgs e)
        {
            // Enable textboxes for editing
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }

        // Delete button click event
        private void button3_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(textBox4.Tag); // Get the ProductID from the Tag

            // Validate ProductID
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
                LoadProductsData(); // Refresh DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear all fields and reset
        private void button4_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            // Enable textboxes to allow typing again
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;

            // Reset ProductID tag
            textBox4.Tag = null;
        }
    }
}
