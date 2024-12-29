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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Sales_Click(object sender, EventArgs e)
        {

        }

        private void Purchases_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();


            purchases purchasesControl = new purchases
            {
                Dock = DockStyle.Fill
            };


            panel4.Controls.Add(purchasesControl);
        }

        private void Products_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();


            products productsControl = new products
            {
                Dock = DockStyle.Fill
            };


            panel4.Controls.Add(productsControl);
        }

        private void Customers_Click(object sender, EventArgs e)
        {

            panel4.Controls.Clear();


            Customer customerControl = new Customer
            {
                Dock = DockStyle.Fill
            };


            panel4.Controls.Add(customerControl);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();


            this.Hide();


            login.FormClosed += (s, args) => this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
