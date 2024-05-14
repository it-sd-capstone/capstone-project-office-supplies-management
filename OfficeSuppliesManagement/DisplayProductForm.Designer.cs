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
            components = new System.ComponentModel.Container();
            lblProductId = new Label();
            txtProductId = new TextBox();
            dgv = new DataGridView();
            btnViewAllProducts = new Button();
            btnDisplayProductSupplier = new Button();
            lblPrintProdDesc = new Label();
            lblAlterationWarning = new Label();
            btnDisplayAll = new Button();
            buttonToolTip1 = new ToolTip(components);
            xButton1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(12, 22);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(66, 15);
            lblProductId.TabIndex = 1;
            lblProductId.Text = "Product ID:";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(97, 19);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(110, 23);
            txtProductId.TabIndex = 2;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(11, 89);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 82;
            dgv.ShowCellToolTips = false;
            dgv.Size = new Size(895, 273);
            dgv.TabIndex = 4;
            // 
            // btnViewAllProducts
            // 
            btnViewAllProducts.Location = new Point(770, 472);
            btnViewAllProducts.Name = "btnViewAllProducts";
            btnViewAllProducts.Size = new Size(133, 29);
            btnViewAllProducts.TabIndex = 5;
            btnViewAllProducts.Text = "Products to PDF";
            btnViewAllProducts.UseVisualStyleBackColor = true;
            btnViewAllProducts.Click += btnViewAllProducts_Click;
            // 
            // btnDisplayProductSupplier
            // 
            btnDisplayProductSupplier.Location = new Point(226, 15);
            btnDisplayProductSupplier.Name = "btnDisplayProductSupplier";
            btnDisplayProductSupplier.Size = new Size(133, 29);
            btnDisplayProductSupplier.TabIndex = 22;
            btnDisplayProductSupplier.Text = "Display Info";
            buttonToolTip1.SetToolTip(btnDisplayProductSupplier, "Hold Shift and click to highlight rows below.");
            btnDisplayProductSupplier.UseVisualStyleBackColor = true;
            btnDisplayProductSupplier.Click += btnDisplayProductSupplier_Click;
            // 
            // lblPrintProdDesc
            // 
            lblPrintProdDesc.AutoSize = true;
            lblPrintProdDesc.Location = new Point(407, 479);
            lblPrintProdDesc.Margin = new Padding(2, 0, 2, 0);
            lblPrintProdDesc.Name = "lblPrintProdDesc";
            lblPrintProdDesc.Size = new Size(327, 15);
            lblPrintProdDesc.TabIndex = 23;
            lblPrintProdDesc.Text = "Print all products to a PDF file on this computer's Desktop ->";
            // 
            // lblAlterationWarning
            // 
            lblAlterationWarning.AutoSize = true;
            lblAlterationWarning.ForeColor = Color.Red;
            lblAlterationWarning.Location = new Point(12, 365);
            lblAlterationWarning.Margin = new Padding(2, 0, 2, 0);
            lblAlterationWarning.Name = "lblAlterationWarning";
            lblAlterationWarning.Size = new Size(789, 15);
            lblAlterationWarning.TabIndex = 24;
            lblAlterationWarning.Text = "*Note: No data will be lost/changed if any changes are made here.  Click on the \"Add\" or \"Update\" buttons to go to a form that will allow alterations.";
            // 
            // btnDisplayAll
            // 
            btnDisplayAll.Location = new Point(226, 54);
            btnDisplayAll.Name = "btnDisplayAll";
            btnDisplayAll.Size = new Size(133, 29);
            btnDisplayAll.TabIndex = 25;
            btnDisplayAll.Text = "Display All Products";
            buttonToolTip1.SetToolTip(btnDisplayAll, "Hold Shift and click to highlight rows below.");
            btnDisplayAll.UseVisualStyleBackColor = true;
            btnDisplayAll.Click += btnDisplayAll_Click;
            // 
            // buttonToolTip1
            // 
            buttonToolTip1.AutoPopDelay = 50000;
            buttonToolTip1.InitialDelay = 500;
            buttonToolTip1.ReshowDelay = 100;
            // 
            // xButton1
            // 
            xButton1.ForeColor = SystemColors.ActiveCaptionText;
            xButton1.Location = new Point(12, 472);
            xButton1.Name = "xButton1";
            xButton1.Size = new Size(129, 29);
            xButton1.TabIndex = 26;
            xButton1.Text = "Home";
            xButton1.UseVisualStyleBackColor = true;
            xButton1.Click += xButton1_Click;
            // 
            // DisplayProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 508);
            ControlBox = false;
            Controls.Add(xButton1);
            Controls.Add(btnDisplayAll);
            Controls.Add(lblAlterationWarning);
            Controls.Add(lblPrintProdDesc);
            Controls.Add(btnDisplayProductSupplier);
            Controls.Add(btnViewAllProducts);
            Controls.Add(dgv);
            Controls.Add(txtProductId);
            Controls.Add(lblProductId);
            FormBorderStyle = FormBorderStyle.None;
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
        private Label lblPrintProdDesc;
        private Label lblAlterationWarning;
        public Button btnDisplayAll;
        private ToolTip buttonToolTip1;
        private Button xButton1;
    }
}