namespace OfficeSuppliesManagement
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
            lblProductId = new Label();
            txtProductId = new TextBox();
            dgv = new DataGridView();
            btnViewAllProducts = new Button();
            btnDisplayProductSupplier = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
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
            // txtProductId
            // 
            txtProductId.Location = new Point(178, 53);
            txtProductId.Margin = new Padding(6);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(201, 39);
            txtProductId.TabIndex = 2;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(15, 137);
            dgv.Margin = new Padding(6);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 82;
            dgv.Size = new Size(1662, 857);
            dgv.TabIndex = 4;
            // 
            // btnViewAllProducts
            // 
            btnViewAllProducts.Location = new Point(1430, 1006);
            btnViewAllProducts.Margin = new Padding(6);
            btnViewAllProducts.Name = "btnViewAllProducts";
            btnViewAllProducts.Size = new Size(247, 62);
            btnViewAllProducts.TabIndex = 5;
            btnViewAllProducts.Text = "Products to PDF";
            btnViewAllProducts.UseVisualStyleBackColor = true;
            btnViewAllProducts.Click += btnViewAllProducts_Click;
            // 
            // btnDisplayProductSupplier
            // 
            btnDisplayProductSupplier.Location = new Point(477, 40);
            btnDisplayProductSupplier.Margin = new Padding(6);
            btnDisplayProductSupplier.Name = "btnDisplayProductSupplier";
            btnDisplayProductSupplier.Size = new Size(247, 62);
            btnDisplayProductSupplier.TabIndex = 22;
            btnDisplayProductSupplier.Text = "Display Info";
            btnDisplayProductSupplier.UseVisualStyleBackColor = true;
            // 
            // DisplayProductForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1692, 1083);
            ControlBox = false;
            Controls.Add(btnDisplayProductSupplier);
            Controls.Add(btnViewAllProducts);
            Controls.Add(dgv);
            Controls.Add(txtProductId);
            Controls.Add(lblProductId);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6);
            Name = "DisplayProductForm";
            Text = "Display Product";
            Load += DisplayProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblProductId;
        private TextBox txtProductId;
        private DataGridView dgv;
        private Button btnViewAllProducts;
        public Button btnDisplayProductSupplier;
    }
}