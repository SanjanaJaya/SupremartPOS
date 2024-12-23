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
    public partial class sales : UserControl
    {
        public sales()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection("Server=SANJANAXPRO\\SQLEXPRESS;Database=pos;Integrated Security=True;");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewsales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void FILLDGV(string searchQuery = "")
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM sales";

                // If there is a search query, modify the query to include a WHERE clause
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    query += " WHERE OrderID LIKE @SearchQuery";
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

            dataGridView1.Columns["OrderID"].HeaderText = "Order ID";
            dataGridView1.Columns["Products"].HeaderText = "Products List";
            dataGridView1.Columns["TotalBillAmount"].HeaderText = "Total Bill Amount (LKR)";

            dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
        }

        private void sales_Load_1(object sender, EventArgs e)
        {
            FILLDGV();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
