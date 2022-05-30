using Pastelaria.WindowsApp.Shared;
using System;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.OrderPad
{
    public partial class ProductListButtonUserControl : UserControl
    {
        public Domain.Product product;
        public ProductListButtonUserControl(Domain.Product product)
        {
            this.product = product;

            InitializeComponent();

            SystemColors.ConfigureColors(Controls);

            lblPrice.Text = product.Value.ToString();
            lblProductName.Text = product.Name;
            pictureBox.Image = product.Image;

        }
    }
}
