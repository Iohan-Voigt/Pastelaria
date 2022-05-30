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
            this.productsListPanel = new System.Windows.Forms.Panel();
            this.vScrollBarProductsListPanel = new System.Windows.Forms.VScrollBar();
            this.selectedProductsPanel = new System.Windows.Forms.Panel();
            this.productsListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsListPanel
            // 
            this.productsListPanel.AutoScroll = true;
            this.productsListPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productsListPanel.Controls.Add(this.vScrollBarProductsListPanel);
            this.productsListPanel.Location = new System.Drawing.Point(12, 12);
            this.productsListPanel.Name = "productsListPanel";
            this.productsListPanel.Size = new System.Drawing.Size(517, 637);
            this.productsListPanel.TabIndex = 0;
            // 
            // vScrollBarProductsListPanel
            // 
            this.vScrollBarProductsListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBarProductsListPanel.Location = new System.Drawing.Point(496, 0);
            this.vScrollBarProductsListPanel.Name = "vScrollBarProductsListPanel";
            this.vScrollBarProductsListPanel.Size = new System.Drawing.Size(17, 633);
            this.vScrollBarProductsListPanel.TabIndex = 0;
            // 
            // selectedProductsPanel
            // 
            this.selectedProductsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedProductsPanel.Location = new System.Drawing.Point(538, 110);
            this.selectedProductsPanel.Name = "selectedProductsPanel";
            this.selectedProductsPanel.Size = new System.Drawing.Size(337, 421);
            this.selectedProductsPanel.TabIndex = 1;
            // 
            // OrderPadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.selectedProductsPanel);
            this.Controls.Add(this.productsListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OrderPadForm";
            this.Text = "OrderPadForm";
            this.productsListPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel productsListPanel;
        private System.Windows.Forms.VScrollBar vScrollBarProductsListPanel;
        private System.Windows.Forms.Panel selectedProductsPanel;
    }
}