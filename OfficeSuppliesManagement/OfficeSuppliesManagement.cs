namespace OfficeSuppliesManagement
{
    public partial class OfficeSuppliesManagement : Form
    {
        BindingSource productBS = new BindingSource();

        public OfficeSuppliesManagement()
        {
            InitializeComponent();
        }

        // Button for testing the database connection
        private void button1_Click(object sender, EventArgs e)
        {
            DAO productDAO = new DAO();

            // Connect the database to the gridview
            productBS.DataSource = productDAO.getAllProducts();
            dataGridView1.DataSource = productBS;
        }
    }
}
