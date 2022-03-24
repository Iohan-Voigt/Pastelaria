using Pastelaria.Domain.Shared;
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
        public Domain.Employee employee { get; set; }
        public EmployeeForm(string title)
        {           
            employee = new();
            InitializeComponent();
            this.labelMessages.BackColor = lightRed;
            this.Text = title;
        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure that you want to cancel?","Employee registration",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void iconButtonSave_Click(object sender, EventArgs e)
        {

            employee.Name = textBoxName.Text;
            employee.IndentityDocument = maskedTextBoxIdentifyDocument.Text;
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
