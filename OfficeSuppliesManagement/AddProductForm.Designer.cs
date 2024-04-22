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
            SuspendLayout();
            // 
            // btnAddNewProduct
            // 
            btnAddNewProduct.Location = new Point(335, 369);
            btnAddNewProduct.Name = "btnAddNewProduct";
            btnAddNewProduct.Size = new Size(133, 29);
            btnAddNewProduct.TabIndex = 0;
            btnAddNewProduct.Text = "Add Product";
            btnAddNewProduct.UseVisualStyleBackColor = true;
            btnAddNewProduct.Click += btnAddNewProduct_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 71);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 131);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(12, 191);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(56, 15);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity:";
            // 
            // lblCategoryId
            // 
            lblCategoryId.AutoSize = true;
            lblCategoryId.Location = new Point(12, 256);
            lblCategoryId.Name = "lblCategoryId";
            lblCategoryId.Size = new Size(72, 15);
            lblCategoryId.TabIndex = 5;
            lblCategoryId.Text = "Category ID:";
            // 
            // txtName
            // 
            txtName.Location = new Point(90, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(296, 23);
            txtName.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(90, 68);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(296, 23);
            txtDescription.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(90, 128);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(296, 23);
            txtPrice.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(90, 188);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(296, 23);
            txtQuantity.TabIndex = 9;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(90, 253);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(296, 23);
            txtCategoryId.TabIndex = 10;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "AddProductForm";
            Text = "AddProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddNewProduct;
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
    }
}