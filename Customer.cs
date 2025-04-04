﻿using System;
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
    public partial class Customer : UserControl
    {
        public Customer()
        {
            InitializeComponent();
        }

        private string connectionString = "Server=26.63.72.206\\SQLEXPRESS,1433;Database=SuprememartPOSTest;User ID=pos_user;Password=pos;";

        private void Customer_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }
        private void LoadCustomerData()
        {
            string query = "SELECT * FROM customer";

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
                        dataGridView1.DataSource = table;


                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            column.ReadOnly = true;
                        }


                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


                        dataGridView1.Columns["customer_id"].HeaderText = "ID";
                        dataGridView1.Columns["first_name"].HeaderText = "First Name";
                        dataGridView1.Columns["last_name"].HeaderText = "Last Name";
                        dataGridView1.Columns["contact_number"].HeaderText = "Contact Number";
                        dataGridView1.Columns["nic_number"].HeaderText = "NIC";


                        dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
                        dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
                        dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateGray;
                        dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;


                        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


                        dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                        dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //Add a New Customer
        private void addcustomer_Click(object sender, EventArgs e)
        {


            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string contactNumber = textBox3.Text;
            string nicNumber = textBox4.Text;


            if (string.IsNullOrEmpty(firstName) ||
                string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(contactNumber) ||
                string.IsNullOrEmpty(nicNumber))
            {
                MessageBox.Show("Please fill all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox4.Tag == null)
            {

                string query = "INSERT INTO customer (first_name, last_name, contact_number, nic_number) VALUES (@FirstName, @LastName, @ContactNumber, @NicNumber)";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@FirstName", firstName);
                            command.Parameters.AddWithValue("@LastName", lastName);
                            command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                            command.Parameters.AddWithValue("@NicNumber", nicNumber);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Customer added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int customerId = Convert.ToInt32(textBox4.Tag);
                string query = "UPDATE customer SET first_name = @FirstName, last_name = @LastName, contact_number = @ContactNumber, nic_number = @NicNumber WHERE customer_id = @CustomerId";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@CustomerId", customerId);
                            command.Parameters.AddWithValue("@FirstName", firstName);
                            command.Parameters.AddWithValue("@LastName", lastName);
                            command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                            command.Parameters.AddWithValue("@NicNumber", nicNumber);
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Customer updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadCustomerData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["first_name"].Value.ToString();
                textBox2.Text = row.Cells["last_name"].Value.ToString();
                textBox3.Text = row.Cells["contact_number"].Value.ToString();
                textBox4.Text = row.Cells["nic_number"].Value.ToString();


                textBox4.Tag = row.Cells["customer_id"].Value;


                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
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
        }

        //Update Customers Will Unlock All Textboxes & The User Can Type Anything and Click Add New Product Again
        private void updateproduct_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }

        //Delete Customers
        private void dltcustomer_Click(object sender, EventArgs e)
        {

            if (textBox4.Tag == null || !int.TryParse(textBox4.Tag.ToString(), out int customer_id))
            {
                MessageBox.Show("No customer selected for deletion.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string query = "DELETE FROM customer WHERE customer_id = @CustomerId";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerId", customer_id);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                LoadCustomerData();


                button4_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Generate Customers List
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataTable customerTable = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT customer_id, first_name, last_name, contact_number, nic_number FROM customer", connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(customerTable);
                    }
                }

                if (customerTable.Rows.Count == 0)
                {
                    MessageBox.Show("No customers found to generate a report.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Save Customer List";
                    saveFileDialog.FileName = $"CustomerList_{DateTime.Now:yyyyMMddHHmmss}.pdf";

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
                                doc.Add(new iTextSharp.text.Paragraph("Customer List", titleFont) { Alignment = iTextSharp.text.Element.ALIGN_CENTER });
                                doc.Add(new iTextSharp.text.Paragraph($"\nGenerated on: {DateTime.Now:yyyy-MM-dd HH:mm:ss}\n\n"));

                                
                                iTextSharp.text.pdf.PdfPTable table = new iTextSharp.text.pdf.PdfPTable(5)
                                {
                                    WidthPercentage = 100
                                };

                                
                                table.SetWidths(new float[] { 10, 25, 25, 20, 20 });

                                
                                string[] columnNames = { "ID", "First Name", "Last Name", "Contact Number", "NIC" };
                                foreach (string columnName in columnNames)
                                {
                                    iTextSharp.text.pdf.PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(columnName))
                                    {
                                        BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY,
                                        HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER
                                    };
                                    table.AddCell(cell);
                                }

                                
                                foreach (DataRow row in customerTable.Rows)
                                {
                                    table.AddCell(new iTextSharp.text.Phrase(row["customer_id"].ToString()));
                                    table.AddCell(new iTextSharp.text.Phrase(row["first_name"].ToString()));
                                    table.AddCell(new iTextSharp.text.Phrase(row["last_name"].ToString()));
                                    table.AddCell(new iTextSharp.text.Phrase(row["contact_number"].ToString()));
                                    table.AddCell(new iTextSharp.text.Phrase(row["nic_number"].ToString()));
                                }

                                
                                doc.Add(table);

                                
                                doc.Close();
                            }
                        }

                        
                        MessageBox.Show($"Customer list saved successfully at {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating customer list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
