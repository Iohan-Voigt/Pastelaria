namespace Pastelaria.WindowsApp.Costumer
{
    partial class CostumerUserControl
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
            this.costumerGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.costumerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // costumerGrid
            // 
            this.costumerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.costumerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.costumerGrid.Location = new System.Drawing.Point(0, 0);
            this.costumerGrid.Name = "costumerGrid";
            this.costumerGrid.RowTemplate.Height = 25;
            this.costumerGrid.Size = new System.Drawing.Size(150, 150);
            this.costumerGrid.TabIndex = 0;
            // 
            // CostumerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.costumerGrid);
            this.Name = "CostumerUserControl";
            ((System.ComponentModel.ISupportInitialize)(this.costumerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView costumerGrid;
    }
}
