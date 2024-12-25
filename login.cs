using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuprememartPOS
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate login credentials
            string email = textBox1.Text; // Email input from TextBox1
            string password = textBox2.Text; // Password input from TextBox2

            // Check credentials
            if (email == "admin@gmail.com" && password == "123")
            {
                Form1 form1 = new Form1();
                form1.Show();

                this.Hide();

                form1.FormClosed += (s, args) => this.Close();
            }
            else
            {
                // Show an error message if credentials are invalid
                MessageBox.Show("Invalid email or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
