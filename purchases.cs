using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


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
        private void UpdateTotalPriceLabel()
        {
            decimal totalPrice = 0;

            foreach (DataRow row in purchaseTable.Rows)
            {
                totalPrice += Convert.ToDecimal(row["Total"]);
            }

            // Specify "si-LK" culture for Sri Lankan Rupees
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("si-LK");
            label2.Text = $" {totalPrice.ToString("C", culture)}";
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
                dataGridView1.Refresh();
                dataGridView2.Refresh();
                UpdateTotalPriceLabel();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete the selected items?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    for (int i = dataGridView2.SelectedRows.Count - 1; i >= 0; i--)
                    {
                        dataGridView2.Rows.Remove(dataGridView2.SelectedRows[i]);
                    }

                    UpdateTotalPriceLabel();
                }
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void GeneratePDFBill(string products, decimal totalBillAmount, string filePath, int orderId)
        {
            try
            {
                // Create a unique file name using the order ID and timestamp
                string uniqueFileName = $"Bill_{orderId}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
                string uniqueFilePath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(filePath), uniqueFileName);

                // Create a new PDF document
                using (System.IO.FileStream fs = new System.IO.FileStream(uniqueFilePath, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                {
                    using (iTextSharp.text.Document doc = new iTextSharp.text.Document())
                    {
                        iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs);
                        doc.Open();

                        // Define fonts
                        iTextSharp.text.Font titleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD);
                        iTextSharp.text.Font regularFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12);
                        iTextSharp.text.Font headerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD);

                        // Add Title
                        doc.Add(new iTextSharp.text.Paragraph("Supreme Mart POS", titleFont) { Alignment = iTextSharp.text.Element.ALIGN_CENTER });
                        doc.Add(new iTextSharp.text.Paragraph($"Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss}", regularFont) { Alignment = iTextSharp.text.Element.ALIGN_CENTER });
                        doc.Add(new iTextSharp.text.Paragraph("\n"));

                        // Add Order ID with #
                        doc.Add(new iTextSharp.text.Paragraph($"Order ID: #{orderId}", headerFont) { Alignment = iTextSharp.text.Element.ALIGN_LEFT });
                        doc.Add(new iTextSharp.text.Paragraph("\n"));

                        // Add product details
                        doc.Add(new iTextSharp.text.Paragraph("Products:", headerFont) { Alignment = iTextSharp.text.Element.ALIGN_LEFT });
                        foreach (DataRow row in purchaseTable.Rows)
                        {
                            string productLine = $"{row["ProductName"]} (Qty: {row["Quantity"]}) - LKR {Convert.ToDecimal(row["Total"]):0.00}";
                            doc.Add(new iTextSharp.text.Paragraph(productLine, regularFont));
                        }

                        // Add total amount
                        doc.Add(new iTextSharp.text.Paragraph("\n", regularFont)); // Blank line
                        doc.Add(new iTextSharp.text.Paragraph($"Total Bill Amount: LKR {totalBillAmount:0.00}", headerFont) { Alignment = iTextSharp.text.Element.ALIGN_RIGHT });

                        // Add footer
                        doc.Add(new iTextSharp.text.Paragraph("\n\nThank you for shopping with us!", regularFont) { Alignment = iTextSharp.text.Element.ALIGN_CENTER });

                        // Close the document
                        doc.Close();
                    }
                }

                MessageBox.Show($"Bill successfully saved to {uniqueFilePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }










        private void button4_Click(object sender, EventArgs e)
        {
            if (purchaseTable.Rows.Count == 0)
            {
                MessageBox.Show("No products in the purchase list to save.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Open the connection at the start of the method
                using (SqlConnection con = new SqlConnection("Server=SANJANAXPRO\\SQLEXPRESS;Database=pos;Integrated Security=True;"))
                {
                    con.Open();

                    // Prepare the data for insertion
                    string products = string.Join(", ", purchaseTable.AsEnumerable()
                        .Select(row => $"{row["ProductName"]} (Qty: {row["Quantity"]})"));
                    decimal totalBillAmount = purchaseTable.AsEnumerable()
                        .Sum(row => Convert.ToDecimal(row["Total"]));

                    // Insert data into the sales table and get the OrderID
                    string query = "INSERT INTO sales (Products, TotalBillAmount) OUTPUT INSERTED.OrderID VALUES (@Products, @TotalBillAmount)";
                    int orderId;

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Products", products);
                        cmd.Parameters.AddWithValue("@TotalBillAmount", totalBillAmount);
                        orderId = (int)cmd.ExecuteScalar(); // Get the inserted OrderID
                    }

                    // Loop through the purchased products and update the quantity in the Product table
                    foreach (DataRow row in purchaseTable.Rows)
                    {
                        int productId = Convert.ToInt32(row["ProductID"]);
                        int purchasedQuantity = Convert.ToInt32(row["Quantity"]);

                        // Update the Product table to deduct the purchased quantity
                        string updateQuery = "UPDATE Product SET Quantity = Quantity - @PurchasedQuantity WHERE ProductID = @ProductID";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@PurchasedQuantity", purchasedQuantity);
                            updateCmd.Parameters.AddWithValue("@ProductID", productId);
                            updateCmd.ExecuteNonQuery(); // Execute the update
                        }
                    }

                    // Use SaveFileDialog to select the save location
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "PDF Files|*.pdf",
                        Title = "Save Bill"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Generate the PDF bill with a unique file name
                        GeneratePDFBill(products, totalBillAmount, saveFileDialog.FileName, orderId);
                    }

                    MessageBox.Show("Sales data saved and bill generated successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the purchaseTable after saving
                    purchaseTable.Clear();
                    dataGridView2.Refresh();
                    UpdateTotalPriceLabel();

                    // Refresh DataGridView1 to show updated inventory
                    FILLDGV();  // This will reload the data from the database to DataGridView1
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving sales data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}



