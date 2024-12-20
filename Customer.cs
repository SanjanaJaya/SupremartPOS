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
    public partial class Customer : UserControl
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addcustomer_Click(object sender, EventArgs e)
        {
            // Create the AddCustomer user control
            addcustomer addCustomerControl = new addcustomer();

            // Access the parent Form and call the method to replace the panel content
            Form1 parentForm = (Form1)this.FindForm();
            parentForm.LoadControlToPanel4(addCustomerControl);
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
