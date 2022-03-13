namespace Pastelaria.WindowsApp.OrderPad
{
    partial class OrderPadUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderPadGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.orderPadGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // orderPadGrid
            // 
            this.orderPadGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderPadGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderPadGrid.Location = new System.Drawing.Point(0, 0);
            this.orderPadGrid.Name = "orderPadGrid";
            this.orderPadGrid.RowTemplate.Height = 25;
            this.orderPadGrid.Size = new System.Drawing.Size(150, 150);
            this.orderPadGrid.TabIndex = 0;
            // 
            // OrderPadUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderPadGrid);
            this.Name = "OrderPadUserControl";
            ((System.ComponentModel.ISupportInitialize)(this.orderPadGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView orderPadGrid;
    }
}
