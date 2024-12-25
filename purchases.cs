using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
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
        private SqlConnection con = new SqlConnection("Server=26.63.72.206\\SQLEXPRESS,1433;Database=SuprememartPOSTest;User ID=pos_user;Password=pos;");


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


                if (!string.IsNullOrEmpty(searchQuery))
                {
                    query += " WHERE ProductName LIKE @SearchQuery";
                }

                SqlDataAdapter da = new SqlDataAdapter(query, con);


                if (!string.IsNullOrEmpty(searchQuery))
                {
                    da.SelectCommand.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");
                }

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }


            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true;
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


        private void purchases_Load_1(object sender, EventArgs e)
        {
            FILLDGV();
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
                string searchQuery = textBox1.Text.Trim();

                if (!string.IsNullOrEmpty(searchQuery))
                {
                    FILLDGV(searchQuery);
                }
                else
                {
                    FILLDGV();
                }
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializePurchaseTable()
        {

            purchaseTable = new DataTable();
            purchaseTable.Columns.Add("ProductID", typeof(int));
            purchaseTable.Columns.Add("ProductName", typeof(string));
            purchaseTable.Columns.Add("Price", typeof(decimal));
            purchaseTable.Columns.Add("Size", typeof(string));
            purchaseTable.Columns.Add("Quantity", typeof(int));
            purchaseTable.Columns.Add("Total", typeof(decimal));


            dataGridView2.DataSource = purchaseTable;


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

                    int productId = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
                    string productName = selectedRow.Cells["ProductName"].Value.ToString();
                    decimal price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);
                    string size = selectedRow.Cells["Size"].Value.ToString();


                    DataRow[] existingRows = purchaseTable.Select($"ProductID = {productId}");

                    if (existingRows.Length > 0)
                    {

                        int currentQty = Convert.ToInt32(existingRows[0]["Quantity"]);
                        existingRows[0]["Quantity"] = currentQty + 1;
                        existingRows[0]["Total"] = (currentQty + 1) * price;
                    }
                    else
                    {

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
        private void GeneratePDFBill(string products, decimal totalBillAmount, string filePath, int orderId, decimal discountPercentage, decimal discountAmount, decimal lastAmount)
        {
            try
            {
                string uniqueFileName = $"Bill_{orderId}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
                string uniqueFilePath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(filePath), uniqueFileName);

                using (System.IO.FileStream fs = new System.IO.FileStream(uniqueFilePath, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                {
                    using (iTextSharp.text.Document doc = new iTextSharp.text.Document())
                    {
                        iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs);
                        doc.Open();

                        iTextSharp.text.Font titleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD);
                        iTextSharp.text.Font regularFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12);
                        iTextSharp.text.Font headerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD);

                        
                        doc.Add(new iTextSharp.text.Paragraph("Supreme Mart POS", titleFont) { Alignment = iTextSharp.text.Element.ALIGN_CENTER });
                        doc.Add(new iTextSharp.text.Paragraph($"Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss}", regularFont) { Alignment = iTextSharp.text.Element.ALIGN_CENTER });
                        doc.Add(new iTextSharp.text.Paragraph("\n"));

                       
                        doc.Add(new iTextSharp.text.Paragraph($"Order ID: #{orderId}", headerFont));
                        doc.Add(new iTextSharp.text.Paragraph("\n"));

                       
                        doc.Add(new iTextSharp.text.Paragraph("Products:", headerFont));
                        foreach (DataRow row in purchaseTable.Rows)
                        {
                            string productLine = $"{row["ProductName"]} (Qty: {row["Quantity"]}) - LKR {Convert.ToDecimal(row["Total"]):0.00}";
                            doc.Add(new iTextSharp.text.Paragraph(productLine, regularFont));
                        }

                        doc.Add(new iTextSharp.text.Paragraph("\n"));

                      
                        doc.Add(new iTextSharp.text.Paragraph($"Total Bill Amount: LKR {totalBillAmount:0.00}", headerFont));
                        doc.Add(new iTextSharp.text.Paragraph($"Discount: {discountPercentage}% - LKR {discountAmount:0.00}", headerFont));
                        doc.Add(new iTextSharp.text.Paragraph($"Final Amount: LKR {lastAmount:0.00}", headerFont));

                        doc.Add(new iTextSharp.text.Paragraph("\n\nThank you for shopping with us!", regularFont) { Alignment = iTextSharp.text.Element.ALIGN_CENTER });

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
                using (SqlConnection con = new SqlConnection("Server=26.63.72.206\\SQLEXPRESS,1433;Database=SuprememartPOSTest;User ID=pos_user;Password=pos;"))
                {
                    con.Open();

                   
                    string products = string.Join(", ", purchaseTable.AsEnumerable()
                        .Select(row => $"{row["ProductName"]} (Qty: {row["Quantity"]})"));
                    decimal totalBillAmount = purchaseTable.AsEnumerable()
                        .Sum(row => Convert.ToDecimal(row["Total"]));

                  
                    decimal discountPercentage = 0;
                    decimal discountAmount = 0;
                    decimal lastAmount = totalBillAmount;

                    if (decimal.TryParse(textBox2.Text, out discountPercentage))
                    {
                        discountAmount = (discountPercentage / 100) * totalBillAmount;
                        lastAmount = totalBillAmount - discountAmount;
                    }

                    
                    string query = "INSERT INTO sales (Products, TotalBillAmount, DiscountPercentage, DiscountAmount, LastAmount) OUTPUT INSERTED.OrderID " +
                                   "VALUES (@Products, @TotalBillAmount, @DiscountPercentage, @DiscountAmount, @LastAmount)";
                    int orderId;

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Products", products);
                        cmd.Parameters.AddWithValue("@TotalBillAmount", totalBillAmount);
                        cmd.Parameters.AddWithValue("@DiscountPercentage", discountPercentage);
                        cmd.Parameters.AddWithValue("@DiscountAmount", discountAmount);
                        cmd.Parameters.AddWithValue("@LastAmount", lastAmount);
                        orderId = (int)cmd.ExecuteScalar();
                    }

                  
                    foreach (DataRow row in purchaseTable.Rows)
                    {
                        int productId = Convert.ToInt32(row["ProductID"]);
                        int purchasedQuantity = Convert.ToInt32(row["Quantity"]);

                        string updateQuery = "UPDATE Product SET Quantity = Quantity - @PurchasedQuantity WHERE ProductID = @ProductID";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@PurchasedQuantity", purchasedQuantity);
                            updateCmd.Parameters.AddWithValue("@ProductID", productId);
                            updateCmd.ExecuteNonQuery();
                        }
                    }

                   
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Title = "Save Total Sales Invoice As";
                        saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                        saveFileDialog.FileName = $"TotalSales_{orderId}_{DateTime.Now:yyyyMMddHHmmss}.pdf";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            GeneratePDFBill(products, totalBillAmount, saveFileDialog.FileName, orderId, discountPercentage, discountAmount, lastAmount);

                            MessageBox.Show("Sales data saved and bill generated successfully.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                            purchaseTable.Clear();
                            dataGridView2.Refresh();
                            UpdateTotalPriceLabel();

                            FILLDGV();
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error saving sales data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ApplyDiscount()
        {
            if (decimal.TryParse(textBox2.Text, out decimal discountPercentage))
            {
                decimal totalPrice = purchaseTable.AsEnumerable()
                    .Sum(row => Convert.ToDecimal(row["Total"]));

                decimal discountAmount = (discountPercentage / 100) * totalPrice;
                decimal lastAmount = totalPrice - discountAmount;
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("si-LK");

                labelDiscountPercentage.Text = $"{discountPercentage}%";
                labelDiscountAmount.Text = $" -{discountAmount.ToString("C", culture)}";
                labelLastAmount.Text = $" {lastAmount.ToString("C", culture)}";
            }
            else
            {
                MessageBox.Show("Please enter a valid discount percentage.", "Invalid Discount",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ApplyDiscount();
        }
    }
}



