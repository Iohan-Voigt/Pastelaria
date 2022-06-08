namespace Pastelaria.WindowsApp.OrderPad
{
    partial class SelectedProductListUserControl
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
            this.ibtnAdd = new FontAwesome.Sharp.IconButton();
            this.ibtnRemove = new FontAwesome.Sharp.IconButton();
            this.lblProducutName = new System.Windows.Forms.Label();
            this.lblProductAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ibtnAdd
            // 
            this.ibtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnAdd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ibtnAdd.FlatAppearance.BorderSize = 0;
            this.ibtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAdd.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibtnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ibtnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnAdd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAdd.IconSize = 45;
            this.ibtnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAdd.Location = new System.Drawing.Point(276, 0);
            this.ibtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.ibtnAdd.Name = "ibtnAdd";
            this.ibtnAdd.Size = new System.Drawing.Size(55, 81);
            this.ibtnAdd.TabIndex = 6;
            this.ibtnAdd.Tag = "";
            this.ibtnAdd.UseVisualStyleBackColor = false;
            this.ibtnAdd.Click += new System.EventHandler(this.ibtnAdd_Click);
            // 
            // ibtnRemove
            // 
            this.ibtnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnRemove.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ibtnRemove.FlatAppearance.BorderSize = 0;
            this.ibtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnRemove.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibtnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ibtnRemove.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.ibtnRemove.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRemove.IconSize = 45;
            this.ibtnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnRemove.Location = new System.Drawing.Point(154, -1);
            this.ibtnRemove.Margin = new System.Windows.Forms.Padding(0);
            this.ibtnRemove.Name = "ibtnRemove";
            this.ibtnRemove.Size = new System.Drawing.Size(55, 82);
            this.ibtnRemove.TabIndex = 7;
            this.ibtnRemove.Tag = "";
            this.ibtnRemove.UseVisualStyleBackColor = false;
            this.ibtnRemove.Click += new System.EventHandler(this.ibtnRemove_Click);
            // 
            // lblProducutName
            // 
            this.lblProducutName.AutoSize = true;
            this.lblProducutName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProducutName.Location = new System.Drawing.Point(3, 25);
            this.lblProducutName.Name = "lblProducutName";
            this.lblProducutName.Size = new System.Drawing.Size(65, 28);
            this.lblProducutName.TabIndex = 8;
            this.lblProducutName.Text = "label1";
            // 
            // lblProductAmount
            // 
            this.lblProductAmount.AutoSize = true;
            this.lblProductAmount.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductAmount.Location = new System.Drawing.Point(210, 14);
            this.lblProductAmount.Name = "lblProductAmount";
            this.lblProductAmount.Size = new System.Drawing.Size(45, 54);
            this.lblProductAmount.TabIndex = 9;
            this.lblProductAmount.Text = "0";
            // 
            // SelectedProductListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblProductAmount);
            this.Controls.Add(this.lblProducutName);
            this.Controls.Add(this.ibtnRemove);
            this.Controls.Add(this.ibtnAdd);
            this.Name = "SelectedProductListUserControl";
            this.Size = new System.Drawing.Size(330, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public FontAwesome.Sharp.IconButton ibtnAdd;
        public FontAwesome.Sharp.IconButton ibtnRemove;
        private System.Windows.Forms.Label lblProducutName;
        private System.Windows.Forms.Label lblProductAmount;
    }
}
