namespace OfficeSuppliesManagement
{
    public partial class OfficeSuppliesManagement : Form
    {

        public OfficeSuppliesManagement()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightGray;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            this.Visible = false;
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
=======
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
>>>>>>> 7bb66aa359039fa59750fed1f3081654b0da2697
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UpdateProductForm updateProductForm = new UpdateProductForm();
            updateProductForm.ShowDialog();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DisplayProductForm displayProductForm = new DisplayProductForm();
            displayProductForm.ShowDialog();
        }

    }
}
