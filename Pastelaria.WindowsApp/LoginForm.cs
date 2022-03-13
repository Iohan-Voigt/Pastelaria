using Pastelaria.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pastelaria.Domain;
using System.Threading;

namespace Pastelaria.WindowsApp
{
    public partial class LoginForm : Form
    {
        private Thread thread;

        private readonly PastelariaDBContext db;
        private Domain.Employee loggedEmployee;

        public LoginForm()
        {
            InitializeComponent();
            
            db = new ();
        }

        private void LogginBtn_Click(object sender, EventArgs e)
        {
            if (userTextBox.Text.Equals("admin")
                && passwordTextBox.Text.Equals("admin"))
            {
                loggedEmployee = new Domain.Employee("admin", "administrator");
                Loggin();
            }
            else
            {
                userTextBox.Clear();
                passwordTextBox.Clear();
                InfoLabel.Text = "Invalid User";
                return;
            }
        }

        private void Loggin()
        {
            MessageBox.Show("Welcome " + loggedEmployee.Name);
            
            thread = new Thread(CallMainForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

            LoginForm loginForm = new ();
            this.Dispose();
            this.Close();
        }

        private void CallMainForm()
        {
            MainFrameForm.LoggedEmployee = loggedEmployee;
            Application.Run(new MainFrameForm());
        }
    }
}
