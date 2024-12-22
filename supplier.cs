using System.Data.SqlClient;
using System.Data;

namespace SuprememartPOS
{
    public partial class supplier : UserControl
    {
        public supplier()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection("Server=SANJANAXPRO\\SQLEXPRESS;Database=pos;Integrated Security=True;");

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure the clicked cell is not the header row
            {
                // Get the values from the clicked row and fill the textboxes
                DataGridViewRow row = dataGridViewSuppliers.Rows[e.RowIndex];
                textBox1.Text = row.Cells["SupplierName"].Value.ToString();
                textBox2.Text = row.Cells["ProductName"].Value.ToString();
                textBox3.Text = row.Cells["Size"].Value.ToString();
                textBox4.Text = row.Cells["Quantity"].Value.ToString();

                // Store the ProductID for future use (for deletion and update)
                textBox4.Tag = row.Cells["SupplierID"].Value;

                // Disable textboxes initially to prevent editing
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }
        }

        private void addcustomer_Click(object sender, EventArgs e)
        {
            string supplierName = textBox1.Text;
            string productName = textBox2.Text;
            string size = textBox3.Text;
            int quantity;

            // Validate input
            if (string.IsNullOrEmpty(supplierName) ||
                string.IsNullOrEmpty(productName) ||
                !int.TryParse(textBox4.Text, out quantity))
            {
                MessageBox.Show("Please fill all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                con.Open();

                if (textBox4.Tag == null) // No supplier selected, so it's a new supplier (insert)
                {
                    // Insert new supplier
                    string query = "INSERT INTO Supplier (SupplierName, ProductName, Size, Quantity) VALUES (@SupplierName, @ProductName, @Size, @Quantity)";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@SupplierName", supplierName);
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@Size", string.IsNullOrEmpty(size) ? (object)DBNull.Value : size); // Allow NULL for Size
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Supplier added successfully.");
                }
                else // A supplier is selected, so it's an update
                {
                    int supplierId = Convert.ToInt32(textBox4.Tag); // Get the SupplierID from the Tag
                    string query = "UPDATE Supplier SET SupplierName = @SupplierName, ProductName = @ProductName, Size = @Size, Quantity = @Quantity WHERE SupplierID = @SupplierID";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@SupplierID", supplierId);
                        command.Parameters.AddWithValue("@SupplierName", supplierName);
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@Size", string.IsNullOrEmpty(size) ? (object)DBNull.Value : size); // Allow NULL for Size
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Supplier updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving supplier data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close(); // Ensure the connection is always closed
            }

            FILLDGV(); // Refresh DataGridView
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Enable textboxes for editing
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int supplierID;

            // Validate SupplierID
            if (textBox4.Tag == null || !int.TryParse(textBox4.Tag.ToString(), out supplierID))
            {
                MessageBox.Show("No supplier selected for deletion.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "DELETE FROM Supplier WHERE SupplierID = @SupplierID";

            try
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@SupplierID", supplierID);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Supplier deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close(); // Ensure the connection is always closed
            }

            FILLDGV(); // Refresh the DataGridView
        }

        private void FILLDGV()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM Supplier";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSuppliers.DataSource = dt; // Bind the DataTable to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close(); // Ensure the connection is always closed
            }
            foreach (DataGridViewColumn column in dataGridViewSuppliers.Columns)
            {
                column.ReadOnly = true; // Prevent editing in the DataGridView directly
            }

            // Fit the columns to the content width
            dataGridViewSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSuppliers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Change column headers
            dataGridViewSuppliers.Columns["SupplierID"].HeaderText = "ID";
            dataGridViewSuppliers.Columns["SupplierName"].HeaderText = "Supplier Name";
            dataGridViewSuppliers.Columns["ProductName"].HeaderText = "Product Name";
            dataGridViewSuppliers.Columns["Size"].HeaderText = "Size";
            dataGridViewSuppliers.Columns["Quantity"].HeaderText = "Quantity";

            // Additional styling (optional)
            dataGridViewSuppliers.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10); // Set font
            dataGridViewSuppliers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold); // Header style
            dataGridViewSuppliers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateGray; // Header background color
            dataGridViewSuppliers.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White; // Header text color

            // Set row selection mode to full row
            dataGridViewSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Set alternating row styles
            dataGridViewSuppliers.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridViewSuppliers.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
        }

        private void supplier_Load(object sender, EventArgs e)
        {
            FILLDGV();
        }

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

