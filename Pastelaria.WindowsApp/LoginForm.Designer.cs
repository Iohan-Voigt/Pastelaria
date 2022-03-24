namespace Pastelaria.WindowsApp
{
    partial class LoginForm
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
            this.logginBtn = new System.Windows.Forms.Button();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.LogoPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logginBtn
            // 
            this.logginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(85)))), ((int)(((byte)(37)))));
            this.logginBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(85)))), ((int)(((byte)(37)))));
            this.logginBtn.FlatAppearance.BorderSize = 0;
            this.logginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logginBtn.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.logginBtn.Location = new System.Drawing.Point(97, 324);
            this.logginBtn.Margin = new System.Windows.Forms.Padding(0);
            this.logginBtn.Name = "logginBtn";
            this.logginBtn.Size = new System.Drawing.Size(180, 46);
            this.logginBtn.TabIndex = 3;
            this.logginBtn.Text = "Loggin";
            this.logginBtn.UseVisualStyleBackColor = false;
            this.logginBtn.Click += new System.EventHandler(this.LogginBtn_Click);
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(97, 201);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(180, 23);
            this.userTextBox.TabIndex = 1;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.userLabel.Location = new System.Drawing.Point(97, 170);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(51, 28);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "User";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.passwordLabel.Location = new System.Drawing.Point(97, 227);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(94, 28);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(97, 258);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(180, 23);
            this.passwordTextBox.TabIndex = 2;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.InfoLabel.Location = new System.Drawing.Point(97, 286);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(0, 19);
            this.InfoLabel.TabIndex = 5;
            // 
            // LogoPicBox
            // 
            this.LogoPicBox.Image = global::Pastelaria.WindowsApp.Properties.Resources.logoSemFundo;
            this.LogoPicBox.Location = new System.Drawing.Point(97, 12);
            this.LogoPicBox.Name = "LogoPicBox";
            this.LogoPicBox.Size = new System.Drawing.Size(170, 140);
            this.LogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPicBox.TabIndex = 8;
            this.LogoPicBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(123)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.LogoPicBox);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.logginBtn);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logginBtn;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.PictureBox LogoPicBox;
    }
}