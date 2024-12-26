using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace SuprememartPOS
{
    public partial class products : UserControl
    {
        public products()
        {
            InitializeComponent();
        }

        private string connectionString = "Server=26.63.72.206\\SQLEXPRESS,1433;Database=SuprememartPOSTest;User ID=pos_user;Password=pos;";

        private void products_Load(object sender, EventArgs e)
        {
            LoadProductsData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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


        private void LoadProductsData()
        {
            string query = "SELECT * FROM Product";

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
                        dataGridViewproducts.DataSource = table;


                        foreach (DataGridViewColumn column in dataGridViewproducts.Columns)
                        {
                            column.ReadOnly = true;
                        }


                        dataGridViewproducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridViewproducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


                        dataGridViewproducts.Columns["ProductID"].HeaderText = "ID";
                        dataGridViewproducts.Columns["ProductName"].HeaderText = "Product Name";
                        dataGridViewproducts.Columns["Price"].HeaderText = "Price (LKR)";
                        dataGridViewproducts.Columns["Size"].HeaderText = "Size";
                        dataGridViewproducts.Columns["Quantity"].HeaderText = "Quantity";


                        dataGridViewproducts.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
                        dataGridViewproducts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
                        dataGridViewproducts.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateGray;
                        dataGridViewproducts.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;


                        dataGridViewproducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


                        dataGridViewproducts.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                        dataGridViewproducts.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridViewproducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridViewproducts.Rows[e.RowIndex];
                textBox1.Text = row.Cells["ProductName"].Value.ToString();
                textBox2.Text = row.Cells["Price"].Value.ToString();
                textBox3.Text = row.Cells["Size"].Value.ToString();
                textBox4.Text = row.Cells["Quantity"].Value.ToString();


                textBox4.Tag = row.Cells["ProductID"].Value;


                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }
        }

        //Add New Product
        private void button1_Click(object sender, EventArgs e)
        {
            string productName = textBox1.Text;
            decimal price;
            string size = textBox3.Text;
            int quantity;


            if (string.IsNullOrEmpty(productName) ||
                !decimal.TryParse(textBox2.Text, out price) ||
                !int.TryParse(textBox4.Text, out quantity))
            {
                MessageBox.Show("Please fill all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox4.Tag == null)
            {

                string query = "INSERT INTO Product (ProductName, Price, Size, Quantity) VALUES (@ProductName, @Price, @Size, @Quantity)";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ProductName", productName);
                            command.Parameters.AddWithValue("@Price", price);
                            command.Parameters.AddWithValue("@Size", size);
                            command.Parameters.AddWithValue("@Quantity", quantity);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Product added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int productId = Convert.ToInt32(textBox4.Tag);
                string query = "UPDATE Product SET ProductName = @ProductName, Price = @Price, Size = @Size, Quantity = @Quantity WHERE ProductID = @ProductID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ProductID", productId);
                            command.Parameters.AddWithValue("@ProductName", productName);
                            command.Parameters.AddWithValue("@Price", price);
                            command.Parameters.AddWithValue("@Size", size);
                            command.Parameters.AddWithValue("@Quantity", quantity);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Product updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadProductsData();
        }

        //Update Product Will Unlock All Textboxes & The User Can Type Anything and Click Add New Product Again
        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }

        //Delete Product
        private void button3_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(textBox4.Tag);


            if (productId == 0)
            {
                MessageBox.Show("No product selected for deletion.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "DELETE FROM Product WHERE ProductID = @ProductID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", productId);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Product deleted successfully.");
                LoadProductsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Clear All Fields(This Will Clear All Input Text Boxes)
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


        //Generate Stock Report
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    
                    DataTable productTable = new DataTable();
                    using (SqlCommand command = new SqlCommand("SELECT ProductID, ProductName, Price, Size, Quantity FROM Product", con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(productTable);
                    }

                    if (productTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No products found to generate a report.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                        saveFileDialog.Title = "Save Product List";
                        saveFileDialog.FileName = $"ProductList_{DateTime.Now:yyyyMMddHHmmss}.pdf";

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
                                    doc.Add(new iTextSharp.text.Paragraph("Product List", titleFont) { Alignment = iTextSharp.text.Element.ALIGN_CENTER });
                                    doc.Add(new iTextSharp.text.Paragraph($"\nGenerated on: {DateTime.Now:yyyy-MM-dd HH:mm:ss}\n\n"));

                                    
                                    iTextSharp.text.pdf.PdfPTable table = new iTextSharp.text.pdf.PdfPTable(5)
                                    {
                                        WidthPercentage = 100
                                    };

                                    
                                    table.SetWidths(new float[] { 15, 30, 20, 15, 20 });

                                    
                                    string[] columnNames = { "Product ID", "Product Name", "Price", "Size", "Quantity" };
                                    foreach (string columnName in columnNames)
                                    {
                                        iTextSharp.text.pdf.PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(columnName))
                                        {
                                            BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY,
                                            HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER
                                        };
                                        table.AddCell(cell);
                                    }

                                    
                                    foreach (DataRow row in productTable.Rows)
                                    {
                                        table.AddCell(new iTextSharp.text.Phrase(row["ProductID"].ToString()));
                                        table.AddCell(new iTextSharp.text.Phrase(row["ProductName"].ToString()));
                                        table.AddCell(new iTextSharp.text.Phrase(string.Format("{0:C2}", row["Price"])));
                                        table.AddCell(new iTextSharp.text.Phrase(row["Size"].ToString()));
                                        table.AddCell(new iTextSharp.text.Phrase(row["Quantity"].ToString()));
                                    }

                                    
                                    doc.Add(table);

                                    
                                    doc.Close();
                                }
                            }

                            
                            MessageBox.Show($"Product list saved successfully at {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating product list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

