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
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.menuBtn = new FontAwesome.Sharp.IconButton();
            this.logutBtn = new FontAwesome.Sharp.IconButton();
            this.homeBtn = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.titleLable = new System.Windows.Forms.Label();
            this.minimizeBtn = new FontAwesome.Sharp.IconButton();
            this.maximaziBtn = new FontAwesome.Sharp.IconButton();
            this.exitBtn = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(112)))), ((int)(((byte)(184)))));
            this.panelMenu.Controls.Add(this.logoPanel);
            this.panelMenu.Controls.Add(this.logutBtn);
            this.panelMenu.Controls.Add(this.homeBtn);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.Color.Crimson;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 681);
            this.panelMenu.TabIndex = 0;
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.logoPic);
            this.logoPanel.Controls.Add(this.menuBtn);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(250, 140);
            this.logoPanel.TabIndex = 1;
            // 
            // logoPic
            // 
            this.logoPic.Location = new System.Drawing.Point(0, 0);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(170, 140);
            this.logoPic.TabIndex = 6;
            this.logoPic.TabStop = false;
            // 
            // menuBtn
            // 
            this.menuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(112)))), ((int)(((byte)(184)))));
            this.menuBtn.FlatAppearance.BorderSize = 0;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.menuBtn.IconColor = System.Drawing.Color.Black;
            this.menuBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuBtn.IconSize = 50;
            this.menuBtn.Location = new System.Drawing.Point(176, 37);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(70, 50);
            this.menuBtn.TabIndex = 1;
            this.menuBtn.Tag = "Menu";
            this.menuBtn.UseVisualStyleBackColor = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // logutBtn
            // 
            this.logutBtn.FlatAppearance.BorderSize = 0;
            this.logutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logutBtn.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logutBtn.ForeColor = System.Drawing.Color.Black;
            this.logutBtn.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.logutBtn.IconColor = System.Drawing.Color.Black;
            this.logutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logutBtn.IconSize = 50;
            this.logutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logutBtn.Location = new System.Drawing.Point(0, 624);
            this.logutBtn.Name = "logutBtn";
            this.logutBtn.Size = new System.Drawing.Size(250, 45);
            this.logutBtn.TabIndex = 3;
            this.logutBtn.Tag = "Logout";
            this.logutBtn.Text = "Logout";
            this.logutBtn.UseVisualStyleBackColor = true;
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeBtn.ForeColor = System.Drawing.Color.Black;
            this.homeBtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.homeBtn.IconColor = System.Drawing.Color.Black;
            this.homeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeBtn.IconSize = 50;
            this.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeBtn.Location = new System.Drawing.Point(0, 145);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(250, 45);
            this.homeBtn.TabIndex = 2;
            this.homeBtn.Tag = "Home";
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.titleLable);
            this.panelTitleBar.Controls.Add(this.minimizeBtn);
            this.panelTitleBar.Controls.Add(this.maximaziBtn);
            this.panelTitleBar.Controls.Add(this.exitBtn);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(250, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1014, 50);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLable.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLable.Location = new System.Drawing.Point(-1, 6);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(146, 37);
            this.titleLable.TabIndex = 0;
            this.titleLable.Text = "DashBorad";
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(112)))), ((int)(((byte)(184)))));
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.minimizeBtn.IconColor = System.Drawing.Color.Black;
            this.minimizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimizeBtn.IconSize = 15;
            this.minimizeBtn.Location = new System.Drawing.Point(894, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(40, 25);
            this.minimizeBtn.TabIndex = 0;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // maximaziBtn
            // 
            this.maximaziBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximaziBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(120)))));
            this.maximaziBtn.FlatAppearance.BorderSize = 0;
            this.maximaziBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximaziBtn.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.maximaziBtn.IconColor = System.Drawing.Color.Black;
            this.maximaziBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximaziBtn.IconSize = 15;
            this.maximaziBtn.Location = new System.Drawing.Point(934, 0);
            this.maximaziBtn.Name = "maximaziBtn";
            this.maximaziBtn.Size = new System.Drawing.Size(40, 25);
            this.maximaziBtn.TabIndex = 0;
            this.maximaziBtn.UseVisualStyleBackColor = false;
            this.maximaziBtn.Click += new System.EventHandler(this.maximaziBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(97)))), ((int)(((byte)(101)))));
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.exitBtn.IconColor = System.Drawing.Color.Black;
            this.exitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitBtn.IconSize = 15;
            this.exitBtn.Location = new System.Drawing.Point(974, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Rotation = 45D;
            this.exitBtn.Size = new System.Drawing.Size(40, 25);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MainFrameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(151)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainFrameForm";
            this.Text = "MainFrameForm";
            this.Resize += new System.EventHandler(this.MainFrameForm_Resize);
            this.panelMenu.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton exitBtn;
        private FontAwesome.Sharp.IconButton maximaziBtn;
        private FontAwesome.Sharp.IconButton minimizeBtn;
        private System.Windows.Forms.Label titleLable;
        private FontAwesome.Sharp.IconButton logutBtn;
        private FontAwesome.Sharp.IconButton homeBtn;
        private System.Windows.Forms.Panel logoPanel;
        private FontAwesome.Sharp.IconButton menuBtn;
        private System.Windows.Forms.PictureBox logoPic;
    }
}