using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.OrderPad
{
    public partial class SelectedProductListUserControl : UserControl
    {
        public Domain.Product product;
        int productAmount = 1;
        public SelectedProductListUserControl(Domain.Product product)
        {
            this.product = product;
            InitializeComponent();
            Shared.SystemColors.UpdateControls(Controls);
            lblProcutName.Text = product.Name;
            lblProductAmount.Text = productAmount.ToString();
        }

        private void ibtnAdd_Click(object sender, EventArgs e)
        {
            UpdateProductAmount(true);
        }

        private void ibtnRemove_Click(object sender, EventArgs e)
        {
            UpdateProductAmount(false);
        }

        public void UpdateProductAmount(bool isAdd)
        {
            if (isAdd)
            {
                productAmount++;
                lblProductAmount.Text = productAmount.ToString();
            }
            else
            {
                productAmount--;
                lblProductAmount.Text = productAmount.ToString();
            }
        }
    }
}
