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
            pnlOptions.SuspendLayout();
            pnlDisplay.SuspendLayout();
            pnlUpdate.SuspendLayout();
            pnlAdd.SuspendLayout();
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
            pnlOptions.Name = "pnlOptions";
            pnlOptions.Size = new Size(1692, 103);
            pnlOptions.TabIndex = 4;
            // 
            // pnlDisplay
            // 
            pnlDisplay.Controls.Add(lblDisplay);
            pnlDisplay.Location = new Point(419, 3);
            pnlDisplay.Name = "pnlDisplay";
            pnlDisplay.Size = new Size(202, 97);
            pnlDisplay.TabIndex = 2;
            pnlDisplay.Click += pnlDisplay_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.BackColor = Color.Transparent;
            lblDisplay.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDisplay.ForeColor = Color.Black;
            lblDisplay.Location = new Point(40, 28);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(130, 45);
            lblDisplay.TabIndex = 1;
            lblDisplay.Text = "Display";
            lblDisplay.Click += lblDisplay_Click;
            // 
            // pnlUpdate
            // 
            pnlUpdate.Controls.Add(lblUpdate);
            pnlUpdate.Location = new Point(211, 3);
            pnlUpdate.Name = "pnlUpdate";
            pnlUpdate.Size = new Size(202, 97);
            pnlUpdate.TabIndex = 1;
            pnlUpdate.Click += pnlUpdate_Click;
            // 
            // lblUpdate
            // 
            lblUpdate.AutoSize = true;
            lblUpdate.BackColor = Color.Transparent;
            lblUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUpdate.ForeColor = Color.Black;
            lblUpdate.Location = new Point(36, 28);
            lblUpdate.Name = "lblUpdate";
            lblUpdate.Size = new Size(129, 45);
            lblUpdate.TabIndex = 1;
            lblUpdate.Text = "Update";
            lblUpdate.Click += lblUpdate_Click;
            // 
            // pnlAdd
            // 
            pnlAdd.Controls.Add(lblAdd);
            pnlAdd.Location = new Point(3, 3);
            pnlAdd.Name = "pnlAdd";
            pnlAdd.Size = new Size(202, 97);
            pnlAdd.TabIndex = 0;
            pnlAdd.Click += pnlAdd_Click;
            // 
            // lblAdd
            // 
            lblAdd.AutoSize = true;
            lblAdd.BackColor = Color.Transparent;
            lblAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAdd.ForeColor = Color.Black;
            lblAdd.Location = new Point(53, 28);
            lblAdd.Name = "lblAdd";
            lblAdd.Size = new Size(83, 45);
            lblAdd.TabIndex = 0;
            lblAdd.Text = "Add";
            lblAdd.Click += lblAdd_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.DarkGray;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 103);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1692, 1083);
            pnlContent.TabIndex = 5;
            // 
            // OfficeSuppliesManagement
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1692, 1186);
            Controls.Add(pnlContent);
            Controls.Add(pnlOptions);
            Margin = new Padding(6);
            Name = "OfficeSuppliesManagement";
            Text = "Office Supplies Management";
            pnlOptions.ResumeLayout(false);
            pnlDisplay.ResumeLayout(false);
            pnlDisplay.PerformLayout();
            pnlUpdate.ResumeLayout(false);
            pnlUpdate.PerformLayout();
            pnlAdd.ResumeLayout(false);
            pnlAdd.PerformLayout();
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
    }
}
