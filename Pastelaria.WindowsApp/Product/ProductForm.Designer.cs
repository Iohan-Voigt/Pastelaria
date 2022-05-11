namespace Pastelaria.WindowsApp.Product
{
    partial class ProductForm
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
            this.ibtnCancel = new FontAwesome.Sharp.IconButton();
            this.ibtnSave = new FontAwesome.Sharp.IconButton();
            this.pctImage = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mtxtValue = new System.Windows.Forms.MaskedTextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblMessages = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.ibtnAlterImage = new FontAwesome.Sharp.IconButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
            this.SuspendLayout();
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
            this.ibtnCancel.Location = new System.Drawing.Point(392, 239);
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
            this.ibtnSave.Location = new System.Drawing.Point(552, 239);
            this.ibtnSave.Name = "ibtnSave";
            this.ibtnSave.Size = new System.Drawing.Size(120, 60);
            this.ibtnSave.TabIndex = 11;
            this.ibtnSave.Text = "Save";
            this.ibtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnSave.UseVisualStyleBackColor = false;
            this.ibtnSave.Click += new System.EventHandler(this.ibtnSave_Click);
            // 
            // pctImage
            // 
            this.pctImage.Location = new System.Drawing.Point(392, 12);
            this.pctImage.Name = "pctImage";
            this.pctImage.Size = new System.Drawing.Size(280, 211);
            this.pctImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctImage.TabIndex = 12;
            this.pctImage.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.lblName.Location = new System.Drawing.Point(12, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 28);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.lblDescription.Location = new System.Drawing.Point(12, 90);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(112, 28);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Description";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.lblValue.Location = new System.Drawing.Point(228, 33);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(59, 28);
            this.lblValue.TabIndex = 15;
            this.lblValue.Text = "Value";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(210, 23);
            this.txtName.TabIndex = 16;
            // 
            // mtxtValue
            // 
            this.mtxtValue.Location = new System.Drawing.Point(228, 64);
            this.mtxtValue.Name = "mtxtValue";
            this.mtxtValue.Size = new System.Drawing.Size(158, 23);
            this.mtxtValue.TabIndex = 17;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 121);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(210, 102);
            this.txtDescription.TabIndex = 18;
            this.txtDescription.Text = "";
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.lblMessages.Location = new System.Drawing.Point(12, 280);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(0, 19);
            this.lblMessages.TabIndex = 19;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.lblId.Location = new System.Drawing.Point(12, 5);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 28);
            this.lblId.TabIndex = 20;
            this.lblId.Text = "Id";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.Location = new System.Drawing.Point(47, 10);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(339, 23);
            this.txtID.TabIndex = 21;
            this.txtID.TabStop = false;
            // 
            // ibtnAlterImage
            // 
            this.ibtnAlterImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(85)))), ((int)(((byte)(37)))));
            this.ibtnAlterImage.FlatAppearance.BorderSize = 0;
            this.ibtnAlterImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAlterImage.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibtnAlterImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnAlterImage.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnAlterImage.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnAlterImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAlterImage.IconSize = 50;
            this.ibtnAlterImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAlterImage.Location = new System.Drawing.Point(239, 121);
            this.ibtnAlterImage.Name = "ibtnAlterImage";
            this.ibtnAlterImage.Size = new System.Drawing.Size(120, 60);
            this.ibtnAlterImage.TabIndex = 22;
            this.ibtnAlterImage.Text = "Image";
            this.ibtnAlterImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAlterImage.UseVisualStyleBackColor = false;
            this.ibtnAlterImage.Click += new System.EventHandler(this.ibtnAlterImage_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(123)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.ibtnAlterImage);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.mtxtValue);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pctImage);
            this.Controls.Add(this.ibtnSave);
            this.Controls.Add(this.ibtnCancel);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton ibtnCancel;
        private FontAwesome.Sharp.IconButton ibtnSave;
        private System.Windows.Forms.PictureBox pctImage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox mtxtValue;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtID;
        private FontAwesome.Sharp.IconButton ibtnAlterImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}