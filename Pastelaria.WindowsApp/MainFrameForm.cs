using Autofac;
using Pastelaria.WindowsApp.Costumer;
using Pastelaria.WindowsApp.Employee;
using Pastelaria.WindowsApp.Product;
using Pastelaria.WindowsApp.Shared;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp
{
    public partial class MainFrameForm : Form
    {
        private static IRegisterable operations;

        private static MainFrameForm instance { get; set; }
        public static Domain.Employee LoggedEmployee { get; set; }

        public MainFrameForm()
        {

            InitializeComponent();
            this.Padding = new (2);
            this.BackColor = Color.FromArgb(28, 31, 51);
        }

            private Size formSize;

        #region SideMenu
        protected override void WndProc(ref Message m)
        {

            const int WM_NCCALCSIZE = 0x0083;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; 
            const int SC_RESTORE = 0xF120;
            const int WM_NCHITTEST = 0x0084;
            const int resizeAreaSize = 10;
            #region Form Resize

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
                        Point screenPoint = new (m.LParam.ToInt32());                        
                        Point clientPoint = this.PointToClient(screenPoint);
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
            #endregion
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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200)
            {
                panelMenu.Width = 120;
                logoPic.Visible = false;
                LogoPicBox.Visible = false;
                menuBtn.Dock = DockStyle.Top;
                logoPanel.Height = 50;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                    menuButton.Width = 120;
                }
            }
            else
            {
                panelMenu.Width = 250;
                logoPic.Visible = true;
                LogoPicBox.Visible = true;
                menuBtn.Dock = DockStyle.None;
                logoPanel.Height = 140;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                    menuButton.Width = 250;
                }
            }
        }
        #region Buttons
        private void employeeBtn_Click(object sender, EventArgs e)
        {

            EmployeeConfigurationToolBox configurationToolBox = new();

            ToolboxConfig(configurationToolBox, false);

            UpdateFooter(configurationToolBox.ToolType);

            operations = AutoFac.Container.Resolve<EmployeeOperations>();

            DataConfig();

            UpdateTitle("Employee");
        }

        private void costumersBtn_Click(object sender, EventArgs e)
        {
            CostumerConfigurationToolBox configurationToolBox = new();

            ToolboxConfig(configurationToolBox, false);

            UpdateFooter(configurationToolBox.ToolType);

            operations = AutoFac.Container.Resolve<CostumerOperations>();

            DataConfig();

            UpdateTitle("Costumer");
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            ProductConfigurationToolBox configurationToolBox = new();

            ToolboxConfig(configurationToolBox, false);

            UpdateFooter(configurationToolBox.ToolType);

            operations = AutoFac.Container.Resolve<ProductOperations>();

            DataConfig();

            UpdateTitle("Product");
        }

        #endregion

        #region Privates
        private void UpdateFooter(string Message)
        {
            footerLabel1.Text = Message;
            footerLabel1.Font = new Font("Segoe UI", this.footerLabel1.Font.Size);
        }
        private void ToolboxConfig(IConfigurationToolBox configuration, bool canFilter)
        {
            toolBoxActions.Enabled = true;
            canFilter = true? btnFilter.Enabled = true : btnFilter.Enabled = false;

            labelRegisterType.Text = configuration.ToolType;
            btnAdd.Text = configuration.ToolTipAdd;
            btnEdit.Text = configuration.ToolTipEdit;
            btnRemove.Text = configuration.ToolTipRemove;
        }

        private void DataConfig()
        {
            UserControl table = operations.ObtainTable();
            table.Dock = DockStyle.Fill;
            DataPanel.Controls.Clear();
            DataPanel.Controls.Add(table);
        }
        #endregion

        private void MainFrameForm_Load(object sender, EventArgs e)
        {

        }

        public void UpdateTitle(string title)
        {
            this.titleLable.Text = title;
        }



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
        #endregion

        
    }
}
