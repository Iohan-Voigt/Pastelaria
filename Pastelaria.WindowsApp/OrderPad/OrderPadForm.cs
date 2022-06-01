using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.OrderPad
{
    public partial class OrderPadForm : Form
    {
        private Color lightRed = Color.FromArgb(255, 105, 97);
        private List<SelectedProductListUserControl> SelectedProducts;

        private Domain.OrderPad orderpad;

        private int column = 1;
        private int columnMaxIndex = 2;
        private int linePixelIndex = 0;
        private bool isColumFirstItem = true;

        public Domain.OrderPad OrderPad
        {
            get { return orderpad; }
            set 
            { 
                //to do
                orderpad = value;
            }
        }

        public OrderPadForm(string title,bool isEdit,List<Domain.Product> products)
        {
            this.Text = title;
            InitializeComponent();
            SelectedProducts = new();

            Shared.SystemColors.ConfigureColors(Controls);

            if (!isEdit)
            {
                foreach (var product in products)
                {
                    ProductListButtonUserControl buttonUserControl = new(product);
                    buttonUserControl.Location = new Point(0,0);
                    buttonUserControl.pictureBox.Click += UpdateProductList!;
                    LoadProductsIntoPanel(buttonUserControl);
                }
            }
        }

        private void LoadProductsIntoPanel(UserControl button)
        {
            if (isColumFirstItem)
            {
                button.Location = new Point(5 ,linePixelIndex);
                button.MouseClick += UpdateProductList!;
                isColumFirstItem = false;
            }
            else
            {
                button.Location = new Point(245,linePixelIndex);
                button.MouseClick += UpdateProductList!;
                isColumFirstItem = true;
                linePixelIndex += 135;
            } 
            productsListPanel.Controls.Add(button);
            
            if (column == columnMaxIndex)
            {
                column = 0;
            }
            column++;
        }

        private void UpdateProductList(object sender, EventArgs e)
        {
            bool productExists = false;
            ProductListButtonUserControl button = (ProductListButtonUserControl)sender;
            SelectedProductListUserControl selectedProductListUserControl = new(button.product);

            foreach (var selectedProduct in SelectedProducts)
            {                
                if(selectedProduct.product.Id == button.product.Id)
                    productExists = true;               
            }

            if (!productExists)
                SelectedProducts.Add(selectedProductListUserControl);
            else


            UpdateSelectedProductsList();
        }

        private void UpdateSelectedProductsList()
        {
            int size = 0;
            foreach (var product in SelectedProducts)
            {
                product.Location = new Point(0,size);
                selectedProductsPanel.Controls.Add(product);
                size = size + 80;
            }
            
        }
    }
}
