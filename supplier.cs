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
    }
}

