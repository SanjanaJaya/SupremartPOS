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
        private SqlConnection con = new SqlConnection("Server=26.63.72.206\\SQLEXPRESS,1433;Database=SuprememartPOSTest;User ID=pos_user;Password=pos;");


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

               
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    query += " WHERE OrderID LIKE @SearchQuery";
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

            dataGridView1.Columns["OrderID"].HeaderText = "Order ID";
            dataGridView1.Columns["Products"].HeaderText = "Products List";
            dataGridView1.Columns["TotalBillAmount"].HeaderText = "Order Amount(LKR)";
            dataGridView1.Columns["DiscountPercentage"].HeaderText = "Discount (%)";
            dataGridView1.Columns["DiscountAmount"].HeaderText = "Discount Amount";
            dataGridView1.Columns["LastAmount"].HeaderText = "Total Bill Amount (LKR)";

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int startOrderId, endOrderId;

                
                if (!int.TryParse(textBox2.Text.Trim(), out startOrderId) || !int.TryParse(textBox3.Text.Trim(), out endOrderId))
                {
                    MessageBox.Show("Please enter valid numeric values for the order range.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (startOrderId > endOrderId)
                {
                    MessageBox.Show("Start Order ID cannot be greater than End Order ID.", "Invalid Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                string query = @"SELECT OrderID, Products, LastAmount FROM sales 
                         WHERE OrderID BETWEEN @StartOrderId AND @EndOrderId";

                DataTable dt = new DataTable();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StartOrderId", startOrderId);
                    cmd.Parameters.AddWithValue("@EndOrderId", endOrderId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No orders found for the given range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

               
                decimal totalAmount = dt.AsEnumerable().Sum(row => row.Field<decimal>("LastAmount"));

               
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Save Total Sales Invoice As";
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"TotalSales_{startOrderId}_to_{endOrderId}_{DateTime.Now:yyyyMMddHHmmss}.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;

                        using (System.IO.FileStream fs = new System.IO.FileStream(filePath, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                        {
                            using (iTextSharp.text.Document doc = new iTextSharp.text.Document())
                            {
                                iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs);
                                doc.Open();

                              
                                iTextSharp.text.Font titleFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD);
                                iTextSharp.text.Font headerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.BOLD);
                                iTextSharp.text.Font regularFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12);

                            
                                doc.Add(new iTextSharp.text.Paragraph("Total Sales Invoice", titleFont) { Alignment = iTextSharp.text.Element.ALIGN_CENTER });
                                doc.Add(new iTextSharp.text.Paragraph($"Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss}", regularFont) { Alignment = iTextSharp.text.Element.ALIGN_CENTER });
                                doc.Add(new iTextSharp.text.Paragraph($"Order Range: {startOrderId} to {endOrderId}", regularFont) { Alignment = iTextSharp.text.Element.ALIGN_CENTER });
                                doc.Add(new iTextSharp.text.Paragraph("\n"));

                               
                                iTextSharp.text.pdf.PdfPTable table = new iTextSharp.text.pdf.PdfPTable(3);
                                table.WidthPercentage = 100;
                                table.SetWidths(new float[] { 1, 4, 2 }); 

                              
                                table.AddCell(new iTextSharp.text.Phrase("Order ID", headerFont));
                                table.AddCell(new iTextSharp.text.Phrase("Products", headerFont));
                                table.AddCell(new iTextSharp.text.Phrase("Total Amount (LKR)", headerFont));

                               
                                foreach (DataRow row in dt.Rows)
                                {
                                    table.AddCell(new iTextSharp.text.Phrase(row["OrderID"].ToString(), regularFont));
                                    table.AddCell(new iTextSharp.text.Phrase(row["Products"].ToString(), regularFont));
                                    table.AddCell(new iTextSharp.text.Phrase(Convert.ToDecimal(row["LastAmount"]).ToString("0.00"), regularFont));
                                }

                              
                                doc.Add(table);

                               
                                doc.Add(new iTextSharp.text.Paragraph("\n"));
                                doc.Add(new iTextSharp.text.Paragraph($"Total Amount: LKR {totalAmount:0.00}", headerFont) { Alignment = iTextSharp.text.Element.ALIGN_RIGHT });

                              
                                doc.Add(new iTextSharp.text.Paragraph("\n\nThank you for choosing SupremeMart!", regularFont) { Alignment = iTextSharp.text.Element.ALIGN_CENTER });

                                doc.Close();
                            }
                        }

                        MessageBox.Show($"Invoice successfully saved to {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating total sales invoice: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {
            ;
        }


    }
}
