namespace OfficeSuppliesManagement
{
    partial class UpdateProductForm
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
            btnUpdateProduct = new Button();
            lblProductId = new Label();
            lblName = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblCategoryId = new Label();
            txtProductId = new TextBox();
            txtDescription = new TextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtCategoryId = new TextBox();
            SuspendLayout();
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(317, 385);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(152, 32);
            btnUpdateProduct.TabIndex = 0;
            btnUpdateProduct.Text = "Update Product";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += updateButton_Click;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(12, 9);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(66, 15);
            lblProductId.TabIndex = 1;
            lblProductId.Text = "Product ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 70);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 129);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 194);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(12, 263);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(56, 15);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "Quantity:";
            // 
            // lblCategoryId
            // 
            lblCategoryId.AutoSize = true;
            lblCategoryId.Location = new Point(12, 324);
            lblCategoryId.Name = "lblCategoryId";
            lblCategoryId.Size = new Size(72, 15);
            lblCategoryId.TabIndex = 6;
            lblCategoryId.Text = "Category ID:";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(90, 6);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(274, 23);
            txtProductId.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(90, 126);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(274, 23);
            txtDescription.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(90, 67);
            txtName.Name = "txtName";
            txtName.Size = new Size(274, 23);
            txtName.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(90, 191);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(274, 23);
            txtPrice.TabIndex = 10;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(90, 260);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(274, 23);
            txtQuantity.TabIndex = 11;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(90, 321);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(274, 23);
            txtCategoryId.TabIndex = 12;
            // 
            // UpdateProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCategoryId);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtDescription);
            Controls.Add(txtProductId);
            Controls.Add(lblCategoryId);
            Controls.Add(lblQuantity);
            Controls.Add(lblPrice);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(lblProductId);
            Controls.Add(btnUpdateProduct);
            Name = "UpdateProductForm";
            Text = "Update Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdateProduct;
        private Label lblProductId;
        private Label lblName;
        private Label lblDescription;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblCategoryId;
        private TextBox txtProductId;
        private TextBox txtDescription;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtCategoryId;
    }
}