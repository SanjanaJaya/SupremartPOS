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
        private SqlConnection con = new SqlConnection("Server=26.63.72.206\\SQLEXPRESS,1433;Database=SuprememartPOSTest;User ID=pos_user;Password=pos;");


        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridViewSuppliers.Rows[e.RowIndex];
                textBox1.Text = row.Cells["SupplierName"].Value.ToString();
                textBox2.Text = row.Cells["ProductName"].Value.ToString();
                textBox3.Text = row.Cells["Size"].Value.ToString();
                textBox4.Text = row.Cells["Quantity"].Value.ToString();


                textBox4.Tag = row.Cells["SupplierID"].Value;


                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }
        }

        //Add Supplier
        private void addcustomer_Click(object sender, EventArgs e)
        {
            string supplierName = textBox1.Text;
            string productName = textBox2.Text;
            string size = textBox3.Text;
            string quantityText = textBox4.Text;


            if (string.IsNullOrEmpty(supplierName) ||
                string.IsNullOrEmpty(productName) ||
                string.IsNullOrEmpty(quantityText))
            {
                MessageBox.Show("Please fill all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int quantity;
            if (!int.TryParse(quantityText, out quantity) || quantity < 1)
            {
                MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                con.Open();

                if (textBox4.Tag == null)
                {

                    string query = "INSERT INTO Supplier (SupplierName, ProductName, Size, Quantity) VALUES (@SupplierName, @ProductName, @Size, @Quantity)";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@SupplierName", supplierName);
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@Size", size ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Quantity", quantity);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Supplier added successfully.");
                }
                else
                {
                    int supplierId = Convert.ToInt32(textBox4.Tag);
                    string query = "UPDATE Supplier SET SupplierName = @SupplierName, ProductName = @ProductName, Size = @Size, Quantity = @Quantity WHERE SupplierID = @SupplierID";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@SupplierID", supplierId);
                        command.Parameters.AddWithValue("@SupplierName", supplierName);
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@Size", size ?? (object)DBNull.Value);
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
                con.Close();
            }

            FILLDGV();
        }

        //Update Supplier Will Unlock All Textboxes & The User Can Type Anything and Click Add New Product Again
        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }

        //Delete Supplier
        private void button1_Click(object sender, EventArgs e)
        {
            int supplierID;


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
                con.Close();
            }

            FILLDGV();
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
                dataGridViewSuppliers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            foreach (DataGridViewColumn column in dataGridViewSuppliers.Columns)
            {
                column.ReadOnly = true;
            }


            dataGridViewSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSuppliers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            dataGridViewSuppliers.Columns["SupplierID"].HeaderText = "ID";
            dataGridViewSuppliers.Columns["SupplierName"].HeaderText = "Supplier Name";
            dataGridViewSuppliers.Columns["ProductName"].HeaderText = "Product Name";
            dataGridViewSuppliers.Columns["Size"].HeaderText = "Size";
            dataGridViewSuppliers.Columns["Quantity"].HeaderText = "Quantity";


            dataGridViewSuppliers.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            dataGridViewSuppliers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
            dataGridViewSuppliers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewSuppliers.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;


            dataGridViewSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            dataGridViewSuppliers.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridViewSuppliers.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
        }

        private void supplier_Load(object sender, EventArgs e)
        {
            FILLDGV();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();


            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;


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
        //Generate Suppliers List
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                
                con.Open();

                
                DataTable supplierTable = new DataTable();
                using (SqlCommand command = new SqlCommand("SELECT SupplierID, SupplierName, ProductName, Size, Quantity FROM Supplier", con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(supplierTable);
                }

                if (supplierTable.Rows.Count == 0)
                {
                    MessageBox.Show("No suppliers found to generate a report.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Save Supplier List";
                    saveFileDialog.FileName = $"SupplierList_{DateTime.Now:yyyyMMddHHmmss}.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        
                        using (System.IO.FileStream fs = new System.IO.FileStream(filePath, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                        {
                            using (iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4))
                            {
                                iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs);
                                doc.Open();

                                
                                string logoPath = "path/to/your/logo.png"; 
                                if (System.IO.File.Exists(logoPath))
                                {
                                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                                    logo.ScaleToFit(100f, 100f);
                                    logo.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                                    doc.Add(logo);
                                }

                                
                                iTextSharp.text.Font titleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD);
                                doc.Add(new iTextSharp.text.Paragraph("Suprememart POS", titleFont) { Alignment = iTextSharp.text.Element.ALIGN_CENTER });
                                doc.Add(new iTextSharp.text.Paragraph("Supplier List", titleFont) { Alignment = iTextSharp.text.Element.ALIGN_CENTER });
                                doc.Add(new iTextSharp.text.Paragraph($"\nGenerated on: {DateTime.Now:yyyy-MM-dd HH:mm:ss}\n\n"));

                               
                                iTextSharp.text.pdf.PdfPTable table = new iTextSharp.text.pdf.PdfPTable(5)
                                {
                                    WidthPercentage = 100
                                };

                                
                                table.SetWidths(new float[] { 15, 30, 30, 15, 10 });

                                
                                string[] columnNames = { "Supplier ID", "Supplier Name", "Product Name", "Size", "Quantity" };
                                foreach (string columnName in columnNames)
                                {
                                    iTextSharp.text.pdf.PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(columnName))
                                    {
                                        BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY,
                                        HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER
                                    };
                                    table.AddCell(cell);
                                }

                                
                                foreach (DataRow row in supplierTable.Rows)
                                {
                                    table.AddCell(new iTextSharp.text.Phrase(row["SupplierID"].ToString()));
                                    table.AddCell(new iTextSharp.text.Phrase(row["SupplierName"].ToString()));
                                    table.AddCell(new iTextSharp.text.Phrase(row["ProductName"].ToString()));
                                    table.AddCell(new iTextSharp.text.Phrase(row["Size"].ToString()));
                                    table.AddCell(new iTextSharp.text.Phrase(row["Quantity"].ToString()));
                                }

                               
                                doc.Add(table);

                            
                                doc.Close();
                            }
                        }

                      
                        MessageBox.Show($"Supplier list saved successfully at {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating supplier list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}

