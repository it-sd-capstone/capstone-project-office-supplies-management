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
            lblCategoryDesc = new Label();
            lblCategoryDescText = new Label();
            lblSuccessMessage = new Label();
            btnDisplayProdInfo = new Button();
            cbCategoryId = new ComboBox();
            btnClear = new Button();
            SuspendLayout();
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(1430, 1006);
            btnUpdateProduct.Margin = new Padding(6);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(247, 62);
            btnUpdateProduct.TabIndex = 0;
            btnUpdateProduct.Text = "Update Product";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += updateButton_Click;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(22, 55);
            lblProductId.Margin = new Padding(6, 0, 6, 0);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(131, 32);
            lblProductId.TabIndex = 1;
            lblProductId.Text = "Product ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(22, 147);
            lblName.Margin = new Padding(6, 0, 6, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(83, 32);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(22, 245);
            lblDescription.Margin = new Padding(6, 0, 6, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(140, 32);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(22, 343);
            lblPrice.Margin = new Padding(6, 0, 6, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(70, 32);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(22, 446);
            lblQuantity.Margin = new Padding(6, 0, 6, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(111, 32);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "Quantity:";
            // 
            // lblCategoryId
            // 
            lblCategoryId.AutoSize = true;
            lblCategoryId.Location = new Point(22, 546);
            lblCategoryId.Margin = new Padding(6, 0, 6, 0);
            lblCategoryId.Name = "lblCategoryId";
            lblCategoryId.Size = new Size(145, 32);
            lblCategoryId.TabIndex = 6;
            lblCategoryId.Text = "Category ID:";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(178, 53);
            txtProductId.Margin = new Padding(6);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(201, 39);
            txtProductId.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(178, 243);
            txtDescription.Margin = new Padding(6);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(546, 39);
            txtDescription.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(178, 145);
            txtName.Margin = new Padding(6);
            txtName.Name = "txtName";
            txtName.Size = new Size(546, 39);
            txtName.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(178, 341);
            txtPrice.Margin = new Padding(6);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(546, 39);
            txtPrice.TabIndex = 10;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(178, 442);
            txtQuantity.Margin = new Padding(6);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(546, 39);
            txtQuantity.TabIndex = 11;
            // 
            // lblCategoryDesc
            // 
            lblCategoryDesc.AutoSize = true;
            lblCategoryDesc.ForeColor = Color.Red;
            lblCategoryDesc.Location = new Point(22, 633);
            lblCategoryDesc.Margin = new Padding(6, 0, 6, 0);
            lblCategoryDesc.Name = "lblCategoryDesc";
            lblCategoryDesc.Size = new Size(140, 32);
            lblCategoryDesc.TabIndex = 18;
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
            lblCategoryDescText.TabIndex = 19;
            lblCategoryDescText.Text = "*";
            // 
            // lblSuccessMessage
            // 
            lblSuccessMessage.AutoSize = true;
            lblSuccessMessage.ForeColor = Color.Green;
            lblSuccessMessage.Location = new Point(1346, 945);
            lblSuccessMessage.Margin = new Padding(6, 0, 6, 0);
            lblSuccessMessage.Name = "lblSuccessMessage";
            lblSuccessMessage.Size = new Size(331, 32);
            lblSuccessMessage.TabIndex = 20;
            lblSuccessMessage.Text = "Product updated successfully!";
            // 
            // btnDisplayProdInfo
            // 
            btnDisplayProdInfo.Location = new Point(477, 40);
            btnDisplayProdInfo.Margin = new Padding(6);
            btnDisplayProdInfo.Name = "btnDisplayProdInfo";
            btnDisplayProdInfo.Size = new Size(247, 62);
            btnDisplayProdInfo.TabIndex = 21;
            btnDisplayProdInfo.Text = "Display Info";
            btnDisplayProdInfo.UseVisualStyleBackColor = true;
            btnDisplayProdInfo.Click += btnDisplayProdInfo_Click;
            // 
            // cbCategoryId
            // 
            cbCategoryId.FormattingEnabled = true;
            cbCategoryId.Location = new Point(178, 543);
            cbCategoryId.Name = "cbCategoryId";
            cbCategoryId.Size = new Size(546, 40);
            cbCategoryId.TabIndex = 22;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(15, 1006);
            btnClear.Margin = new Padding(6);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(247, 62);
            btnClear.TabIndex = 23;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // UpdateProductForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1692, 1083);
            ControlBox = false;
            Controls.Add(btnClear);
            Controls.Add(cbCategoryId);
            Controls.Add(btnDisplayProdInfo);
            Controls.Add(lblSuccessMessage);
            Controls.Add(lblCategoryDescText);
            Controls.Add(lblCategoryDesc);
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
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "UpdateProductForm";
            Text = "Update Product";
            Load += UpdateProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblProductId;
        private Label lblName;
        private Label lblDescription;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblCategoryId;
        private TextBox txtProductId;
        public Button btnUpdateProduct;
        public TextBox txtDescription;
        public TextBox txtName;
        public TextBox txtPrice;
        public TextBox txtQuantity;
        private Label lblCategoryDesc;
        private Label lblCategoryDescText;
        private Label lblSuccessMessage;
        public Button btnDisplayProdInfo;
        private ComboBox cbCategoryId;
        public Button btnClear;
    }
}