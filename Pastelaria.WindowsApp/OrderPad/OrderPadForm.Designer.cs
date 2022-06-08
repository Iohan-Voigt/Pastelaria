namespace Pastelaria.WindowsApp.OrderPad
{
    partial class OrderPadForm
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
            this.cbxCustomers = new System.Windows.Forms.ComboBox();
            this.productsListPanel = new System.Windows.Forms.Panel();
            this.selectedProductsPanel = new System.Windows.Forms.Panel();
            this.ibtnCancel = new FontAwesome.Sharp.IconButton();
            this.ibtnSave = new FontAwesome.Sharp.IconButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblMessages = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxCustomers
            // 
            this.cbxCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCustomers.Location = new System.Drawing.Point(513, 36);
            this.cbxCustomers.Name = "cbxCustomers";
            this.cbxCustomers.Size = new System.Drawing.Size(356, 23);
            this.cbxCustomers.Sorted = true;
            this.cbxCustomers.TabIndex = 15;
            // 
            // productsListPanel
            // 
            this.productsListPanel.AutoScroll = true;
            this.productsListPanel.Location = new System.Drawing.Point(12, 12);
            this.productsListPanel.Name = "productsListPanel";
            this.productsListPanel.Size = new System.Drawing.Size(495, 608);
            this.productsListPanel.TabIndex = 0;
            // 
            // selectedProductsPanel
            // 
            this.selectedProductsPanel.AutoScroll = true;
            this.selectedProductsPanel.Location = new System.Drawing.Point(513, 110);
            this.selectedProductsPanel.Name = "selectedProductsPanel";
            this.selectedProductsPanel.Size = new System.Drawing.Size(362, 408);
            this.selectedProductsPanel.TabIndex = 1;
            // 
            // ibtnCancel
            // 
            this.ibtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(85)))), ((int)(((byte)(37)))));
            this.ibtnCancel.FlatAppearance.BorderSize = 0;
            this.ibtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCancel.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibtnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnCancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.ibtnCancel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCancel.IconSize = 50;
            this.ibtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCancel.Location = new System.Drawing.Point(513, 589);
            this.ibtnCancel.Name = "ibtnCancel";
            this.ibtnCancel.Size = new System.Drawing.Size(120, 60);
            this.ibtnCancel.TabIndex = 10;
            this.ibtnCancel.Text = "Cancel";
            this.ibtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnCancel.UseVisualStyleBackColor = false;
            this.ibtnCancel.Click += new System.EventHandler(this.ibtnCancel_Click);
            // 
            // ibtnSave
            // 
            this.ibtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(85)))), ((int)(((byte)(37)))));
            this.ibtnSave.FlatAppearance.BorderSize = 0;
            this.ibtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSave.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibtnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.ibtnSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSave.IconSize = 50;
            this.ibtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSave.Location = new System.Drawing.Point(755, 589);
            this.ibtnSave.Name = "ibtnSave";
            this.ibtnSave.Size = new System.Drawing.Size(120, 60);
            this.ibtnSave.TabIndex = 11;
            this.ibtnSave.Text = "Save";
            this.ibtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnSave.UseVisualStyleBackColor = false;
            this.ibtnSave.Click += new System.EventHandler(this.ibtnSave_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(513, 536);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(80, 37);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalValue.Location = new System.Drawing.Point(599, 536);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(0, 37);
            this.lblTotalValue.TabIndex = 13;
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessages.Location = new System.Drawing.Point(12, 631);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(71, 21);
            this.lblMessages.TabIndex = 14;
            this.lblMessages.Text = "Message";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustomer.Location = new System.Drawing.Point(513, 12);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(78, 21);
            this.lblCustomer.TabIndex = 16;
            this.lblCustomer.Text = "Customer";
            // 
            // OrderPadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 661);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.cbxCustomers);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.ibtnSave);
            this.Controls.Add(this.ibtnCancel);
            this.Controls.Add(this.selectedProductsPanel);
            this.Controls.Add(this.productsListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderPadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderPadForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel productsListPanel;
        private System.Windows.Forms.Panel selectedProductsPanel;
        private FontAwesome.Sharp.IconButton ibtnCancel;
        private FontAwesome.Sharp.IconButton ibtnSave;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.ComboBox cbxCustomers;
        private System.Windows.Forms.Label lblCustomer;
    }
}