using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SuprememartPOS
{
    public partial class purchases : UserControl
    {
        private DataTable purchaseTable;
        public purchases()
        {
            InitializeComponent();
            InitializePurchaseTable();
        }
        private SqlConnection con = new SqlConnection("Server=SANJANAXPRO\\SQLEXPRESS;Database=pos;Integrated Security=True;");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void prodct_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void FILLDGV(string searchQuery = "")
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM Product";

                // If there is a search query, modify the query to include a WHERE clause
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    query += " WHERE ProductName LIKE @SearchQuery";
                }

                SqlDataAdapter da = new SqlDataAdapter(query, con);

                // If searching, add the parameter to the query
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    da.SelectCommand.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");
                }

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt; // Bind the DataTable to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close(); // Ensure the connection is always closed
            }

            // Style the DataGridView
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true; // Prevent editing in the DataGridView directly
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView1.Columns["ProductID"].HeaderText = "ID";
            dataGridView1.Columns["ProductName"].HeaderText = "Product Name";
            dataGridView1.Columns["Price"].HeaderText = "Price (LKR)";
            dataGridView1.Columns["Size"].HeaderText = "Size";
            dataGridView1.Columns["Quantity"].HeaderText = "Quantity";

            dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
        }

        // Load event to initialize the DataGridView
        private void purchases_Load_1(object sender, EventArgs e)
        {
            FILLDGV(); // Load all products initially
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string searchQuery = textBox1.Text.Trim(); // Get the search term from textBox1

                if (!string.IsNullOrEmpty(searchQuery))
                {
                    FILLDGV(searchQuery); // Call FILLDGV with search query to filter products
                }
                else
                {
                    FILLDGV(); // If no search term, load all products
                }
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializePurchaseTable()
        {
            // Create a new DataTable for dataGridView2
            purchaseTable = new DataTable();
            purchaseTable.Columns.Add("ProductID", typeof(int));
            purchaseTable.Columns.Add("ProductName", typeof(string));
            purchaseTable.Columns.Add("Price", typeof(decimal));
            purchaseTable.Columns.Add("Size", typeof(string));
            purchaseTable.Columns.Add("Quantity", typeof(int));
            purchaseTable.Columns.Add("Total", typeof(decimal));

            // Bind the DataTable to dataGridView2
            dataGridView2.DataSource = purchaseTable;

            // Style dataGridView2
            StylePurchaseDataGridView();
        }

        private void StylePurchaseDataGridView()
        {
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dataGridView2.Columns["ProductID"].HeaderText = "ID";
            dataGridView2.Columns["ProductName"].HeaderText = "Product Name";
            dataGridView2.Columns["Price"].HeaderText = "Price (LKR)";
            dataGridView2.Columns["Size"].HeaderText = "Size";
            dataGridView2.Columns["Quantity"].HeaderText = "Quantity";
            dataGridView2.Columns["Total"].HeaderText = "Total (LKR)";

            dataGridView2.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            dataGridView2.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridView2.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a product first.", "No Selection",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                {
                    // Get the values from the selected row
                    int productId = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
                    string productName = selectedRow.Cells["ProductName"].Value.ToString();
                    decimal price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);
                    string size = selectedRow.Cells["Size"].Value.ToString();

                    // Check if product already exists in purchaseTable
                    DataRow[] existingRows = purchaseTable.Select($"ProductID = {productId}");

                    if (existingRows.Length > 0)
                    {
                        // Update quantity if product already exists
                        int currentQty = Convert.ToInt32(existingRows[0]["Quantity"]);
                        existingRows[0]["Quantity"] = currentQty + 1;
                        existingRows[0]["Total"] = (currentQty + 1) * price;
                    }
                    else
                    {
                        // Add new row if product doesn't exist
                        DataRow newRow = purchaseTable.NewRow();
                        newRow["ProductID"] = productId;
                        newRow["ProductName"] = productName;
                        newRow["Price"] = price;
                        newRow["Size"] = size;
                        newRow["Quantity"] = 1;
                        newRow["Total"] = price;
                        purchaseTable.Rows.Add(newRow);
                    }
                }

                // Refresh the display
                dataGridView2.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // If items are selected in dataGridView2, delete them
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete the selected items?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Remove selected rows in reverse order
                    for (int i = dataGridView2.SelectedRows.Count - 1; i >= 0; i--)
                    {
                        dataGridView2.Rows.Remove(dataGridView2.SelectedRows[i]);
                    }
                }
                return;
            }

            // If items are selected in dataGridView1, add them
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                {
                    // Get the values from the selected row
                    int productId = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
                    string productName = selectedRow.Cells["ProductName"].Value.ToString();
                    decimal price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);
                    string size = selectedRow.Cells["Size"].Value.ToString();

                    // Check if product already exists in dataGridView2
                    bool productExists = false;
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (row.Cells["ProductID"].Value != null &&
                            Convert.ToInt32(row.Cells["ProductID"].Value) == productId)
                        {
                            // Update quantity if product exists
                            int currentQty = Convert.ToInt32(row.Cells["Quantity"].Value);
                            row.Cells["Quantity"].Value = currentQty + 1;
                            row.Cells["Total"].Value = (currentQty + 1) * price;
                            productExists = true;
                            break;
                        }
                    }

                    if (!productExists)
                    {
                        // Add new row if product doesn't exist
                        int rowIndex = dataGridView2.Rows.Add();
                        DataGridViewRow newRow = dataGridView2.Rows[rowIndex];
                        newRow.Cells["ProductID"].Value = productId;
                        newRow.Cells["ProductName"].Value = productName;
                        newRow.Cells["Price"].Value = price;
                        newRow.Cells["Size"].Value = size;
                        newRow.Cells["Quantity"].Value = 1;
                        newRow.Cells["Total"].Value = price;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataGridView2.Refresh();
        }
    }
}


