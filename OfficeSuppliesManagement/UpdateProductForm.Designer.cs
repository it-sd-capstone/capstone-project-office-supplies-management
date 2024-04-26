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
            btnUpdateProduct.Location = new Point(225, 817);
            btnUpdateProduct.Margin = new Padding(6);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(282, 68);
            btnUpdateProduct.TabIndex = 0;
            btnUpdateProduct.Text = "Update Product";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += updateButton_Click;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(22, 19);
            lblProductId.Margin = new Padding(6, 0, 6, 0);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(131, 32);
            lblProductId.TabIndex = 1;
            lblProductId.Text = "Product ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(22, 149);
            lblName.Margin = new Padding(6, 0, 6, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(83, 32);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(22, 275);
            lblDescription.Margin = new Padding(6, 0, 6, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(140, 32);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(22, 414);
            lblPrice.Margin = new Padding(6, 0, 6, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(70, 32);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(22, 561);
            lblQuantity.Margin = new Padding(6, 0, 6, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(111, 32);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "Quantity:";
            // 
            // lblCategoryId
            // 
            lblCategoryId.AutoSize = true;
            lblCategoryId.Location = new Point(22, 691);
            lblCategoryId.Margin = new Padding(6, 0, 6, 0);
            lblCategoryId.Name = "lblCategoryId";
            lblCategoryId.Size = new Size(145, 32);
            lblCategoryId.TabIndex = 6;
            lblCategoryId.Text = "Category ID:";
            // 
            // txtProductId
            // 
            txtProductId.Enabled = false;
            txtProductId.Location = new Point(167, 13);
            txtProductId.Margin = new Padding(6);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(215, 39);
            txtProductId.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(167, 269);
            txtDescription.Margin = new Padding(6);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(505, 39);
            txtDescription.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(167, 143);
            txtName.Margin = new Padding(6);
            txtName.Name = "txtName";
            txtName.Size = new Size(505, 39);
            txtName.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(167, 407);
            txtPrice.Margin = new Padding(6);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(505, 39);
            txtPrice.TabIndex = 10;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(167, 555);
            txtQuantity.Margin = new Padding(6);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(505, 39);
            txtQuantity.TabIndex = 11;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(167, 685);
            txtCategoryId.Margin = new Padding(6);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(505, 39);
            txtCategoryId.TabIndex = 12;
            // 
            // UpdateProductForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 960);
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
            Margin = new Padding(6);
            Name = "UpdateProductForm";
            Text = "Update Product";
            FormClosed += UpdateProductForm_FormClosed;
            Load += UpdateProductForm_Load;
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