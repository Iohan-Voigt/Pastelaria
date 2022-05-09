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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblIdentifyDocument = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.mtxtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.txtRegistration = new System.Windows.Forms.TextBox();
            this.lblAcessUser = new System.Windows.Forms.Label();
            this.txtAcessUser = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panelPermissions = new System.Windows.Forms.Panel();
            this.rbtnCashier = new System.Windows.Forms.RadioButton();
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            this.lblPermissions = new System.Windows.Forms.Label();
            this.ibtnSave = new FontAwesome.Sharp.IconButton();
            this.ibtnCancel = new FontAwesome.Sharp.IconButton();
            this.labelMessages = new System.Windows.Forms.Label();
            this.mtxtBoxIdentifyDocument = new System.Windows.Forms.MaskedTextBox();
            this.panelPermissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.lblID.Location = new System.Drawing.Point(36, 27);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 28);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.Location = new System.Drawing.Point(36, 58);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(298, 23);
            this.txtID.TabIndex = 0;
            this.txtID.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.lblName.Location = new System.Drawing.Point(36, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 28);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(36, 115);
            this.txtName.MaxLength = 75;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 23);
            this.txtName.TabIndex = 1;
            // 
            // lblIdentifyDocument
            // 
            this.lblIdentifyDocument.AutoSize = true;
            this.lblIdentifyDocument.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdentifyDocument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.lblIdentifyDocument.Location = new System.Drawing.Point(36, 141);
            this.lblIdentifyDocument.Name = "lblIdentifyDocument";
            this.lblIdentifyDocument.Size = new System.Drawing.Size(174, 28);
            this.lblIdentifyDocument.TabIndex = 2;
            this.lblIdentifyDocument.Text = "Identify Document";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.lblPhoneNumber.Location = new System.Drawing.Point(36, 209);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(144, 28);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // mtxtPhoneNumber
            // 
            this.mtxtPhoneNumber.Location = new System.Drawing.Point(36, 240);
            this.mtxtPhoneNumber.Mask = "(00) 0 0000-0000";
            this.mtxtPhoneNumber.Name = "mtxtPhoneNumber";
            this.mtxtPhoneNumber.Size = new System.Drawing.Size(174, 23);
            this.mtxtPhoneNumber.TabIndex = 3;
            this.mtxtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtPhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.lblRegistration.Location = new System.Drawing.Point(352, 27);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(118, 28);
            this.lblRegistration.TabIndex = 6;
            this.lblRegistration.Text = "Registration";
            // 
            // txtRegistration
            // 
            this.txtRegistration.Location = new System.Drawing.Point(352, 58);
            this.txtRegistration.MaxLength = 30;
            this.txtRegistration.Name = "txtRegistration";
            this.txtRegistration.Size = new System.Drawing.Size(298, 23);
            this.txtRegistration.TabIndex = 6;
            // 
            // lblAcessUser
            // 
            this.lblAcessUser.AutoSize = true;
            this.lblAcessUser.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAcessUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.lblAcessUser.Location = new System.Drawing.Point(352, 84);
            this.lblAcessUser.Name = "lblAcessUser";
            this.lblAcessUser.Size = new System.Drawing.Size(104, 28);
            this.lblAcessUser.TabIndex = 8;
            this.lblAcessUser.Text = "Acess User";
            // 
            // txtAcessUser
            // 
            this.txtAcessUser.Location = new System.Drawing.Point(352, 115);
            this.txtAcessUser.MaxLength = 20;
            this.txtAcessUser.Name = "txtAcessUser";
            this.txtAcessUser.Size = new System.Drawing.Size(298, 23);
            this.txtAcessUser.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.lblPassword.Location = new System.Drawing.Point(352, 141);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(94, 28);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(352, 172);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '@';
            this.txtPassword.Size = new System.Drawing.Size(298, 23);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // panelPermissions
            // 
            this.panelPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPermissions.CausesValidation = false;
            this.panelPermissions.Controls.Add(this.rbtnCashier);
            this.panelPermissions.Controls.Add(this.rbtnAdmin);
            this.panelPermissions.Controls.Add(this.lblPermissions);
            this.panelPermissions.Location = new System.Drawing.Point(213, 149);
            this.panelPermissions.Margin = new System.Windows.Forms.Padding(0);
            this.panelPermissions.Name = "panelPermissions";
            this.panelPermissions.Size = new System.Drawing.Size(119, 114);
            this.panelPermissions.TabIndex = 12;
            // 
            // rbtnCashier
            // 
            this.rbtnCashier.AutoSize = true;
            this.rbtnCashier.CausesValidation = false;
            this.rbtnCashier.Checked = true;
            this.rbtnCashier.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnCashier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.rbtnCashier.Location = new System.Drawing.Point(9, 71);
            this.rbtnCashier.Name = "rbtnCashier";
            this.rbtnCashier.Size = new System.Drawing.Size(80, 25);
            this.rbtnCashier.TabIndex = 5;
            this.rbtnCashier.TabStop = true;
            this.rbtnCashier.Text = "Cashier";
            this.rbtnCashier.UseVisualStyleBackColor = true;
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.CausesValidation = false;
            this.rbtnAdmin.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.rbtnAdmin.Location = new System.Drawing.Point(9, 40);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(74, 25);
            this.rbtnAdmin.TabIndex = 4;
            this.rbtnAdmin.Text = "Admin";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // lblPermissions
            // 
            this.lblPermissions.AutoSize = true;
            this.lblPermissions.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPermissions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.lblPermissions.Location = new System.Drawing.Point(3, 9);
            this.lblPermissions.Name = "lblPermissions";
            this.lblPermissions.Size = new System.Drawing.Size(114, 28);
            this.lblPermissions.TabIndex = 13;
            this.lblPermissions.Text = "Permissions";
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
            this.ibtnSave.Location = new System.Drawing.Point(530, 220);
            this.ibtnSave.Name = "ibtnSave";
            this.ibtnSave.Size = new System.Drawing.Size(120, 60);
            this.ibtnSave.TabIndex = 10;
            this.ibtnSave.Text = "Save";
            this.ibtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnSave.UseVisualStyleBackColor = false;
            this.ibtnSave.Click += new System.EventHandler(this.iconButtonSave_Click);
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
            this.ibtnCancel.Location = new System.Drawing.Point(352, 220);
            this.ibtnCancel.Name = "ibtnCancel";
            this.ibtnCancel.Size = new System.Drawing.Size(120, 60);
            this.ibtnCancel.TabIndex = 9;
            this.ibtnCancel.Text = "Cancel";
            this.ibtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnCancel.UseVisualStyleBackColor = false;
            this.ibtnCancel.Click += new System.EventHandler(this.iconButtonCancel_Click);
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
            // mtxtBoxIdentifyDocument
            // 
            this.mtxtBoxIdentifyDocument.Location = new System.Drawing.Point(36, 172);
            this.mtxtBoxIdentifyDocument.Mask = "000.000.000-00";
            this.mtxtBoxIdentifyDocument.Name = "mtxtBoxIdentifyDocument";
            this.mtxtBoxIdentifyDocument.Size = new System.Drawing.Size(174, 23);
            this.mtxtBoxIdentifyDocument.TabIndex = 2;
            this.mtxtBoxIdentifyDocument.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtxtBoxIdentifyDocument.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(123)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.mtxtBoxIdentifyDocument);
            this.Controls.Add(this.labelMessages);
            this.Controls.Add(this.ibtnCancel);
            this.Controls.Add(this.ibtnSave);
            this.Controls.Add(this.panelPermissions);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtAcessUser);
            this.Controls.Add(this.lblAcessUser);
            this.Controls.Add(this.txtRegistration);
            this.Controls.Add(this.lblRegistration);
            this.Controls.Add(this.mtxtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblIdentifyDocument);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblIdentifyDocument;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.MaskedTextBox mtxtPhoneNumber;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.TextBox txtRegistration;
        private System.Windows.Forms.Label lblAcessUser;
        private System.Windows.Forms.TextBox txtAcessUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panelPermissions;
        private System.Windows.Forms.RadioButton rbtnCashier;
        private System.Windows.Forms.RadioButton rbtnAdmin;
        private System.Windows.Forms.Label lblPermissions;
        private FontAwesome.Sharp.IconButton ibtnSave;
        private FontAwesome.Sharp.IconButton ibtnCancel;
        private System.Windows.Forms.Label labelMessages;
        private System.Windows.Forms.MaskedTextBox mtxtBoxIdentifyDocument;
    }
}