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
            btnDisplayProductSupplier = new Button();
            lblProductId = new Label();
            txtProductId = new TextBox();
            SuspendLayout();
            // 
            // btnDisplayProductSupplier
            // 
            btnDisplayProductSupplier.Location = new Point(321, 373);
            btnDisplayProductSupplier.Name = "btnDisplayProductSupplier";
            btnDisplayProductSupplier.Size = new Size(175, 43);
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
            // DisplayProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtProductId);
            Controls.Add(lblProductId);
            Controls.Add(btnDisplayProductSupplier);
            Name = "DisplayProductForm";
            Text = "DisplayProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDisplayProductSupplier;
        private Label lblProductId;
        private TextBox txtProductId;
    }
}