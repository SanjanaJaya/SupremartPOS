using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuprememartPOS
{
    public partial class Customer : UserControl
    {
        public Customer()
        {
            InitializeComponent();
        }

        private string connectionString = "Server=SANJANAXPRO\\SQLEXPRESS;Database=pos;Integrated Security=True;"; // Connection string

        private void Customer_Load(object sender, EventArgs e)
        {
            LoadCustomerData(); // Load products when the control is loaded
        }
        private void LoadCustomerData()
        {
            string query = "SELECT * FROM customer";

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
                        dataGridView1.DataSource = table; // Bind the data to DataGridView

                        // Make DataGridView columns read-only
                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            column.ReadOnly = true; // Prevent editing in the DataGridView directly
                        }

                        // Fit the columns to the content width
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                        // Change column headers
                        dataGridView1.Columns["customer_id"].HeaderText = "ID";
                        dataGridView1.Columns["first_name"].HeaderText = "First Name";
                        dataGridView1.Columns["last_name"].HeaderText = "Last Name";
                        dataGridView1.Columns["contact_number"].HeaderText = "Contact Number";
                        dataGridView1.Columns["nic_number"].HeaderText = "NIC";

                        // Additional styling (optional)
                        dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10); // Set font
                        dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold); // Header style
                        dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateGray; // Header background color
                        dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White; // Header text color

                        // Set row selection mode to full row
                        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        // Set alternating row styles
                        dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                        dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addcustomer_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream

=======
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
            // Retrieve values from textboxes
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string contactNumber = textBox3.Text;
            string nicNumber = textBox4.Text;

            // Validate input
            if (string.IsNullOrEmpty(firstName) ||
                string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(contactNumber) ||
                string.IsNullOrEmpty(nicNumber))
            {
                MessageBox.Show("Please fill all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox4.Tag == null) // No customer selected, so it's a new customer (insert)
            {
                // Insert new customer
                string query = "INSERT INTO customer (first_name, last_name, contact_number, nic_number) VALUES (@FirstName, @LastName, @ContactNumber, @NicNumber)";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@FirstName", firstName);
                            command.Parameters.AddWithValue("@LastName", lastName);
                            command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                            command.Parameters.AddWithValue("@NicNumber", nicNumber);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Customer added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // A customer is selected, so it's an update
            {
                int customerId = Convert.ToInt32(textBox4.Tag); // Get the customer_id from the Tag
                string query = "UPDATE customer SET first_name = @FirstName, last_name = @LastName, contact_number = @ContactNumber, nic_number = @NicNumber WHERE customer_id = @CustomerId";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@CustomerId", customerId);
                            command.Parameters.AddWithValue("@FirstName", firstName);
                            command.Parameters.AddWithValue("@LastName", lastName);
                            command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                            command.Parameters.AddWithValue("@NicNumber", nicNumber);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Customer updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadCustomerData(); // Refresh DataGridView
<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure the clicked cell is not the header row
            {
                // Get the values from the clicked row and fill the textboxes
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["first_name"].Value.ToString();
                textBox2.Text = row.Cells["last_name"].Value.ToString();
                textBox3.Text = row.Cells["contact_number"].Value.ToString();
                textBox4.Text = row.Cells["nic_number"].Value.ToString();

                // Store the ProductID for future use (for deletion and update)
                textBox4.Tag = row.Cells["customer_id"].Value;

                // Disable textboxes initially to prevent editing
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

<<<<<<< Updated upstream
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
=======
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
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

        private void updateproduct_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }

        private void dltcustomer_Click(object sender, EventArgs e)
        {
            // Validate if a customer is selected
            if (textBox4.Tag == null || !int.TryParse(textBox4.Tag.ToString(), out int customer_id))
            {
                MessageBox.Show("No customer selected for deletion.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Query to delete the customer based on customer_id
            string query = "DELETE FROM customer WHERE customer_id = @CustomerId";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerId", customer_id);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the DataGridView to reflect changes
                LoadCustomerData();

                // Clear the textboxes and reset the Tag
                button4_Click(sender, e); // Reuse the reset button logic to clear inputs
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

<<<<<<< Updated upstream
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }
}
