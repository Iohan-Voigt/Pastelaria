namespace Pastelaria.WindowsApp
{
    partial class MainFrameForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.minimizeBtn = new FontAwesome.Sharp.IconButton();
            this.maximaziBtn = new FontAwesome.Sharp.IconButton();
            this.exitBtn = new FontAwesome.Sharp.IconButton();
            this.minimizeBtn2 = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(112)))), ((int)(((byte)(184)))));
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.Crimson;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 681);
            this.panelMenu.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.minimizeBtn);
            this.panelTitleBar.Controls.Add(this.maximaziBtn);
            this.panelTitleBar.Controls.Add(this.exitBtn);
            this.panelTitleBar.Controls.Add(this.minimizeBtn2);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(250, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1014, 50);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(112)))), ((int)(((byte)(184)))));
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.minimizeBtn.IconColor = System.Drawing.Color.Black;
            this.minimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeBtn.IconSize = 15;
            this.minimizeBtn.Location = new System.Drawing.Point(894, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(40, 25);
            this.minimizeBtn.TabIndex = 4;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // maximaziBtn
            // 
            this.maximaziBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximaziBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(120)))));
            this.maximaziBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximaziBtn.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.maximaziBtn.IconColor = System.Drawing.Color.Black;
            this.maximaziBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximaziBtn.IconSize = 15;
            this.maximaziBtn.Location = new System.Drawing.Point(934, 0);
            this.maximaziBtn.Name = "maximaziBtn";
            this.maximaziBtn.Size = new System.Drawing.Size(40, 25);
            this.maximaziBtn.TabIndex = 3;
            this.maximaziBtn.UseVisualStyleBackColor = false;
            this.maximaziBtn.Click += new System.EventHandler(this.maximaziBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(97)))), ((int)(((byte)(101)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.exitBtn.IconColor = System.Drawing.Color.Black;
            this.exitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitBtn.IconSize = 15;
            this.exitBtn.Location = new System.Drawing.Point(974, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Rotation = 45D;
            this.exitBtn.Size = new System.Drawing.Size(40, 25);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // minimizeBtn2
            // 
            this.minimizeBtn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(112)))), ((int)(((byte)(184)))));
            this.minimizeBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn2.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.minimizeBtn2.IconColor = System.Drawing.Color.Black;
            this.minimizeBtn2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeBtn2.IconSize = 15;
            this.minimizeBtn2.Location = new System.Drawing.Point(894, 0);
            this.minimizeBtn2.Name = "minimizeBtn2";
            this.minimizeBtn2.Size = new System.Drawing.Size(40, 25);
            this.minimizeBtn2.TabIndex = 0;
            this.minimizeBtn2.UseVisualStyleBackColor = false;
            // 
            // MainFrameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(151)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainFrameForm";
            this.Text = "MainFrameForm";
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton minimizeBtn2;
        private FontAwesome.Sharp.IconButton exitBtn;
        private FontAwesome.Sharp.IconButton maximaziBtn;
        private FontAwesome.Sharp.IconButton minimizeBtn;
    }
}