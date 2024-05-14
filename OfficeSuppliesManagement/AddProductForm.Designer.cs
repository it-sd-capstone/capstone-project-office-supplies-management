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
            xButton3 = new Button();
            SuspendLayout();
            // 
            // btnAddNewProduct
            // 
            btnAddNewProduct.Location = new Point(770, 472);
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
            lblName.Location = new Point(12, 69);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 115);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 161);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(12, 209);
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
            txtName.Location = new Point(96, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(296, 23);
            txtName.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(96, 114);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(296, 23);
            txtDescription.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(96, 160);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(296, 23);
            txtPrice.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(96, 207);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(296, 23);
            txtQuantity.TabIndex = 9;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(12, 26);
            lblProductId.Margin = new Padding(2, 0, 2, 0);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(66, 15);
            lblProductId.TabIndex = 11;
            lblProductId.Text = "Product ID:";
            // 
            // txtProductId
            // 
            txtProductId.Enabled = false;
            txtProductId.Location = new Point(96, 25);
            txtProductId.Margin = new Padding(2, 1, 2, 1);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(110, 23);
            txtProductId.TabIndex = 12;
            // 
            // lblCategoryDesc
            // 
            lblCategoryDesc.AutoSize = true;
            lblCategoryDesc.ForeColor = Color.Red;
            lblCategoryDesc.Location = new Point(12, 297);
            lblCategoryDesc.Name = "lblCategoryDesc";
            lblCategoryDesc.Size = new Size(70, 15);
            lblCategoryDesc.TabIndex = 16;
            lblCategoryDesc.Text = "Description:";
            // 
            // lblCategoryDescText
            // 
            lblCategoryDescText.AutoSize = true;
            lblCategoryDescText.ForeColor = Color.Red;
            lblCategoryDescText.Location = new Point(96, 297);
            lblCategoryDescText.Name = "lblCategoryDescText";
            lblCategoryDescText.Size = new Size(12, 15);
            lblCategoryDescText.TabIndex = 17;
            lblCategoryDescText.Text = "*";
            // 
            // lblSuccessMessage
            // 
            lblSuccessMessage.AutoSize = true;
            lblSuccessMessage.ForeColor = Color.Green;
            lblSuccessMessage.Location = new Point(737, 443);
            lblSuccessMessage.Name = "lblSuccessMessage";
            lblSuccessMessage.Size = new Size(154, 15);
            lblSuccessMessage.TabIndex = 18;
            lblSuccessMessage.Text = "Product added successfully!";
            // 
            // cbCategoryId
            // 
            cbCategoryId.FormattingEnabled = true;
            cbCategoryId.Location = new Point(96, 255);
            cbCategoryId.Margin = new Padding(2, 1, 2, 1);
            cbCategoryId.Name = "cbCategoryId";
            cbCategoryId.Size = new Size(296, 23);
            cbCategoryId.TabIndex = 19;
            cbCategoryId.SelectedIndexChanged += cbCategoryId_SelectedIndexChanged;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(8, 472);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(133, 29);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // xButton3
            // 
            xButton3.ForeColor = SystemColors.ActiveCaptionText;
            xButton3.Location = new Point(259, 467);
            xButton3.Name = "xButton3";
            xButton3.Size = new Size(133, 29);
            xButton3.TabIndex = 28;
            xButton3.Text = "Home";
            xButton3.UseVisualStyleBackColor = true;
            xButton3.Click += xButton3_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 508);
            ControlBox = false;
            Controls.Add(xButton3);
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
        private Button xButton3;
    }
}