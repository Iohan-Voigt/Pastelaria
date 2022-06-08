using Pastelaria.Domain.Shared;
using Pastelaria.RescourcesLib;
using Pastelaria.WindowsApp.Shared;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SystemColors = Pastelaria.WindowsApp.Shared.SystemColors;

namespace Pastelaria.WindowsApp.Employee
{
    public partial class EmployeeForm : Form
    {
        private Color lightRed = Color.FromArgb(255, 105, 97);

        private Domain.Employee employee;
        public Domain.Employee Employee
        {
            get { return employee; }
            set
            {
                employee = value;
        
                txtID.Text = employee.Id.ToString();
                txtName.Text = employee.Name;
                mtxtBoxIdentifyDocument.Text = employee.IdentityDocument;
                mtxtPhoneNumber.Text = employee.PhoneNumber;
                txtRegistration.Text = employee.Registration;
                txtAcessUser.Text = employee.AcessUser;
                txtPassword.Text = employee.Password;
        
                if(employee.EmployeePermissionsEnum == EmployeePermissionsEnum.Cashier)
                {
                    rbtnAdmin.Checked = false;
                    rbtnCashier.Checked = true;
                }
                else
                {
                    rbtnCashier.Checked = false;
                    rbtnAdmin.Checked = true;
                }
            }
        }
        public EmployeeForm(string title)
        {
            employee = null;
            employee = new();
            InitializeComponent();
            this.labelMessages.BackColor = lightRed;
            this.Text = title;
            ConfigureTextBox();
            SystemColors.ConfigureColors(Controls);
        }

        private void ConfigureTextBox()
        {
            txtName.Enter += new(CustomEvents.EnterFieldEvent!);
            txtName.Leave += new(CustomEvents.LeaveFieldEvent!);

            txtAcessUser.Enter += new(CustomEvents.EnterFieldEvent!);
            txtAcessUser.Leave += new(CustomEvents.LeaveFieldEvent!);

            txtPassword.Enter += new(CustomEvents.EnterFieldEvent!);
            txtPassword.Leave += new(CustomEvents.LeaveFieldEvent!);

            txtRegistration.Enter += new(CustomEvents.EnterFieldEvent!);
            txtRegistration.Leave += new(CustomEvents.LeaveFieldEvent!);

            mtxtPhoneNumber.Enter += new(CustomEvents.EnterFieldEvent!);
            mtxtPhoneNumber.Leave += new(CustomEvents.LeaveFieldEvent!);

            mtxtBoxIdentifyDocument.Enter += new(CustomEvents.EnterFieldEvent!);
            mtxtBoxIdentifyDocument.Leave += new(CustomEvents.LeaveFieldEvent!);
        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(GeneralConfig.Data[@"AreYouSureThatYouWantToCancel?"], GeneralConfig.Data["Employee Register"]
                                ,MessageBoxButtons.YesNo
                                ,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void iconButtonSave_Click(object sender, EventArgs e)
        {

            employee.Name = txtName.Text;
            employee.IdentityDocument = mtxtBoxIdentifyDocument.Text;
            employee.PhoneNumber = mtxtPhoneNumber.Text;
            employee.Registration = txtRegistration.Text;
            employee.AcessUser = txtAcessUser.Text;
            employee.Password = txtPassword.Text;
            employee.EmployeePermissionsEnum = RadioButtonConverter();
            employee.EmployeeActiveEnum = EmployeeActiveEnum.Active;

            string validateResult = employee.Validate();

            if(validateResult != "VALID")
            {          
                labelMessages.Text = new StringReader(validateResult).ReadLine();
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private EmployeePermissionsEnum RadioButtonConverter()
        {
            if (rbtnAdmin.Checked)
                return EmployeePermissionsEnum.Admin;
            else
                return EmployeePermissionsEnum.Cashier;
        }
    }
}
