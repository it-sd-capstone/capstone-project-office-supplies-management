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
            txtCategoryId = new TextBox();
            lblProductId = new Label();
            txtProductId = new TextBox();
            SuspendLayout();
            // 
            // btnAddNewProduct
            // 
            btnAddNewProduct.Location = new Point(268, 707);
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
            lblName.Location = new Point(22, 148);
            lblName.Margin = new Padding(6, 0, 6, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(83, 32);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(22, 246);
            lblDescription.Margin = new Padding(6, 0, 6, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(140, 32);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(22, 344);
            lblPrice.Margin = new Padding(6, 0, 6, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(70, 32);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(22, 445);
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
            txtName.Location = new Point(179, 145);
            txtName.Margin = new Padding(6);
            txtName.Name = "txtName";
            txtName.Size = new Size(546, 39);
            txtName.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(179, 243);
            txtDescription.Margin = new Padding(6);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(546, 39);
            txtDescription.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(179, 341);
            txtPrice.Margin = new Padding(6);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(546, 39);
            txtPrice.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(179, 442);
            txtQuantity.Margin = new Padding(6);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(546, 39);
            txtQuantity.TabIndex = 9;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(179, 543);
            txtCategoryId.Margin = new Padding(6);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(546, 39);
            txtCategoryId.TabIndex = 10;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(22, 56);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(131, 32);
            lblProductId.TabIndex = 11;
            lblProductId.Text = "Product ID:";
            // 
            // txtProductId
            // 
            txtProductId.Enabled = false;
            txtProductId.Location = new Point(179, 53);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(200, 39);
            txtProductId.TabIndex = 12;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 865);
            Controls.Add(txtProductId);
            Controls.Add(lblProductId);
            Controls.Add(txtCategoryId);
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
            Margin = new Padding(6);
            Name = "AddProductForm";
            Text = "AddProductForm";
            FormClosed += AddProductForm_FormClosed;
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
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtCategoryId;
        private Label lblProductId;
        private TextBox txtProductId;
        public Button btnAddNewProduct;
    }
}