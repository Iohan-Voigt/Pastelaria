using Pastelaria.Domain.Shared;
using Pastelaria.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.Employee
{
    public partial class EmployeeForm : Form
    {
        private Color lightRed = Color.FromArgb(255, 105, 97);

        private Domain.Employee employee;
        public Domain.Employee Employee
        {
            get
            {
                return employee;
            }
            set
            {
                employee = value;
        
                textBoxID.Text = employee.Id.ToString();
                textBoxName.Text = employee.Name;
                maskedTextBoxIdentifyDocument.Text = employee.IdentityDocument;
                maskedTextBoxPhoneNumber.Text = employee.PhoneNumber;
                textBoxRegistration.Text = employee.Registration;
                textBoxAcessUser.Text = employee.AcessUser;
                textBoxPassword.Text = employee.Password;
        
                if(employee.EmployeePermissionsEnum == EmployeePermissionsEnum.Cashier)
                {
                    radioButtonAdmin.Checked = false;
                    radioButtonCashier.Checked = true;
                }
                else
                {
                    radioButtonCashier.Checked = false;
                    radioButtonAdmin.Checked = true;
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
        }

        private void ConfigureTextBox()
        {
            textBoxName.Enter += new(CustomEvents.EnterFieldEvent!);
            textBoxName.Leave += new(CustomEvents.LeaveFieldEvent!);

            textBoxAcessUser.Enter += new(CustomEvents.EnterFieldEvent!);
            textBoxAcessUser.Leave += new(CustomEvents.LeaveFieldEvent!);

            textBoxPassword.Enter += new(CustomEvents.EnterFieldEvent!);
            textBoxPassword.Leave += new(CustomEvents.LeaveFieldEvent!);

            textBoxRegistration.Enter += new(CustomEvents.EnterFieldEvent!);
            textBoxRegistration.Leave += new(CustomEvents.LeaveFieldEvent!);

            maskedTextBoxPhoneNumber.Enter += new(CustomEvents.EnterFieldEvent!);
            maskedTextBoxPhoneNumber.Leave += new(CustomEvents.LeaveFieldEvent!);

            maskedTextBoxIdentifyDocument.Enter += new(CustomEvents.EnterFieldEvent!);
            maskedTextBoxIdentifyDocument.Leave += new(CustomEvents.LeaveFieldEvent!);
        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure that you want to cancel?","Employee registration"
                                ,MessageBoxButtons.YesNo
                                ,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void iconButtonSave_Click(object sender, EventArgs e)
        {

            employee.Name = textBoxName.Text;
            employee.IdentityDocument = maskedTextBoxIdentifyDocument.Text;
            employee.PhoneNumber = maskedTextBoxPhoneNumber.Text;
            employee.Registration = textBoxRegistration.Text;
            employee.AcessUser = textBoxAcessUser.Text;
            employee.Password = textBoxPassword.Text;
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
            if (radioButtonAdmin.Checked)
                return EmployeePermissionsEnum.Admin;
            else
                return EmployeePermissionsEnum.Cashier;
        }
    }
}
