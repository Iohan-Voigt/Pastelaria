using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.Costumer
{
    public partial class CostumerForm : Form
    {
        public CostumerForm(string title)
        {
            InitializeComponent();
            this.Text = title;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure that you wan to cancell?", "Confirmation") == DialogResult.Yes);
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
