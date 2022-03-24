using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.Employee
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm(string title)
        {
            InitializeComponent();
            this.Text = title;
        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure that you want to cancel?","Employee registration",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
