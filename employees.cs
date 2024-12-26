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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SuprememartPOS
{
    public partial class employees : UserControl
    {
        public employees()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection("Server=26.63.72.206\\SQLEXPRESS,1433;Database=SuprememartPOSTest;User ID=pos_user;Password=pos;");



        private void dataGridViewEmplyoee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dataGridViewEmplyoee.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Name"].Value.ToString();
                textBox2.Text = row.Cells["Position"].Value.ToString();
                textBox3.Text = row.Cells["ContactNumber"].Value.ToString();
                textBox4.Text = row.Cells["NICNumber"].Value.ToString();


                textBox4.Tag = row.Cells["EmployeeID"].Value;


                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
            }

        }
        //Add New Employee
        private void addemp_Click(object sender, EventArgs e)
        {
            {
                string employeeName = textBox1.Text;
                string position = textBox2.Text;
                string contactNumber = textBox3.Text;
                string nicNumber = textBox4.Text;


                if (string.IsNullOrEmpty(employeeName) ||
                    string.IsNullOrEmpty(position) ||
                    string.IsNullOrEmpty(contactNumber) ||
                    string.IsNullOrEmpty(nicNumber))
                {
                    MessageBox.Show("Please fill all fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    con.Open();

                    if (textBox4.Tag == null)
                    {

                        string query = "INSERT INTO Employee (Name, Position, ContactNumber, NICNumber) VALUES (@Name, @Position, @ContactNumber, @NICNumber)";
                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            command.Parameters.AddWithValue("@Name", employeeName);
                            command.Parameters.AddWithValue("@Position", position);
                            command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                            command.Parameters.AddWithValue("@NICNumber", nicNumber);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Employee added successfully.");
                    }
                    else
                    {
                        int employeeId = Convert.ToInt32(textBox4.Tag);
                        string query = "UPDATE Employee SET Name = @Name, Position = @Position, ContactNumber = @ContactNumber, NICNumber = @NICNumber WHERE EmployeeID = @EmployeeID";
                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            command.Parameters.AddWithValue("@EmployeeID", employeeId);
                            command.Parameters.AddWithValue("@Name", employeeName);
                            command.Parameters.AddWithValue("@Position", position);
                            command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                            command.Parameters.AddWithValue("@NICNumber", nicNumber);
                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Employee updated successfully.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving employee data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }

                FILLDGV();
            }
        }
        //Update Emplooye Will Unlock All Textboxes & The User Can Type Anything and Click Add New Product Again
        private void updateemp_Click(object sender, EventArgs e)
        {

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }
        //Delete Employee
        private void deleteemp_Click(object sender, EventArgs e)
        {
            int employeeID;


            if (textBox4.Tag == null || !int.TryParse(textBox4.Tag.ToString(), out employeeID))
            {
                MessageBox.Show("No employee selected for deletion.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";

            try
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Employee deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            FILLDGV();
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
            FILLDGV();
        }

        private void FILLDGV()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM Employee";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewEmplyoee.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            foreach (DataGridViewColumn column in dataGridViewEmplyoee.Columns)
            {
                column.ReadOnly = true;
            }


            dataGridViewEmplyoee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmplyoee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            dataGridViewEmplyoee.Columns["EmployeeID"].HeaderText = "ID";
            dataGridViewEmplyoee.Columns["Name"].HeaderText = "Name";
            dataGridViewEmplyoee.Columns["Position"].HeaderText = "Position";
            dataGridViewEmplyoee.Columns["ContactNumber"].HeaderText = "Contact Number";
            dataGridViewEmplyoee.Columns["NICNumber"].HeaderText = "NIC";


            dataGridViewEmplyoee.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            dataGridViewEmplyoee.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold);
            dataGridViewEmplyoee.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewEmplyoee.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;


            dataGridViewEmplyoee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            dataGridViewEmplyoee.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridViewEmplyoee.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Generate Employees List
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                con.Open();

               
                DataTable employeeTable = new DataTable();
                using (SqlCommand command = new SqlCommand("SELECT EmployeeID, Name, Position, ContactNumber, NICNumber FROM Employee", con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(employeeTable);
                }

                if (employeeTable.Rows.Count == 0)
                {
                    MessageBox.Show("No employees found to generate a report.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

               
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Save Employee List";
                    saveFileDialog.FileName = $"EmployeeList_{DateTime.Now:yyyyMMddHHmmss}.pdf";

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
                                doc.Add(new iTextSharp.text.Paragraph("Employee List", titleFont) { Alignment = iTextSharp.text.Element.ALIGN_CENTER });
                                doc.Add(new iTextSharp.text.Paragraph($"\nGenerated on: {DateTime.Now:yyyy-MM-dd HH:mm:ss}\n\n"));

                                
                                iTextSharp.text.pdf.PdfPTable table = new iTextSharp.text.pdf.PdfPTable(5)
                                {
                                    WidthPercentage = 100
                                };

                                
                                table.SetWidths(new float[] { 10, 30, 30, 20, 20 });

                               
                                string[] columnNames = { "ID", "Name", "Position", "Contact Number", "NIC Number" };
                                foreach (string columnName in columnNames)
                                {
                                    iTextSharp.text.pdf.PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(columnName))
                                    {
                                        BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY,
                                        HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER
                                    };
                                    table.AddCell(cell);
                                }

                               
                                foreach (DataRow row in employeeTable.Rows)
                                {
                                    table.AddCell(new iTextSharp.text.Phrase(row["EmployeeID"].ToString()));
                                    table.AddCell(new iTextSharp.text.Phrase(row["Name"].ToString()));
                                    table.AddCell(new iTextSharp.text.Phrase(row["Position"].ToString()));
                                    table.AddCell(new iTextSharp.text.Phrase(row["ContactNumber"].ToString()));
                                    table.AddCell(new iTextSharp.text.Phrase(row["NICNumber"].ToString()));
                                }

                                
                                doc.Add(table);

                               
                                doc.Close();
                            }
                        }

                       
                        MessageBox.Show($"Employee list saved successfully at {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating employee list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
