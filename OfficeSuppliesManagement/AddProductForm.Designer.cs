namespace OfficeSuppliesManagement
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddNewProduct = new Button();
            lblName = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblCategoryId = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            lblProductId = new Label();
            txtProductId = new TextBox();
            lblCategoryDesc = new Label();
            lblCategoryDescText = new Label();
            lblSuccessMessage = new Label();
            cbCategoryId = new ComboBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btnAddNewProduct
            // 
            btnAddNewProduct.Location = new Point(1430, 1006);
            btnAddNewProduct.Margin = new Padding(6);
            btnAddNewProduct.Name = "btnAddNewProduct";
            btnAddNewProduct.Size = new Size(247, 62);
            btnAddNewProduct.TabIndex = 0;
            btnAddNewProduct.Text = "Add Product";
            btnAddNewProduct.UseVisualStyleBackColor = true;
            btnAddNewProduct.Click += btnAddNewProduct_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(22, 147);
            lblName.Margin = new Padding(6, 0, 6, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(83, 32);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(22, 245);
            lblDescription.Margin = new Padding(6, 0, 6, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(140, 32);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(22, 343);
            lblPrice.Margin = new Padding(6, 0, 6, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(70, 32);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(22, 446);
            lblQuantity.Margin = new Padding(6, 0, 6, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(111, 32);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity:";
            // 
            // lblCategoryId
            // 
            lblCategoryId.AutoSize = true;
            lblCategoryId.Location = new Point(22, 546);
            lblCategoryId.Margin = new Padding(6, 0, 6, 0);
            lblCategoryId.Name = "lblCategoryId";
            lblCategoryId.Size = new Size(145, 32);
            lblCategoryId.TabIndex = 5;
            lblCategoryId.Text = "Category ID:";
            // 
            // txtName
            // 
            txtName.Location = new Point(178, 145);
            txtName.Margin = new Padding(6);
            txtName.Name = "txtName";
            txtName.Size = new Size(546, 39);
            txtName.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(178, 243);
            txtDescription.Margin = new Padding(6);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(546, 39);
            txtDescription.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(178, 341);
            txtPrice.Margin = new Padding(6);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(546, 39);
            txtPrice.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(178, 442);
            txtQuantity.Margin = new Padding(6);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(546, 39);
            txtQuantity.TabIndex = 9;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(22, 55);
            lblProductId.Margin = new Padding(4, 0, 4, 0);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(131, 32);
            lblProductId.TabIndex = 11;
            lblProductId.Text = "Product ID:";
            // 
            // txtProductId
            // 
            txtProductId.Enabled = false;
            txtProductId.Location = new Point(178, 53);
            txtProductId.Margin = new Padding(4, 2, 4, 2);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(201, 39);
            txtProductId.TabIndex = 12;
            // 
            // lblCategoryDesc
            // 
            lblCategoryDesc.AutoSize = true;
            lblCategoryDesc.ForeColor = Color.Red;
            lblCategoryDesc.Location = new Point(22, 633);
            lblCategoryDesc.Margin = new Padding(6, 0, 6, 0);
            lblCategoryDesc.Name = "lblCategoryDesc";
            lblCategoryDesc.Size = new Size(140, 32);
            lblCategoryDesc.TabIndex = 16;
            lblCategoryDesc.Text = "Description:";
            // 
            // lblCategoryDescText
            // 
            lblCategoryDescText.AutoSize = true;
            lblCategoryDescText.ForeColor = Color.Red;
            lblCategoryDescText.Location = new Point(178, 633);
            lblCategoryDescText.Margin = new Padding(6, 0, 6, 0);
            lblCategoryDescText.Name = "lblCategoryDescText";
            lblCategoryDescText.Size = new Size(24, 32);
            lblCategoryDescText.TabIndex = 17;
            lblCategoryDescText.Text = "*";
            // 
            // lblSuccessMessage
            // 
            lblSuccessMessage.AutoSize = true;
            lblSuccessMessage.ForeColor = Color.Green;
            lblSuccessMessage.Location = new Point(1368, 945);
            lblSuccessMessage.Margin = new Padding(6, 0, 6, 0);
            lblSuccessMessage.Name = "lblSuccessMessage";
            lblSuccessMessage.Size = new Size(309, 32);
            lblSuccessMessage.TabIndex = 18;
            lblSuccessMessage.Text = "Product added successfully!";
            // 
            // cbCategoryId
            // 
            cbCategoryId.FormattingEnabled = true;
            cbCategoryId.Location = new Point(178, 543);
            cbCategoryId.Name = "cbCategoryId";
            cbCategoryId.Size = new Size(546, 40);
            cbCategoryId.TabIndex = 19;
            cbCategoryId.SelectedIndexChanged += cbCategoryId_SelectedIndexChanged;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(15, 1006);
            btnClear.Margin = new Padding(6);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(247, 62);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1692, 1083);
            ControlBox = false;
            Controls.Add(btnClear);
            Controls.Add(cbCategoryId);
            Controls.Add(lblSuccessMessage);
            Controls.Add(lblCategoryDescText);
            Controls.Add(lblCategoryDesc);
            Controls.Add(txtProductId);
            Controls.Add(lblProductId);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(lblCategoryId);
            Controls.Add(lblQuantity);
            Controls.Add(lblPrice);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(btnAddNewProduct);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "AddProductForm";
            Text = "Add Product";
            Load += AddProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private Label lblDescription;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblCategoryId;
        private Label lblProductId;
        private TextBox txtProductId;
        public Button btnAddNewProduct;
        public TextBox txtName;
        public TextBox txtDescription;
        public TextBox txtPrice;
        public TextBox txtQuantity;
        private Label lblCategoryDesc;
        private Label lblCategoryDescText;
        private Label lblSuccessMessage;
        private ComboBox cbCategoryId;
        public Button btnClear;
    }
}