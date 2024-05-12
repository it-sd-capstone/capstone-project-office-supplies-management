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
        }

        private void pnlAdd_Click(object sender, EventArgs e)
        {
            // Set border styles to make it obvious which form is active.
            pnlAdd.BorderStyle = BorderStyle.Fixed3D;
            pnlUpdate.BorderStyle = BorderStyle.None;
            pnlDisplay.BorderStyle = BorderStyle.None;

            // Create an instance of the AddProductForm.
            var addForm = new AddProductForm();

            // Suppress default behavior.
            addForm.TopLevel = false;

            // Clear the content panel if there is a form already being displayed
            // when the user switches forms via the menu.
            if (pnlContent.Controls.Count > 0) pnlContent.Controls.Clear();

            // Populate the content panel with the AddProductForm controls.
            pnlContent.Controls.Add(addForm);

            // Display the contents of the content panel.
            addForm.BringToFront();
            addForm.Show();
        }

        private void pnlUpdate_Click(object sender, EventArgs e)
        {
            // Set border styles to make it obvious which form is active.
            pnlAdd.BorderStyle = BorderStyle.None;
            pnlUpdate.BorderStyle = BorderStyle.Fixed3D;
            pnlDisplay.BorderStyle = BorderStyle.None;

            // Create an instance of the EditProductForm.
            var updateForm = new UpdateProductForm();

            // Suppress default behavior.
            updateForm.TopLevel = false;

            // Clear the content panel if there is a form already being displayed
            // when the user switches forms via the menu.
            if (pnlContent.Controls.Count > 0) pnlContent.Controls.Clear();

            // Populate the content panel with the UpdateProductForm controls.
            pnlContent.Controls.Add(updateForm);

            // Display the contents of the content panel.
            updateForm.BringToFront();
            updateForm.Show();
        }

        private void pnlDisplay_Click(object sender, EventArgs e)
        {
            // Set border styles to make it obvious which form is active.
            pnlAdd.BorderStyle = BorderStyle.None;
            pnlUpdate.BorderStyle = BorderStyle.None;
            pnlDisplay.BorderStyle = BorderStyle.Fixed3D;

            // Create an instance of the DisplayProductForm.
            var displayForm = new DisplayProductForm();

            // Suppress default behavior.
            displayForm.TopLevel = false;

            // Clear the content panel if there is a form already being displayed
            // when the user switches forms via the menu.
            if (pnlContent.Controls.Count > 0) pnlContent.Controls.Clear();

            // Populate the content panel with the DisplayProductForm controls.
            pnlContent.Controls.Add(displayForm);

            // Display the contents of the content panel.
            displayForm.BringToFront();
            displayForm.Show();
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            pnlAdd_Click(sender, e);
        }

        private void lblUpdate_Click(object sender, EventArgs e)
        {
            pnlUpdate_Click(sender, e);
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {
            pnlDisplay_Click(sender, e);
        }
    }
}
