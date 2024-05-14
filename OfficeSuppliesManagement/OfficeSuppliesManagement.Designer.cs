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
            pnlOptions = new Panel();
            pnlDisplay = new Panel();
            lblDisplay = new Label();
            pnlUpdate = new Panel();
            lblUpdate = new Label();
            pnlAdd = new Panel();
            lblAdd = new Label();
            pnlContent = new Panel();
            label1 = new Label();
            pnlOptions.SuspendLayout();
            pnlDisplay.SuspendLayout();
            pnlUpdate.SuspendLayout();
            pnlAdd.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlOptions
            // 
            pnlOptions.BackColor = Color.SeaGreen;
            pnlOptions.Controls.Add(pnlDisplay);
            pnlOptions.Controls.Add(pnlUpdate);
            pnlOptions.Controls.Add(pnlAdd);
            pnlOptions.Dock = DockStyle.Top;
            pnlOptions.Location = new Point(0, 0);
            pnlOptions.Margin = new Padding(2, 1, 2, 1);
            pnlOptions.Name = "pnlOptions";
            pnlOptions.Size = new Size(911, 48);
            pnlOptions.TabIndex = 4;
            // 
            // pnlDisplay
            // 
            pnlDisplay.Controls.Add(lblDisplay);
            pnlDisplay.Location = new Point(226, 1);
            pnlDisplay.Margin = new Padding(2, 1, 2, 1);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(109, 45);
            pnlDisplay.TabIndex = 2;
            pnlDisplay.Click += pnlDisplay_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.BackColor = Color.Transparent;
            lblDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDisplay.ForeColor = Color.Black;
            lblDisplay.Location = new Point(22, 13);
            lblDisplay.Margin = new Padding(2, 0, 2, 0);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(67, 21);
            lblDisplay.TabIndex = 1;
            lblDisplay.Text = "Display";
            lblDisplay.Click += lblDisplay_Click;
            // 
            // pnlUpdate
            // 
            pnlUpdate.Controls.Add(lblUpdate);
            pnlUpdate.Location = new Point(114, 1);
            pnlUpdate.Margin = new Padding(2, 1, 2, 1);
            pnlUpdate.Name = "pnlUpdate";
            pnlUpdate.Size = new Size(109, 45);
            pnlUpdate.TabIndex = 1;
            pnlUpdate.Click += pnlUpdate_Click;
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.BackColor = Color.Transparent;
            lblUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUpdate.ForeColor = Color.Black;
            lblUpdate.Location = new Point(19, 13);
            lblUpdate.Margin = new Padding(2, 0, 2, 0);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(66, 21);
            lblUpdate.TabIndex = 1;
            lblUpdate.Text = "Update";
            lblUpdate.Click += lblUpdate_Click;
            // 
            // pnlAdd
            // 
            pnlAdd.Controls.Add(lblAdd);
            pnlAdd.Location = new Point(2, 1);
            pnlAdd.Margin = new Padding(2, 1, 2, 1);
            pnlAdd.Name = "pnlAdd";
            pnlAdd.Size = new Size(109, 45);
            pnlAdd.TabIndex = 0;
            pnlAdd.Click += pnlAdd_Click;
            // 
            // lblAdd
            // 
            lblAdd.AutoSize = true;
            lblAdd.BackColor = Color.Transparent;
            lblAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAdd.ForeColor = Color.Black;
            lblAdd.Location = new Point(29, 13);
            lblAdd.Margin = new Padding(2, 0, 2, 0);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(41, 21);
            lblAdd.TabIndex = 0;
            lblAdd.Text = "Add";
            lblAdd.Click += lblAdd_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.DarkGray;
            pnlContent.Controls.Add(label1);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 48);
            pnlContent.Margin = new Padding(2, 1, 2, 1);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(911, 508);
            pnlContent.TabIndex = 5;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 372);
            label1.Name = "label1";
            label1.Size = new Size(303, 127);
            label1.TabIndex = 0;
            label1.Text = "Keyboard shortcuts:\r\n\r\nPress Ctrl + D for Display Product Form.\r\nPress Ctrl + A for Add Product Form.\r\nPress Ctrl + U for Update Product Form.\r\nPress Ctrl + O for Office Supplies Main Form";
            // 
            // OfficeSuppliesManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(911, 556);
            Controls.Add(pnlContent);
            Controls.Add(pnlOptions);
            Name = "OfficeSuppliesManagement";
            Text = "Office Supplies Management";
            pnlOptions.ResumeLayout(false);
            pnlDisplay.ResumeLayout(false);
            pnlDisplay.PerformLayout();
            pnlUpdate.ResumeLayout(false);
            pnlUpdate.PerformLayout();
            pnlAdd.ResumeLayout(false);
            pnlAdd.PerformLayout();
            pnlContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlOptions;
        private Panel pnlContent;
        private Panel pnlDisplay;
        private Panel pnlUpdate;
        private Panel pnlAdd;
        private Label lblAdd;
        private Label lblDisplay;
        private Label lblUpdate;
        private Label label1;
    }
}
