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

            Shared.SystemColors.ConfigureColors(Controls);

            lblPrice.Text = "R$ " + product.Value.ToString();
            if (product.Name.Length > 13)
                lblProductName.Text = product.Name.Substring(0, 12) + "...";
            else
                lblProductName.Text = product.Name;
            pictureBox.Image = product.Image;
            pictureBox.Product = product;
        }
        
    }
}
