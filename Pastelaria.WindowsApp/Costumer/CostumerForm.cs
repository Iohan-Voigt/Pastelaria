using Pastelaria.WindowsApp.Shared;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.Costumer
{
    public partial class CostumerForm : Form
    {
        private Color lightRed = Color.FromArgb(255, 105, 97);
        private Domain.Customer customer;
        public Domain.Customer Customer
        {
            get { return customer; }
            set 
            { 
                customer = value;
                
                txtName.Text = customer.Name;
                mtxtBoxIdentifyDocument.Text = customer.IdentityDocument;
                mtxtPhoneNumber.Text = customer.PhoneNumber;
            }
        }

        public CostumerForm(string title)
        {
            customer = null;
            customer = new();
            InitializeComponent();
            this.labelMessages.BackColor = lightRed;
            this.Text = title;
            Shared.SystemColors.ConfigureColors(Controls);
        }

        private void ibtnSave_Click(object sender, EventArgs e)
        {
            customer.Name = txtName.Text;
            customer.PhoneNumber = mtxtPhoneNumber.Text;
            customer.IdentityDocument = mtxtBoxIdentifyDocument.Text;

            string validationResult = customer.Validate();

            if (validationResult != "VALID")
            {
                labelMessages.Text = new StringReader(validationResult).ReadLine();
                return;
            }
           DialogResult = DialogResult.OK;
        }

        private void ibtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you wan to cancel?", "Confirmation") == DialogResult.Yes) ;
            this.Close();
        }
    }
}
