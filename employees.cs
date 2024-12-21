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
    public partial class employees : UserControl
    {
        public employees()
        {
            InitializeComponent();
        }

        private string connectionString = "Server=SANJANAXPRO\\SQLEXPRESS;Database=pos;Integrated Security=True;"; // Connection string

        private void employees_Load(object sender, EventArgs e)
        {
            LoadEmployeesData(); // Load products when the control is loaded
        }
        private void LoadEmployeesData()
        {
            string query = "SELECT * FROM Employee";

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
                        dataGridViewEmplyoee.DataSource = table; // Bind the data to DataGridView

                        // Make DataGridView columns read-only
                        foreach (DataGridViewColumn column in dataGridViewEmplyoee.Columns)
                        {
                            column.ReadOnly = true; // Prevent editing in the DataGridView directly
                        }

                        // Fit the columns to the content width
                        dataGridViewEmplyoee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridViewEmplyoee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                        // Change column headers
                        dataGridViewEmplyoee.Columns["EmployeeID"].HeaderText = "ID";
                        dataGridViewEmplyoee.Columns["Name"].HeaderText = "First Name";
                        dataGridViewEmplyoee.Columns["Position"].HeaderText = "Last Name";
                        dataGridViewEmplyoee.Columns["ContactNumber"].HeaderText = "Contact Number";
                        dataGridViewEmplyoee.Columns["NICNumber"].HeaderText = "NIC";

                        // Additional styling (optional)
                        dataGridViewEmplyoee.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10); // Set font
                        dataGridViewEmplyoee.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold); // Header style
                        dataGridViewEmplyoee.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateGray; // Header background color
                        dataGridViewEmplyoee.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White; // Header text color

                        // Set row selection mode to full row
                        dataGridViewEmplyoee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        // Set alternating row styles
                        dataGridViewEmplyoee.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                        dataGridViewEmplyoee.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewEmplyoee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addemp_Click(object sender, EventArgs e)
        {

        }

        private void updateemp_Click(object sender, EventArgs e)
        {

        }

        private void deleteemp_Click(object sender, EventArgs e)
        {

        }

        private void empfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void emplname_TextChanged(object sender, EventArgs e)
        {

        }

        private void empcon_TextChanged(object sender, EventArgs e)
        {

        }

        private void employees_Load_1(object sender, EventArgs e)
        {

        }
    }
}
