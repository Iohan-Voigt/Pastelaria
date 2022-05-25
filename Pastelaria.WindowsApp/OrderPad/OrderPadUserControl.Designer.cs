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
            this.debitsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.debitsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // orderPadGrid
            // 
            this.debitsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debitsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debitsGrid.Location = new System.Drawing.Point(0, 0);
            this.debitsGrid.Name = "orderPadGrid";
            this.debitsGrid.RowTemplate.Height = 25;
            this.debitsGrid.Size = new System.Drawing.Size(150, 150);
            this.debitsGrid.TabIndex = 0;
            // 
            // OrderPadUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.debitsGrid);
            this.Name = "OrderPadUserControl";
            ((System.ComponentModel.ISupportInitialize)(this.debitsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView debitsGrid;
    }
}
