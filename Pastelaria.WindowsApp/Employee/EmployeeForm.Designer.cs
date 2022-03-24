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
            this.label = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelIdentifyDocument = new System.Windows.Forms.Label();
            this.textBoxIdentifyDocument = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
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
            this.textBoxID.Location = new System.Drawing.Point(36, 58);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(298, 23);
            this.textBoxID.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.label.Location = new System.Drawing.Point(36, 84);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(64, 28);
            this.label.TabIndex = 1;
            this.label.Text = "Name";
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
            // textBoxIdentifyDocument
            // 
            this.textBoxIdentifyDocument.Location = new System.Drawing.Point(36, 172);
            this.textBoxIdentifyDocument.MaxLength = 14;
            this.textBoxIdentifyDocument.Name = "textBoxIdentifyDocument";
            this.textBoxIdentifyDocument.Size = new System.Drawing.Size(298, 23);
            this.textBoxIdentifyDocument.TabIndex = 3;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.labelPhoneNumber.Location = new System.Drawing.Point(36, 198);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(144, 28);
            this.labelPhoneNumber.TabIndex = 4;
            this.labelPhoneNumber.Text = "Phone Number";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(36, 229);
            this.maskedTextBox1.Mask = "(00) 0 0000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(174, 23);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(123)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.textBoxIdentifyDocument);
            this.Controls.Add(this.labelIdentifyDocument);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelIdentifyDocument;
        private System.Windows.Forms.TextBox textBoxIdentifyDocument;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}