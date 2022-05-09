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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrameForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.ibtnCustomers = new FontAwesome.Sharp.IconButton();
            this.ibtnConfig = new FontAwesome.Sharp.IconButton();
            this.ibtnOrder = new FontAwesome.Sharp.IconButton();
            this.ibtnDebit = new FontAwesome.Sharp.IconButton();
            this.ibtnSell = new FontAwesome.Sharp.IconButton();
            this.ibtnProduct = new FontAwesome.Sharp.IconButton();
            this.ibtnEmployee = new FontAwesome.Sharp.IconButton();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.LogoPicBox = new System.Windows.Forms.PictureBox();
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.ibtnMenu = new FontAwesome.Sharp.IconButton();
            this.ibtnLogut = new FontAwesome.Sharp.IconButton();
            this.ibtnHome = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.toolBoxActions = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnRemove = new System.Windows.Forms.ToolStripButton();
            this.btnFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblRegisterType = new System.Windows.Forms.ToolStripLabel();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.FooterLabel = new System.Windows.Forms.Label();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.notifyIconSystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripSystemTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.iconMenuItemExit = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItemOpen = new FontAwesome.Sharp.IconMenuItem();
            this.panelMenu.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.toolBoxActions.SuspendLayout();
            this.DataPanel.SuspendLayout();
            this.footerPanel.SuspendLayout();
            this.contextMenuStripSystemTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(85)))), ((int)(((byte)(37)))));
            this.panelMenu.Controls.Add(this.ibtnCustomers);
            this.panelMenu.Controls.Add(this.ibtnConfig);
            this.panelMenu.Controls.Add(this.ibtnOrder);
            this.panelMenu.Controls.Add(this.ibtnDebit);
            this.panelMenu.Controls.Add(this.ibtnSell);
            this.panelMenu.Controls.Add(this.ibtnProduct);
            this.panelMenu.Controls.Add(this.ibtnEmployee);
            this.panelMenu.Controls.Add(this.logoPanel);
            this.panelMenu.Controls.Add(this.ibtnLogut);
            this.panelMenu.Controls.Add(this.ibtnHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelMenu.ForeColor = System.Drawing.Color.Crimson;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 681);
            this.panelMenu.TabIndex = 0;
            // 
            // ibtnCustomers
            // 
            this.ibtnCustomers.FlatAppearance.BorderSize = 0;
            this.ibtnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCustomers.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibtnCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnCustomers.IconChar = FontAwesome.Sharp.IconChar.Restroom;
            this.ibtnCustomers.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnCustomers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCustomers.IconSize = 50;
            this.ibtnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnCustomers.Location = new System.Drawing.Point(0, 280);
            this.ibtnCustomers.Margin = new System.Windows.Forms.Padding(0);
            this.ibtnCustomers.Name = "ibtnCustomers";
            this.ibtnCustomers.Size = new System.Drawing.Size(250, 45);
            this.ibtnCustomers.TabIndex = 5;
            this.ibtnCustomers.Tag = "Customers";
            this.ibtnCustomers.Text = "Costumers";
            this.ibtnCustomers.UseVisualStyleBackColor = false;
            this.ibtnCustomers.Click += new System.EventHandler(this.costumersBtn_Click);
            // 
            // ibtnConfig
            // 
            this.ibtnConfig.FlatAppearance.BorderSize = 0;
            this.ibtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnConfig.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibtnConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnConfig.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.ibtnConfig.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnConfig.IconSize = 50;
            this.ibtnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnConfig.Location = new System.Drawing.Point(0, 576);
            this.ibtnConfig.Margin = new System.Windows.Forms.Padding(0);
            this.ibtnConfig.Name = "ibtnConfig";
            this.ibtnConfig.Size = new System.Drawing.Size(250, 45);
            this.ibtnConfig.TabIndex = 9;
            this.ibtnConfig.Tag = "Configurations";
            this.ibtnConfig.Text = "Configurations";
            this.ibtnConfig.UseVisualStyleBackColor = false;
            this.ibtnConfig.Click += new System.EventHandler(this.configBtn_Click);
            // 
            // ibtnOrder
            // 
            this.ibtnOrder.FlatAppearance.BorderSize = 0;
            this.ibtnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnOrder.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibtnOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnOrder.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            this.ibtnOrder.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnOrder.IconSize = 50;
            this.ibtnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnOrder.Location = new System.Drawing.Point(0, 370);
            this.ibtnOrder.Margin = new System.Windows.Forms.Padding(0);
            this.ibtnOrder.Name = "ibtnOrder";
            this.ibtnOrder.Size = new System.Drawing.Size(250, 45);
            this.ibtnOrder.TabIndex = 7;
            this.ibtnOrder.Tag = "Orders";
            this.ibtnOrder.Text = "Orders";
            this.ibtnOrder.UseVisualStyleBackColor = false;
            this.ibtnOrder.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // ibtnDebit
            // 
            this.ibtnDebit.FlatAppearance.BorderSize = 0;
            this.ibtnDebit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDebit.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibtnDebit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnDebit.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.ibtnDebit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnDebit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDebit.IconSize = 50;
            this.ibtnDebit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnDebit.Location = new System.Drawing.Point(0, 415);
            this.ibtnDebit.Margin = new System.Windows.Forms.Padding(0);
            this.ibtnDebit.Name = "ibtnDebit";
            this.ibtnDebit.Size = new System.Drawing.Size(250, 45);
            this.ibtnDebit.TabIndex = 8;
            this.ibtnDebit.Tag = "Debits";
            this.ibtnDebit.Text = "Debits";
            this.ibtnDebit.UseVisualStyleBackColor = false;
            // 
            // ibtnSell
            // 
            this.ibtnSell.FlatAppearance.BorderSize = 0;
            this.ibtnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSell.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibtnSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnSell.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.ibtnSell.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnSell.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSell.IconSize = 50;
            this.ibtnSell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSell.Location = new System.Drawing.Point(0, 325);
            this.ibtnSell.Margin = new System.Windows.Forms.Padding(0);
            this.ibtnSell.Name = "ibtnSell";
            this.ibtnSell.Size = new System.Drawing.Size(250, 45);
            this.ibtnSell.TabIndex = 6;
            this.ibtnSell.Tag = "Sells";
            this.ibtnSell.Text = "Sells";
            this.ibtnSell.UseVisualStyleBackColor = false;
            // 
            // ibtnProduct
            // 
            this.ibtnProduct.FlatAppearance.BorderSize = 0;
            this.ibtnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnProduct.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibtnProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnProduct.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.ibtnProduct.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnProduct.IconSize = 50;
            this.ibtnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnProduct.Location = new System.Drawing.Point(0, 235);
            this.ibtnProduct.Margin = new System.Windows.Forms.Padding(0);
            this.ibtnProduct.Name = "ibtnProduct";
            this.ibtnProduct.Size = new System.Drawing.Size(250, 45);
            this.ibtnProduct.TabIndex = 4;
            this.ibtnProduct.Tag = "Products";
            this.ibtnProduct.Text = "Products";
            this.ibtnProduct.UseVisualStyleBackColor = false;
            this.ibtnProduct.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // ibtnEmployee
            // 
            this.ibtnEmployee.FlatAppearance.BorderSize = 0;
            this.ibtnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnEmployee.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibtnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnEmployee.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry;
            this.ibtnEmployee.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEmployee.IconSize = 50;
            this.ibtnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnEmployee.Location = new System.Drawing.Point(0, 190);
            this.ibtnEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.ibtnEmployee.Name = "ibtnEmployee";
            this.ibtnEmployee.Size = new System.Drawing.Size(250, 45);
            this.ibtnEmployee.TabIndex = 3;
            this.ibtnEmployee.Tag = "Employees";
            this.ibtnEmployee.Text = "Employees";
            this.ibtnEmployee.UseVisualStyleBackColor = false;
            this.ibtnEmployee.Click += new System.EventHandler(this.employeeBtn_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.LogoPicBox);
            this.logoPanel.Controls.Add(this.logoPic);
            this.logoPanel.Controls.Add(this.ibtnMenu);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(250, 140);
            this.logoPanel.TabIndex = 1;
            // 
            // LogoPicBox
            // 
            this.LogoPicBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPicBox.Image")));
            this.LogoPicBox.Location = new System.Drawing.Point(0, 0);
            this.LogoPicBox.Name = "LogoPicBox";
            this.LogoPicBox.Size = new System.Drawing.Size(170, 140);
            this.LogoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPicBox.TabIndex = 7;
            this.LogoPicBox.TabStop = false;
            this.LogoPicBox.Tag = "Logo";
            // 
            // logoPic
            // 
            this.logoPic.Location = new System.Drawing.Point(0, 0);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(170, 140);
            this.logoPic.TabIndex = 6;
            this.logoPic.TabStop = false;
            // 
            // ibtnMenu
            // 
            this.ibtnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibtnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(85)))), ((int)(((byte)(37)))));
            this.ibtnMenu.FlatAppearance.BorderSize = 0;
            this.ibtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.ibtnMenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMenu.IconSize = 50;
            this.ibtnMenu.Location = new System.Drawing.Point(176, 37);
            this.ibtnMenu.Name = "ibtnMenu";
            this.ibtnMenu.Size = new System.Drawing.Size(70, 50);
            this.ibtnMenu.TabIndex = 1;
            this.ibtnMenu.Tag = "Menu";
            this.ibtnMenu.UseVisualStyleBackColor = false;
            this.ibtnMenu.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // ibtnLogut
            // 
            this.ibtnLogut.FlatAppearance.BorderSize = 0;
            this.ibtnLogut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnLogut.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibtnLogut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnLogut.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.ibtnLogut.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnLogut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLogut.IconSize = 50;
            this.ibtnLogut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLogut.Location = new System.Drawing.Point(0, 624);
            this.ibtnLogut.Name = "ibtnLogut";
            this.ibtnLogut.Size = new System.Drawing.Size(250, 45);
            this.ibtnLogut.TabIndex = 10;
            this.ibtnLogut.Tag = "Logout";
            this.ibtnLogut.Text = "Logout";
            this.ibtnLogut.UseVisualStyleBackColor = true;
            this.ibtnLogut.Click += new System.EventHandler(this.logutBtn_Click);
            // 
            // ibtnHome
            // 
            this.ibtnHome.FlatAppearance.BorderSize = 0;
            this.ibtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnHome.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ibtnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ibtnHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.ibtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnHome.IconSize = 50;
            this.ibtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnHome.Location = new System.Drawing.Point(0, 145);
            this.ibtnHome.Margin = new System.Windows.Forms.Padding(0);
            this.ibtnHome.Name = "ibtnHome";
            this.ibtnHome.Size = new System.Drawing.Size(250, 45);
            this.ibtnHome.TabIndex = 2;
            this.ibtnHome.Tag = "Home";
            this.ibtnHome.Text = "Home";
            this.ibtnHome.UseVisualStyleBackColor = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(85)))), ((int)(((byte)(37)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.panelTitleBar.Location = new System.Drawing.Point(250, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1014, 50);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(-1, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(146, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DashBorad";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(112)))), ((int)(((byte)(184)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 15;
            this.btnMinimize.Location = new System.Drawing.Point(894, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 25);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(73)))), ((int)(((byte)(120)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 15;
            this.btnMaximize.Location = new System.Drawing.Point(934, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(40, 25);
            this.btnMaximize.TabIndex = 0;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.MaximaziBtn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(97)))), ((int)(((byte)(101)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnExit.IconColor = System.Drawing.Color.Black;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 15;
            this.btnExit.Location = new System.Drawing.Point(974, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Rotation = 45D;
            this.btnExit.Size = new System.Drawing.Size(40, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // toolBoxActions
            // 
            this.toolBoxActions.AutoSize = false;
            this.toolBoxActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(85)))), ((int)(((byte)(37)))));
            this.toolBoxActions.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolBoxActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnRemove,
            this.btnFilter,
            this.toolStripSeparator1,
            this.lblRegisterType});
            this.toolBoxActions.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolBoxActions.Location = new System.Drawing.Point(250, 50);
            this.toolBoxActions.Name = "toolBoxActions";
            this.toolBoxActions.Padding = new System.Windows.Forms.Padding(0);
            this.toolBoxActions.Size = new System.Drawing.Size(1014, 50);
            this.toolBoxActions.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(52, 47);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(52, 47);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(52, 47);
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilter.Enabled = false;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(52, 47);
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // lblRegisterType
            // 
            this.lblRegisterType.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.lblRegisterType.Name = "lblRegisterType";
            this.lblRegisterType.Size = new System.Drawing.Size(25, 47);
            this.lblRegisterType.Text = "1";
            // 
            // DataPanel
            // 
            this.DataPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(123)))), ((int)(((byte)(0)))));
            this.DataPanel.Controls.Add(this.FooterLabel);
            this.DataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataPanel.Location = new System.Drawing.Point(250, 100);
            this.DataPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(1014, 581);
            this.DataPanel.TabIndex = 3;
            // 
            // FooterLabel
            // 
            this.FooterLabel.AutoSize = true;
            this.FooterLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FooterLabel.Location = new System.Drawing.Point(3, 575);
            this.FooterLabel.Name = "FooterLabel";
            this.FooterLabel.Size = new System.Drawing.Size(0, 28);
            this.FooterLabel.TabIndex = 4;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(85)))), ((int)(((byte)(37)))));
            this.footerPanel.Controls.Add(this.lblFooter);
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(250, 640);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1014, 41);
            this.footerPanel.TabIndex = 4;
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(225)))));
            this.lblFooter.Location = new System.Drawing.Point(3, 1);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(58, 37);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "asd";
            // 
            // notifyIconSystemTray
            // 
            this.notifyIconSystemTray.ContextMenuStrip = this.contextMenuStripSystemTray;
            this.notifyIconSystemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconSystemTray.Icon")));
            this.notifyIconSystemTray.Text = "Pastelaria";
            this.notifyIconSystemTray.Visible = true;
            // 
            // contextMenuStripSystemTray
            // 
            this.contextMenuStripSystemTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItemExit,
            this.iconMenuItemOpen});
            this.contextMenuStripSystemTray.Name = "contextMenuStripSystemTray";
            this.contextMenuStripSystemTray.Size = new System.Drawing.Size(104, 48);
            // 
            // iconMenuItemExit
            // 
            this.iconMenuItemExit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItemExit.IconColor = System.Drawing.Color.Black;
            this.iconMenuItemExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItemExit.Name = "iconMenuItemExit";
            this.iconMenuItemExit.Size = new System.Drawing.Size(103, 22);
            this.iconMenuItemExit.Text = "Exit";
            this.iconMenuItemExit.Click += new System.EventHandler(this.iconMenuItemExit_Click);
            // 
            // iconMenuItemOpen
            // 
            this.iconMenuItemOpen.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItemOpen.IconColor = System.Drawing.Color.Black;
            this.iconMenuItemOpen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItemOpen.Name = "iconMenuItemOpen";
            this.iconMenuItemOpen.Size = new System.Drawing.Size(103, 22);
            this.iconMenuItemOpen.Text = "Open";
            this.iconMenuItemOpen.Click += new System.EventHandler(this.iconMenuItemOpen_Click);
            // 
            // MainFrameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(151)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.toolBoxActions);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainFrameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrameForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFrameForm_KeyDown);
            this.Resize += new System.EventHandler(this.MainFrameForm_Resize);
            this.panelMenu.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.toolBoxActions.ResumeLayout(false);
            this.toolBoxActions.PerformLayout();
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            this.footerPanel.ResumeLayout(false);
            this.footerPanel.PerformLayout();
            this.contextMenuStripSystemTray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton ibtnLogut;
        private FontAwesome.Sharp.IconButton ibtnHome;
        private System.Windows.Forms.Panel logoPanel;
        private FontAwesome.Sharp.IconButton ibtnMenu;
        private System.Windows.Forms.PictureBox logoPic;
        private FontAwesome.Sharp.IconButton ibtnEmployee;
        private FontAwesome.Sharp.IconButton ibtnProduct;
        private FontAwesome.Sharp.IconButton ibtnSell;
        private FontAwesome.Sharp.IconButton ibtnDebit;
        private FontAwesome.Sharp.IconButton ibtnOrder;
        private FontAwesome.Sharp.IconButton ibtnConfig;
        private FontAwesome.Sharp.IconButton ibtnCustomers;
        private System.Windows.Forms.PictureBox LogoPicBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStrip toolBoxActions;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnRemove;
        private System.Windows.Forms.ToolStripButton btnFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblRegisterType;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Label FooterLabel;
        private System.Windows.Forms.Panel footerPanel;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.NotifyIcon notifyIconSystemTray;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSystemTray;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemExit;
        private FontAwesome.Sharp.IconMenuItem iconMenuItemOpen;
    }
}