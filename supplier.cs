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
        private string connectionString = "Server=SANJANAXPRO\\SQLEXPRESS;Database=pos;Integrated Security=True;"; // Connection string

        private void supplier_Load(object sender, EventArgs e)
        {
            LoadSupplierData(); // Load products when the control is loaded
        }
        private void LoadSupplierData()
        {
            string query = "SELECT * FROM Supplier";  // Your query
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Open connection

                    // Debugging message
                    MessageBox.Show("Connection opened successfully.");

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        int rowsAffected = adapter.Fill(table);

                        // Debugging message to check if data is being loaded
                        MessageBox.Show($"Rows loaded: {rowsAffected}");

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No data found in Supplier table.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            dataGridViewSuppliers.DataSource = table;  // Bind the data to DataGridView

                            // DataGridView settings
                            foreach (DataGridViewColumn column in dataGridViewSuppliers.Columns)
                            {
                                column.ReadOnly = true;
                            }

                            // Fit the columns
                            dataGridViewSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            dataGridViewSuppliers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                            // Change column headers
                            dataGridViewSuppliers.Columns["SupplierID"].HeaderText = "ID";
                            dataGridViewSuppliers.Columns["SupplierName"].HeaderText = "Supplier Name";
                            dataGridViewSuppliers.Columns["ProductName"].HeaderText = "Product Name";
                            dataGridViewSuppliers.Columns["Size"].HeaderText = "Size";
                            dataGridViewSuppliers.Columns["Quantity"].HeaderText = "Quantity";

                            // Optional styling
                            dataGridViewSuppliers.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
                            dataGridViewSuppliers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
                            dataGridViewSuppliers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateGray;
                            dataGridViewSuppliers.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

                            // Row selection mode
                            dataGridViewSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading suppliers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addcustomer_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
