using Autofac;
using Pastelaria.RescourcesLib;
using Pastelaria.WindowsApp.Config;
using Pastelaria.WindowsApp.Costumer;
using Pastelaria.WindowsApp.Employee;
using Pastelaria.WindowsApp.OrderPad;
using Pastelaria.WindowsApp.Product;
using Pastelaria.WindowsApp.Shared;
using Serilog;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp
{
    public partial class MainFrameForm : Form
    {
        private static IRegisterable operations;
        public static MainFrameForm instance { get => instance; set => instance = value; }
        public static Domain.Employee LoggedEmployee { get; set; }

        public MainFrameForm()
        { 
            InitializeComponent();
            lblRegisterType.Text = "Title :)";
            toolBoxActions.Renderer = new NoLoadToolStripRenderer();
            UpdateFooter(GeneralConfig.Data["Welcome"] + " " + LoggedEmployee.Name);
            ConfigureTexts();
            SystemColors.ConfigureColors(Controls);

            //Padding = new (2);
            //BackColor = System.Drawing.Color.FromArgb(28, 31, 51);
            // this button have the same collor of the panel :/
            ibtnMenu.BackColor = SystemColors.ThirdColor;
            ibtnMenu.ForeColor = SystemColors.TextColor;
            btnFilter.Enabled = false;
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | MainFrame Loaded");
        }

        #region SideMenu

        private System.Drawing.Size formSize;

        #region Form Resize
        protected override void WndProc(ref Message m)
        {

            const int WM_NCCALCSIZE = 0x0083;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; 
            const int SC_RESTORE = 0xF120;
            const int WM_NCHITTEST = 0x0084;
            const int resizeAreaSize = 10;

            

            const int HTCLIENT = 1;
            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;
            
            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)
                {
                    if ((int)m.Result == HTCLIENT)
                    {
                        System.Drawing.Point screenPoint = new (m.LParam.ToInt32());
                        System.Drawing.Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= resizeAreaSize)
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTTOPLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTTOP;
                            else
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize))
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))
                                m.Result = (IntPtr)HTBOTTOM;
                            else
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }

            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            if (m.Msg == WM_SYSCOMMAND)
            {
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }
        #endregion        
        private void MenuBtn_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (panelMenu.Width > 200)
            {
                panelMenu.Width = 120;
                logoPic.Visible = false;
                LogoPicBox.Visible = false;
                ibtnMenu.Dock = DockStyle.Top;
                logoPanel.Height = 50;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                    menuButton.Width = 120;
                }
            }
            else
            {
                panelMenu.Width = 250;
                logoPic.Visible = true;
                LogoPicBox.Visible = true;
                ibtnMenu.Dock = DockStyle.None;
                logoPanel.Height = 140;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                    menuButton.Width = 250;
                }
            }
        }
        #endregion

        #region WindowsButtons

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximaziBtn_Click(object sender, EventArgs e)
        {
            _ = this.WindowState == FormWindowState.Normal ? this.WindowState = FormWindowState.Maximized :
                                                             this.WindowState = FormWindowState.Normal;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(GeneralConfig.Data["Are you sure that you want to quit"] + "?", "Pastelaria"
                                , MessageBoxButtons.YesNo
                                , MessageBoxIcon.Exclamation) == DialogResult.Yes)
                Application.Exit();
            else
            {
                this.Hide();
                notifyIconSystemTray.ShowBalloonTip(1000,"Pastelaria","Application minimized",ToolTipIcon.Info);
            }
        }

        private void MainFrameForm_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != 2)
                        this.Padding = new Padding(2);
                    break;
            }
        }
        #endregion

        #region Buttons
        private void employeeBtn_Click(object sender, EventArgs e)
        {
            EmployeeConfigurationToolBox configurationToolBox = new();

            ToolboxConfig(configurationToolBox, false);

            UpdateFooter(configurationToolBox.ToolType);

            operations = AutoFac.Container.Resolve<EmployeeOperations>();

            DataConfig();

            UpdateTitle("Employee");

            btnFilter.Enabled = false;
        }

        private void costumersBtn_Click(object sender, EventArgs e)
        {
            CostumerConfigurationToolBox configurationToolBox = new();

            ToolboxConfig(configurationToolBox, false);

            UpdateFooter(configurationToolBox.ToolType);

            operations = AutoFac.Container.Resolve<CostumerOperations>();

            DataConfig();

            UpdateTitle("Costumer");

            btnFilter.Enabled = false;
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            btnFilter.Enabled = false;

            ProductConfigurationToolBox configurationToolBox = new();

            ToolboxConfig(configurationToolBox, false);

            UpdateFooter(configurationToolBox.ToolType);

            operations = AutoFac.Container.Resolve<ProductOperations>();

            DataConfig();

            UpdateTitle("Product");

            btnFilter.Enabled = false;
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            btnFilter.Enabled = true;

            OrderPadConfigurationToolBox configurationToolBox = new();

            ToolboxConfig(configurationToolBox, false);

            UpdateFooter(configurationToolBox.ToolType);

            operations = AutoFac.Container.Resolve<OrderPadOperations>();

            DataConfig();

            UpdateTitle("Orders");
        }

        private void configBtn_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new();
            configForm.ShowDialog();
            ConfigureTexts();
        }

        private void logutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new();
            loginForm.ShowDialog();
            this.Close();
        }

        #endregion

        #region Privates

        private void iconMenuItemOpen_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void iconMenuItemExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(GeneralConfig.Data["Are you sure that you want to quit"] + "?", "Pastelaria"
                               , MessageBoxButtons.YesNo
                               , MessageBoxIcon.Exclamation) == DialogResult.Yes)
                Application.Exit();
        }

        private void ToolboxConfig(IConfigurationToolBox configuration, bool filter)
        {
            toolBoxActions.Enabled = true;
            filter = true ? btnFilter.Enabled = true : btnFilter.Enabled = false;

            lblRegisterType.Text = configuration.ToolType;
            btnAdd.Text = configuration.ToolTipAdd;
            btnEdit.Text = configuration.ToolTipEdit;
            btnRemove.Text = configuration.ToolTipRemove;
            btnFilter.Text = configuration.ToolTipSpun;
        }

        private void DataConfig()
        {
            UserControl table = operations.ObtainTable();
            table.Dock = DockStyle.Fill;
            DataPanel.Controls.Clear();
            DataPanel.Controls.Add(table);
        }

        private void MainFrameForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:

                    break;
                case Keys.F2:
                    employeeBtn_Click(sender, e);
                    break;
                case Keys.F3:
                    productBtn_Click(sender, e);
                    break;
                case Keys.F4:
                    costumersBtn_Click(sender, e);
                    break;
                case Keys.F5:

                    break;
                case Keys.F6:
                    orderBtn_Click(sender, e);
                    break;
                case Keys.F7:

                    break;
                case Keys.F8:
                    configBtn_Click(sender, e);
                    break;
                case Keys.F9:
                    logutBtn_Click(sender, e);
                    break;
            }
        }

        #endregion

        #region Buttons actions
        private void btnAdd_Click(object sender, EventArgs e)
        {
            operations.RegisterInsertNew();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            operations.RegisterUpdate();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            operations.RegisterRemove();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            operations.RegistersFilter();
        }

        private void ConfigureTexts()
        {
            this.ibtnHome.Text = GeneralConfig.Data["Home"];
            this.ibtnEmployee.Text = GeneralConfig.Data["Employees"];
            this.ibtnProduct.Text = GeneralConfig.Data["Products"];
            this.ibtnCustomers.Text = GeneralConfig.Data["Customers"];
            this.ibtnSell.Text = GeneralConfig.Data["Sells"];
            this.ibtnOrder.Text = GeneralConfig.Data["Orders"];
            this.ibtnDebit.Text = GeneralConfig.Data["Debits"];
            this.ibtnConfig.Text = GeneralConfig.Data["Configuration"];
            this.contextMenuStripSystemTray.Items[0].Text = GeneralConfig.Data["Exit"];
            this.contextMenuStripSystemTray.Items[1].Text = GeneralConfig.Data["Open"];
        }

        private void ConfigureCollors()
        {
           foreach(Label lbl in this.Controls)
            {
                //lbl.ForeColor = 
            }
        }

        #endregion

        public void UpdateFooter(string Message)
        {
            lblFooter.Text = Message;
            lblFooter.Font = new System.Drawing.Font("Segoe UI", this.lblFooter.Font.Size);
        }

        public void UpdateTitle(string title)
        {
            this.lblTitle.Text = title;
        }

    }
}
