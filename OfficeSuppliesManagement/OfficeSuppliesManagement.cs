/*
 
I made the other three forms based on our UI proposal. So although we tested the connection with this form, 
I'd assume this is going to be our home page. Make adjustments as needed and delete this comment.  

*/
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
            productBS.DataSource = productDAO.GetAllProducts();
            dataGridView1.DataSource = productBS;
        }
    }
}
