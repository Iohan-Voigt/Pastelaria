using Pastelaria.ORM;
using System;
using System.Windows.Forms;
using System.Threading;
using Pastelaria.AppService;
using Pastelaria.ORM.Features;
using Pastelaria.RescourcesLib;
using Pastelaria.WindowsApp.Shared;
using Serilog;

namespace Pastelaria.WindowsApp
{
    public partial class LoginForm : Form
    {
        private Thread thread;

        private Domain.Employee loggedEmployee;

        private readonly PastelariaDBContext db;
        private readonly EmployeeAppService employeeAppService;
        private readonly ProductAppService productAppService;
        public LoginForm()
        {
            db = new();
            employeeAppService = new(new EmployeeORM(db));
            productAppService = new(new ProductORM(db));
            InitializeComponent();
            ConfigureInfo();
            CofigureTextBox();
        }

        private void LogginBtn_Click(object sender, EventArgs e)
        {
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Attempt to login");
            if (userTextBox.Text.Equals("admin")
                && passwordTextBox.Text.Equals("admin"))
            {
                loggedEmployee = new Domain.Employee("admin", "administrator");
                Loggin();
            }
            else
            {
                Domain.Employee employee = new()
                {
                    AcessUser = userTextBox.Text,
                    Password = passwordTextBox.Text
                };

                employee = employeeAppService.GetByAcessUserAndPassword(employee);

                if(employee != null)
                {
                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Attempt to login succed");
                    loggedEmployee = employee;
                    Loggin();
                    return;
                }
                Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Attempt to login failed");
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
            Application.Run(new MainFrameForm());
        }

        private void ConfigureInfo()
        {
            lblUser.Text = GeneralConfig.Data["User"];
            lblPassword.Text = GeneralConfig.Data["Password"];
            btnLogin.Text = GeneralConfig.Data["Login"];
        }

        private void CofigureTextBox()
        {
            userTextBox.Enter += new(CustomEvents.EnterFieldEvent!);
            userTextBox.Leave += new(CustomEvents.LeaveFieldEvent!);

            passwordTextBox.Enter += new(CustomEvents.EnterFieldEvent!);
            passwordTextBox.Leave += new(CustomEvents.LeaveFieldEvent!);
        }
    }
}
