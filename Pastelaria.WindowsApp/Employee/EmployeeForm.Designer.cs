namespace Pastelaria.WindowsApp.Employee
{
    partial class EmployeeForm
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
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelIdentifyDocument = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.maskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelRegistration = new System.Windows.Forms.Label();
            this.textBoxRegistration = new System.Windows.Forms.TextBox();
            this.labelAcessUser = new System.Windows.Forms.Label();
            this.textBoxAcessUser = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panelPermissions = new System.Windows.Forms.Panel();
            this.radioButtonCashier = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.labelPermissions = new System.Windows.Forms.Label();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.iconButtonCancel = new FontAwesome.Sharp.IconButton();
            this.labelMessages = new System.Windows.Forms.Label();
            this.maskedTextBoxIdentifyDocument = new System.Windows.Forms.MaskedTextBox();
            this.panelPermissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.labelID.Location = new System.Drawing.Point(36, 27);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(31, 28);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxID.Location = new System.Drawing.Point(36, 58);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(298, 23);
            this.textBoxID.TabIndex = 0;
            this.textBoxID.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.labelName.Location = new System.Drawing.Point(36, 84);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 28);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(36, 115);
            this.textBoxName.MaxLength = 75;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(298, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // labelIdentifyDocument
            // 
            this.labelIdentifyDocument.AutoSize = true;
            this.labelIdentifyDocument.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIdentifyDocument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.labelIdentifyDocument.Location = new System.Drawing.Point(36, 141);
            this.labelIdentifyDocument.Name = "labelIdentifyDocument";
            this.labelIdentifyDocument.Size = new System.Drawing.Size(174, 28);
            this.labelIdentifyDocument.TabIndex = 2;
            this.labelIdentifyDocument.Text = "Identify Document";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.labelPhoneNumber.Location = new System.Drawing.Point(36, 209);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(144, 28);
            this.labelPhoneNumber.TabIndex = 4;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // maskedTextBoxPhoneNumber
            // 
            this.maskedTextBoxPhoneNumber.Location = new System.Drawing.Point(36, 240);
            this.maskedTextBoxPhoneNumber.Mask = "(00) 0 0000-0000";
            this.maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            this.maskedTextBoxPhoneNumber.Size = new System.Drawing.Size(174, 23);
            this.maskedTextBoxPhoneNumber.TabIndex = 5;
            this.maskedTextBoxPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maskedTextBoxPhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.labelRegistration.Location = new System.Drawing.Point(352, 27);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(118, 28);
            this.labelRegistration.TabIndex = 6;
            this.labelRegistration.Text = "Registration";
            // 
            // textBoxRegistration
            // 
            this.textBoxRegistration.Location = new System.Drawing.Point(352, 58);
            this.textBoxRegistration.MaxLength = 30;
            this.textBoxRegistration.Name = "textBoxRegistration";
            this.textBoxRegistration.Size = new System.Drawing.Size(298, 23);
            this.textBoxRegistration.TabIndex = 7;
            // 
            // labelAcessUser
            // 
            this.labelAcessUser.AutoSize = true;
            this.labelAcessUser.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAcessUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.labelAcessUser.Location = new System.Drawing.Point(352, 84);
            this.labelAcessUser.Name = "labelAcessUser";
            this.labelAcessUser.Size = new System.Drawing.Size(104, 28);
            this.labelAcessUser.TabIndex = 8;
            this.labelAcessUser.Text = "Acess User";
            // 
            // textBoxAcessUser
            // 
            this.textBoxAcessUser.Location = new System.Drawing.Point(352, 115);
            this.textBoxAcessUser.MaxLength = 20;
            this.textBoxAcessUser.Name = "textBoxAcessUser";
            this.textBoxAcessUser.Size = new System.Drawing.Size(298, 23);
            this.textBoxAcessUser.TabIndex = 9;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.labelPassword.Location = new System.Drawing.Point(352, 141);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(94, 28);
            this.labelPassword.TabIndex = 10;
            this.labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(352, 172);
            this.textBoxPassword.MaxLength = 20;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '@';
            this.textBoxPassword.Size = new System.Drawing.Size(298, 23);
            this.textBoxPassword.TabIndex = 11;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // panelPermissions
            // 
            this.panelPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPermissions.CausesValidation = false;
            this.panelPermissions.Controls.Add(this.radioButtonCashier);
            this.panelPermissions.Controls.Add(this.radioButtonAdmin);
            this.panelPermissions.Controls.Add(this.labelPermissions);
            this.panelPermissions.Location = new System.Drawing.Point(213, 149);
            this.panelPermissions.Margin = new System.Windows.Forms.Padding(0);
            this.panelPermissions.Name = "panelPermissions";
            this.panelPermissions.Size = new System.Drawing.Size(121, 114);
            this.panelPermissions.TabIndex = 12;
            // 
            // radioButtonCashier
            // 
            this.radioButtonCashier.AutoSize = true;
            this.radioButtonCashier.CausesValidation = false;
            this.radioButtonCashier.Checked = true;
            this.radioButtonCashier.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonCashier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.radioButtonCashier.Location = new System.Drawing.Point(9, 71);
            this.radioButtonCashier.Name = "radioButtonCashier";
            this.radioButtonCashier.Size = new System.Drawing.Size(80, 25);
            this.radioButtonCashier.TabIndex = 15;
            this.radioButtonCashier.TabStop = true;
            this.radioButtonCashier.Text = "Cashier";
            this.radioButtonCashier.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.CausesValidation = false;
            this.radioButtonAdmin.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.radioButtonAdmin.Location = new System.Drawing.Point(9, 40);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(74, 25);
            this.radioButtonAdmin.TabIndex = 14;
            this.radioButtonAdmin.Text = "Admin";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // labelPermissions
            // 
            this.labelPermissions.AutoSize = true;
            this.labelPermissions.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPermissions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.labelPermissions.Location = new System.Drawing.Point(3, 9);
            this.labelPermissions.Name = "labelPermissions";
            this.labelPermissions.Size = new System.Drawing.Size(114, 28);
            this.labelPermissions.TabIndex = 13;
            this.labelPermissions.Text = "Permissions";
            // 
            // iconButtonSave
            // 
            this.iconButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(85)))), ((int)(((byte)(37)))));
            this.iconButtonSave.FlatAppearance.BorderSize = 0;
            this.iconButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSave.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButtonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.iconButtonSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconButtonSave.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.iconButtonSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSave.IconSize = 50;
            this.iconButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSave.Location = new System.Drawing.Point(530, 223);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Size = new System.Drawing.Size(120, 60);
            this.iconButtonSave.TabIndex = 13;
            this.iconButtonSave.Text = "Save";
            this.iconButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonSave.UseVisualStyleBackColor = false;
            this.iconButtonSave.Click += new System.EventHandler(this.iconButtonSave_Click);
            // 
            // iconButtonCancel
            // 
            this.iconButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(85)))), ((int)(((byte)(37)))));
            this.iconButtonCancel.FlatAppearance.BorderSize = 0;
            this.iconButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCancel.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButtonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.iconButtonCancel.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.iconButtonCancel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.iconButtonCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCancel.IconSize = 50;
            this.iconButtonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCancel.Location = new System.Drawing.Point(352, 223);
            this.iconButtonCancel.Name = "iconButtonCancel";
            this.iconButtonCancel.Size = new System.Drawing.Size(120, 60);
            this.iconButtonCancel.TabIndex = 14;
            this.iconButtonCancel.Text = "Cancel";
            this.iconButtonCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCancel.UseVisualStyleBackColor = false;
            this.iconButtonCancel.Click += new System.EventHandler(this.iconButtonCancel_Click);
            // 
            // labelMessages
            // 
            this.labelMessages.AutoSize = true;
            this.labelMessages.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.labelMessages.Location = new System.Drawing.Point(12, 275);
            this.labelMessages.Name = "labelMessages";
            this.labelMessages.Size = new System.Drawing.Size(0, 19);
            this.labelMessages.TabIndex = 15;
            // 
            // maskedTextBoxIdentifyDocument
            // 
            this.maskedTextBoxIdentifyDocument.Location = new System.Drawing.Point(36, 172);
            this.maskedTextBoxIdentifyDocument.Mask = "000.000.000-00";
            this.maskedTextBoxIdentifyDocument.Name = "maskedTextBoxIdentifyDocument";
            this.maskedTextBoxIdentifyDocument.Size = new System.Drawing.Size(174, 23);
            this.maskedTextBoxIdentifyDocument.TabIndex = 16;
            this.maskedTextBoxIdentifyDocument.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maskedTextBoxIdentifyDocument.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(123)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(686, 312);
            this.Controls.Add(this.maskedTextBoxIdentifyDocument);
            this.Controls.Add(this.labelMessages);
            this.Controls.Add(this.iconButtonCancel);
            this.Controls.Add(this.iconButtonSave);
            this.Controls.Add(this.panelPermissions);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxAcessUser);
            this.Controls.Add(this.labelAcessUser);
            this.Controls.Add(this.textBoxRegistration);
            this.Controls.Add(this.labelRegistration);
            this.Controls.Add(this.maskedTextBoxPhoneNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelIdentifyDocument);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.MaximizeBox = false;
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeForm";
            this.panelPermissions.ResumeLayout(false);
            this.panelPermissions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelIdentifyDocument;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.TextBox textBoxRegistration;
        private System.Windows.Forms.Label labelAcessUser;
        private System.Windows.Forms.TextBox textBoxAcessUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panelPermissions;
        private System.Windows.Forms.RadioButton radioButtonCashier;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.Label labelPermissions;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private FontAwesome.Sharp.IconButton iconButtonCancel;
        private System.Windows.Forms.Label labelMessages;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxIdentifyDocument;
    }
}