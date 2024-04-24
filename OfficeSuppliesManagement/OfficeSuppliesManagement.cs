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
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightGray;
        }

        // Button for testing the database connection
        private void button1_Click(object sender, EventArgs e)
        {
            DAO productDAO = new DAO();
            try
            {

                // Connect the database to the gridview
                productBS.DataSource = productDAO.GetAllProducts();
                dataGridView1.DataSource = productBS;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
