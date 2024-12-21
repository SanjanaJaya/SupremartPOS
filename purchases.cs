using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SuprememartPOS
{
    public partial class purchases : UserControl
    {
        public purchases()
        {
            InitializeComponent();
        }

        private string connectionString = "Server=SANJANAXPRO\\SQLEXPRESS;Database=pos;Integrated Security=True;"; // Connection string

        // This method will be used to load data into the DataGridView
        private void LoadData()
        {
            // Query to fetch data from the Product table
            string query = "SELECT * FROM Product";

            try
            {
                // Establish connection with SQL Server
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Open the connection

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();  // A DataTable to hold the fetched data

                        // Fill the DataTable with data
                        adapter.Fill(table);

                        // Bind the data to the DataGridView
                        dataGridView1.DataSource = table;

                        // Optional: Format the DataGridView columns (make them read-only and adjust other properties)
                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            column.ReadOnly = true; // Prevent editing
                        }

                        // Fit the columns to the width of their content
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    }
                }
            }
            catch (Exception ex)
            {
                // If there is an error, display a message box
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // This event is triggered when the user control is loaded
        private void purchases_Load(object sender, EventArgs e)
        {
            LoadData(); // Load data into the DataGridView when the control loads
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click event if needed
        }
    }
}
