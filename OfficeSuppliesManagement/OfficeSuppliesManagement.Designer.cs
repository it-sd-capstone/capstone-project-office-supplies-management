namespace OfficeSuppliesManagement
{
    partial class OfficeSuppliesManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            label1 = new Label();
            btnDisplay = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 271);
            btnAdd.Margin = new Padding(6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(250, 200);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add New Product";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 85);
            label1.Name = "label1";
            label1.Size = new Size(537, 50);
            label1.TabIndex = 1;
            label1.Text = "Supplies Management Options:";
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(861, 271);
            btnDisplay.Margin = new Padding(6);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(250, 200);
            btnDisplay.TabIndex = 2;
            btnDisplay.Text = "Display Product/Supplier Information";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(427, 271);
            btnUpdate.Margin = new Padding(6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(250, 200);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update Existing Product";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // OfficeSuppliesManagement
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 660);
            Controls.Add(btnUpdate);
            Controls.Add(btnDisplay);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Margin = new Padding(6);
            Name = "OfficeSuppliesManagement";
            Text = "Office Supplies Management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label1;
        private Button btnDisplay;
        private Button btnUpdate;
    }
}
