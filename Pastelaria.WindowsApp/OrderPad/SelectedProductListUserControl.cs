using Pastelaria.RescourcesLib;
using System;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.OrderPad
{
    public partial class SelectedProductListUserControl : UserControl
    {
        public Domain.ProcessingProduct product;
        public SelectedProductListUserControl(Domain.ProcessingProduct product)
        {
            this.product = product;
            product.Quantity = 1;
            InitializeComponent();
            Shared.SystemColors.UpdateControls(Controls);
            if (product.Name != null && product.Name.Length > 13)
                lblProducutName.Text = product.Name.Substring(0, 12) + "...";
            else
                lblProducutName.Text = product.Name;
            lblProductAmount.Text = product.Quantity.ToString();
        }

        public void ibtnAdd_Click(object sender, EventArgs e)
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
                product.Quantity++;
                lblProductAmount.Text = product.Quantity.ToString();
            }
            else
            {
                if(product.Quantity == 1)
                {
                    if(MessageBox.Show(GeneralConfig.Data[@"RemoveProduct?"],""
                                , MessageBoxButtons.YesNo
                                , MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        product.Quantity = 0;
                    }
                }
                else
                    product.Quantity--;            
                lblProductAmount.Text = product.Quantity.ToString();
            }
        }
    }
}
