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
            xButton2 = new Button();
            SuspendLayout();
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(770, 472);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(133, 29);
            btnUpdateProduct.TabIndex = 0;
            btnUpdateProduct.Text = "Update Product";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += updateButton_Click;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(12, 26);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(66, 15);
            lblProductId.TabIndex = 1;
            lblProductId.Text = "Product ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 69);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 115);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 161);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(36, 15);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(12, 209);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(56, 15);
            lblQuantity.TabIndex = 5;
            lblQuantity.Text = "Quantity:";
            // 
            // lblCategoryId
            // 
            lblCategoryId.AutoSize = true;
            lblCategoryId.Location = new Point(12, 256);
            lblCategoryId.Name = "lblCategoryId";
            lblCategoryId.Size = new Size(72, 15);
            lblCategoryId.TabIndex = 6;
            lblCategoryId.Text = "Category ID:";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(96, 25);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(110, 23);
            txtProductId.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(96, 114);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(296, 23);
            txtDescription.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(96, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(296, 23);
            txtName.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(96, 160);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(296, 23);
            txtPrice.TabIndex = 10;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(96, 207);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(296, 23);
            txtQuantity.TabIndex = 11;
            // 
            // lblCategoryDesc
            // 
            lblCategoryDesc.AutoSize = true;
            lblCategoryDesc.ForeColor = Color.Red;
            lblCategoryDesc.Location = new Point(12, 297);
            lblCategoryDesc.Name = "lblCategoryDesc";
            lblCategoryDesc.Size = new Size(70, 15);
            lblCategoryDesc.TabIndex = 18;
            lblCategoryDesc.Text = "Description:";
            // 
            // lblCategoryDescText
            // 
            lblCategoryDescText.AutoSize = true;
            lblCategoryDescText.ForeColor = Color.Red;
            lblCategoryDescText.Location = new Point(96, 297);
            lblCategoryDescText.Name = "lblCategoryDescText";
            lblCategoryDescText.Size = new Size(12, 15);
            lblCategoryDescText.TabIndex = 19;
            lblCategoryDescText.Text = "*";
            // 
            // lblSuccessMessage
            // 
            lblSuccessMessage.AutoSize = true;
            lblSuccessMessage.ForeColor = Color.Green;
            lblSuccessMessage.Location = new Point(725, 443);
            lblSuccessMessage.Name = "lblSuccessMessage";
            lblSuccessMessage.Size = new Size(165, 15);
            lblSuccessMessage.TabIndex = 20;
            lblSuccessMessage.Text = "Product updated successfully!";
            // 
            // btnDisplayProdInfo
            // 
            btnDisplayProdInfo.Location = new Point(257, 19);
            btnDisplayProdInfo.Name = "btnDisplayProdInfo";
            btnDisplayProdInfo.Size = new Size(133, 29);
            btnDisplayProdInfo.TabIndex = 21;
            btnDisplayProdInfo.Text = "Display Info";
            btnDisplayProdInfo.UseVisualStyleBackColor = true;
            btnDisplayProdInfo.Click += btnDisplayProdInfo_Click;
            // 
            // cbCategoryId
            // 
            cbCategoryId.FormattingEnabled = true;
            cbCategoryId.Location = new Point(96, 255);
            cbCategoryId.Margin = new Padding(2, 1, 2, 1);
            cbCategoryId.Name = "cbCategoryId";
            cbCategoryId.Size = new Size(296, 23);
            cbCategoryId.TabIndex = 22;
            cbCategoryId.SelectedIndexChanged += cbCategoryId_SelectedIndexChanged;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(8, 472);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(133, 29);
            btnClear.TabIndex = 23;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // xButton2
            // 
            xButton2.ForeColor = SystemColors.ActiveCaptionText;
            xButton2.Location = new Point(257, 472);
            xButton2.Name = "xButton2";
            xButton2.Size = new Size(129, 29);
            xButton2.TabIndex = 27;
            xButton2.Text = "Home";
            xButton2.UseVisualStyleBackColor = true;
            xButton2.Click += xButton2_Click;
            // 
            // UpdateProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 508);
            ControlBox = false;
            Controls.Add(xButton2);
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
        private Button xButton2;
    }
}