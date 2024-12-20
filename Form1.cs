namespace SuprememartPOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void LoadControlToPanel4(UserControl control)
        {
            panel4.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel4.Controls.Add(control);
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Employees_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();


            employees employeesControl = new employees
            {
                Dock = DockStyle.Fill
            };


            panel4.Controls.Add(employeesControl);
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sales_Click(object sender, EventArgs e)
        {

            panel4.Controls.Clear();


            sales salesControl = new sales
            {
                Dock = DockStyle.Fill
            };


            panel4.Controls.Add(salesControl);
        }

        private void Suppliers_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();


            supplier supplierControl = new supplier
            {
                Dock = DockStyle.Fill
            };


            panel4.Controls.Add(supplierControl);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
