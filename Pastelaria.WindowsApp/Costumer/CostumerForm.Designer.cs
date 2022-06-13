namespace Pastelaria.WindowsApp.Costumer
{
    partial class CostumerForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.identifierLabel = new System.Windows.Forms.Label();
            this.mtxtBoxIdentifyDocument = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.ibtnSave = new FontAwesome.Sharp.IconButton();
            this.ibtnCancel = new FontAwesome.Sharp.IconButton();
            this.labelMessages = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(119, 30);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(53, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 23);
            this.txtName.TabIndex = 1;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(113, 118);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 15);
            this.phoneLabel.TabIndex = 2;
            this.phoneLabel.Text = "Phone";
            // 
            // identifierLabel
            // 
            this.identifierLabel.AutoSize = true;
            this.identifierLabel.Location = new System.Drawing.Point(111, 74);
            this.identifierLabel.Name = "identifierLabel";
            this.identifierLabel.Size = new System.Drawing.Size(54, 15);
            this.identifierLabel.TabIndex = 4;
            this.identifierLabel.Text = "Identifier";
            // 
            // mtxtBoxIdentifyDocument
            // 
            this.mtxtBoxIdentifyDocument.Location = new System.Drawing.Point(53, 92);
            this.mtxtBoxIdentifyDocument.Mask = "000.000.000-00";
            this.mtxtBoxIdentifyDocument.Name = "mtxtBoxIdentifyDocument";
            this.mtxtBoxIdentifyDocument.Size = new System.Drawing.Size(174, 23);
            this.mtxtBoxIdentifyDocument.TabIndex = 5;
            this.mtxtBoxIdentifyDocument.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtBoxIdentifyDocument.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtxtPhoneNumber
            // 
            this.mtxtPhoneNumber.Location = new System.Drawing.Point(53, 136);
            this.mtxtPhoneNumber.Mask = "(00) 0 0000-0000";
            this.mtxtPhoneNumber.Name = "mtxtPhoneNumber";
            this.mtxtPhoneNumber.Size = new System.Drawing.Size(174, 23);
            this.mtxtPhoneNumber.TabIndex = 6;
            this.mtxtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtPhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
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
            this.ibtnSave.Location = new System.Drawing.Point(151, 226);
            this.ibtnSave.Name = "ibtnSave";
            this.ibtnSave.Size = new System.Drawing.Size(120, 60);
            this.ibtnSave.TabIndex = 11;
            this.ibtnSave.Text = "Save";
            this.ibtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnSave.UseVisualStyleBackColor = false;
            this.ibtnSave.Click += new System.EventHandler(this.ibtnSave_Click);
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
            this.ibtnCancel.Location = new System.Drawing.Point(12, 226);
            this.ibtnCancel.Name = "ibtnCancel";
            this.ibtnCancel.Size = new System.Drawing.Size(120, 60);
            this.ibtnCancel.TabIndex = 12;
            this.ibtnCancel.Text = "Cancel";
            this.ibtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnCancel.UseVisualStyleBackColor = false;
            this.ibtnCancel.Click += new System.EventHandler(this.ibtnCancel_Click);
            // 
            // labelMessages
            // 
            this.labelMessages.AutoSize = true;
            this.labelMessages.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.labelMessages.Location = new System.Drawing.Point(141, 140);
            this.labelMessages.Name = "labelMessages";
            this.labelMessages.Size = new System.Drawing.Size(0, 19);
            this.labelMessages.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(12, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 17;
            // 
            // CostumerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 298);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMessages);
            this.Controls.Add(this.ibtnCancel);
            this.Controls.Add(this.ibtnSave);
            this.Controls.Add(this.mtxtPhoneNumber);
            this.Controls.Add(this.mtxtBoxIdentifyDocument);
            this.Controls.Add(this.identifierLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.NameLabel);
            this.Name = "CostumerForm";
            this.Text = "user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label identifierLabel;
        private System.Windows.Forms.MaskedTextBox mtxtBoxIdentifyDocument;
        private System.Windows.Forms.MaskedTextBox mtxtPhoneNumber;
        private FontAwesome.Sharp.IconButton ibtnSave;
        private FontAwesome.Sharp.IconButton ibtnCancel;
        private System.Windows.Forms.Label labelMessages;
        private System.Windows.Forms.Label label1;
    }
}