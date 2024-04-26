namespace OfficeSuppliesManagement
{
    public partial class OfficeSuppliesManagement : Form
    {

        public OfficeSuppliesManagement()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
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
