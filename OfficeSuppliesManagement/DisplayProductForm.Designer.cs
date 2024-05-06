﻿namespace OfficeSuppliesManagement
{
    partial class DisplayProductForm
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
            btnDisplayProductSupplier = new Button();
            lblProductId = new Label();
            txtProductId = new TextBox();
            btnBackDisplayProduct = new Button();
            dgv = new DataGridView();
            btnViewAllProducts = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // btnDisplayProductSupplier
            // 
            btnDisplayProductSupplier.Location = new Point(585, 6);
            btnDisplayProductSupplier.Name = "btnDisplayProductSupplier";
            btnDisplayProductSupplier.Size = new Size(175, 31);
            btnDisplayProductSupplier.TabIndex = 0;
            btnDisplayProductSupplier.Text = "Display Product Information";
            btnDisplayProductSupplier.UseVisualStyleBackColor = true;
            btnDisplayProductSupplier.Click += btnDisplayProductSupplier_Click;
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
            // txtProductId
            // 
            txtProductId.Location = new Point(84, 6);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(274, 23);
            txtProductId.TabIndex = 2;
            // 
            // btnBackDisplayProduct
            // 
            btnBackDisplayProduct.Location = new Point(84, 380);
            btnBackDisplayProduct.Name = "btnBackDisplayProduct";
            btnBackDisplayProduct.Size = new Size(175, 43);
            btnBackDisplayProduct.TabIndex = 3;
            btnBackDisplayProduct.Text = "Back";
            btnBackDisplayProduct.UseVisualStyleBackColor = true;
            btnBackDisplayProduct.Click += btnBackDisplayProduct_Click;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(84, 64);
            dgv.Name = "dgv";
            dgv.Size = new Size(676, 294);
            dgv.TabIndex = 4;
            // 
            // btnViewAllProducts
            // 
            btnViewAllProducts.Location = new Point(585, 380);
            btnViewAllProducts.Name = "btnViewAllProducts";
            btnViewAllProducts.Size = new Size(175, 43);
            btnViewAllProducts.TabIndex = 5;
            btnViewAllProducts.Text = "Products to PDF";
            btnViewAllProducts.UseVisualStyleBackColor = true;
            btnViewAllProducts.Click += btnViewAllProducts_Click;
            // 
            // DisplayProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewAllProducts);
            Controls.Add(dgv);
            Controls.Add(btnBackDisplayProduct);
            Controls.Add(txtProductId);
            Controls.Add(lblProductId);
            Controls.Add(btnDisplayProductSupplier);
            Name = "DisplayProductForm";
            Text = "DisplayProductForm";
            FormClosed += DisplayProductForm_FormClosed;
            Load += DisplayProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDisplayProductSupplier;
        private Label lblProductId;
        private TextBox txtProductId;
        private Button btnBackDisplayProduct;
        private DataGridView dgv;
        private Button btnViewAllProducts;
    }
}