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
        private void FILLDGV()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM sales";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
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
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true; // Prevent editing in the DataGridView directly
            }

            // Fit the columns to the content width
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Change column headers
            dataGridView1.Columns["OrderID"].HeaderText = "Order ID";
            dataGridView1.Columns["Products"].HeaderText = "Products List";
            dataGridView1.Columns["TotalBillAmount"].HeaderText = "Total Bill Amount";


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

        private void sales_Load_1(object sender, EventArgs e)
        {
            FILLDGV();
        }
    }
}
