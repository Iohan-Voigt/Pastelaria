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
using Pastelaria.AppService;
using Pastelaria.ORM.Features;
using Pastelaria.RescourcesLib;

namespace Pastelaria.WindowsApp
{
    public partial class LoginForm : Form
    {
        private Thread thread;

        private Domain.Employee loggedEmployee;

        private readonly PastelariaDBContext db;

        private readonly EmployeeAppService employeeAppService;

        public LoginForm()
        {
            db = new();
            employeeAppService = new(new EmployeeORM(db));
            InitializeComponent();
            ConfigureInfo();
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
                foreach(Domain.Employee employee in employeeAppService.GetAll())
                {
                    if(userTextBox.Text == employee.AcessUser 
                        && passwordTextBox.Text == employee.Password)
                    {
                        loggedEmployee = employee;
                        Loggin();
                        return;
                    }
                }
                userTextBox.Clear();
                passwordTextBox.Clear();
                InfoLabel.Text = "Invalid User";
                return;
            }
        }

        private void Loggin()
        {
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
            Application.Run(new MainFrameForm(employeeAppService));
        }

        private void ConfigureInfo()
        {
            labelUser.Text = GeneralConfig.Data["User"];
            labelPassword.Text = GeneralConfig.Data["Password"];
            loginBtn.Text = GeneralConfig.Data["Login"];
        }
    }
}
