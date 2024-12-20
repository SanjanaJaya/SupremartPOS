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

        }

        private void Customers_Click(object sender, EventArgs e)
        {
            // Clear panel4 of any existing controls
            panel4.Controls.Clear();

            // Instantiate the UserControl
            Customer customerControl = new Customer
            {
                Dock = DockStyle.Fill // Make it fill the panel
            };

            // Add the UserControl to panel4
            panel4.Controls.Add(customerControl);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
