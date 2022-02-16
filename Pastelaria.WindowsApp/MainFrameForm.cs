using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp
{
    public partial class MainFrameForm : Form
    {
        public MainFrameForm()
        {
            InitializeComponent();
            this.Padding = new System.Windows.Forms.Padding(2);
            this.BackColor = Color.FromArgb(28, 31, 51);
            this.minimizeBtn2.Padding = new System.Windows.Forms.Padding(1);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
                return;
            base.WndProc(ref m);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximaziBtn_Click(object sender, EventArgs e)
        {
            _ = this.WindowState == FormWindowState.Normal ? this.WindowState = FormWindowState.Maximized :
                                                             this.WindowState = FormWindowState.Normal;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
