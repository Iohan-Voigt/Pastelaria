using Pastelaria.RescourcesLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        private int linePixelIndex = 5;
        private bool isColumFirstItem = true;

        public Domain.OrderPad OrderPad
        {
            get { return orderpad; }
            set 
            { 
                //to do
                orderpad = value;


                foreach (Domain.ProcessingProduct processingProduct in orderpad.ProcessingProducts)
                {
                    SelectedProducts.Add(new(processingProduct));
                    orderpad.Total += processingProduct.Value;
                    lblTotalValue.Text = orderpad.Total.ToString();
                }
            }
        }

        public OrderPadForm(string title,bool isEdit,List<Domain.Product> products,List<Domain.Customer> customers)
        {
            Text = title;
            orderpad = null;
            orderpad = new();
            InitializeComponent();
            SelectedProducts = new();

            Shared.SystemColors.ConfigureColors(Controls);
            lblMessages.BackColor = lightRed;
            BackColor = Shared.SystemColors.SecondColor;
            productsListPanel.BackColor = Shared.SystemColors.BaseColor;
            selectedProductsPanel.BackColor = Shared.SystemColors.BaseColor;

            cbxCustomers.Items.Clear();
            foreach (Domain.Customer customer in customers)
            {
                cbxCustomers.Items.Add(customer);
            }

            if (!isEdit)
            {
                foreach (var product in products)
                {
                    ProductListButtonUserControl buttonUserControl = new(product);
                    buttonUserControl.Location = new Point(0,0);
                    buttonUserControl.pictureBox.Click += UpdateProductListUserControl!;
                    LoadProductsIntoPanel(buttonUserControl);
                }
            }
        }

        private void LoadProductsIntoPanel(UserControl button)
        {
            if (isColumFirstItem)
            {
                button.Location = new Point(5 ,linePixelIndex);
                button.MouseClick += UpdateProductListUserControl!;
                isColumFirstItem = false;
            }
            else
            {
                button.Location = new Point(250,linePixelIndex);
                button.MouseClick += UpdateProductListUserControl!;
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

        private void UpdateProductListUserControl(object sender, EventArgs e)
        {
            SelectedProductListUserControl selectedProductListUserControl = new(new());
            bool productExists = false;
            Domain.Product localSelectedProduct;

            if(sender is ProductListButtonUserControl)
            {
                ProductListButtonUserControl button = (ProductListButtonUserControl)sender;
                localSelectedProduct = button.product;
            }
            else
            {
                PictureBoxWithProduct button = (PictureBoxWithProduct)sender;
                localSelectedProduct = button.Product;
            }                        

            foreach (var selectedProduct in SelectedProducts)
            {                
                if(selectedProduct.product.Id == localSelectedProduct.Id)
                {
                    productExists = true;
                    selectedProductListUserControl = selectedProduct;
                }                                 
            }

            if (!productExists)
            {
                selectedProductListUserControl = new(localSelectedProduct.ParseToProcessingProduct());
                selectedProductListUserControl.ibtnAdd.Click += UpdateOrderPadTotalValueBySelectedProduct!;
                selectedProductListUserControl.ibtnRemove.Click += UpdateOrderPadTotalValueBySelectedProduct!;
                SelectedProducts.Add(selectedProductListUserControl);
            }
            else
            {
                selectedProductListUserControl.UpdateProductAmount(true);
            }

            UpdateOrderPadTotalValue();
            UpdateSelectedProductsList();
        }

        public void UpdateOrderPadTotalValueBySelectedProduct(object sender, EventArgs e)
        {           
            UpdateOrderPadTotalValue();
            RemoveSelectedProductFromList();
            UpdateSelectedProductsList();
        }

        private void UpdateOrderPadTotalValue()
        {
            orderpad.Total = 0;
            foreach (SelectedProductListUserControl selectedProduct in SelectedProducts)
            {
                orderpad.Total += selectedProduct.product.Value * selectedProduct.product.Quantity;
            }
            lblTotalValue.Text = "R$ " + orderpad.Total.ToString();
        }

        public void RemoveSelectedProductFromList()
        {
            foreach (SelectedProductListUserControl product in SelectedProducts)
            {
                if(product.product.Quantity <= 0)
                {
                    SelectedProducts.Remove(product);
                    product.Hide();
                    break;
                }                    
            }
        }

        private void UpdateSelectedProductsList()
        {
            int size = 0;
            foreach (SelectedProductListUserControl product in SelectedProducts)
            {
                product.Location = new Point(0,size);
                selectedProductsPanel.Controls.Add(product);
                size = size + 80;
            }
        }

        private void ibtnSave_Click(object sender, EventArgs e)
        {
            orderpad.ProcessingProducts = new();
            foreach (SelectedProductListUserControl product in SelectedProducts)
            {
                orderpad.ProcessingProducts.Add(product.product);
            }

            orderpad.Customer = (Domain.Customer)cbxCustomers.SelectedItem;
            orderpad.Employee = MainFrameForm.LoggedEmployee;

            string validateResult = orderpad.Validate();

            if(validateResult != "VALID")
            {
                lblMessages.Text = new StringReader(validateResult).ReadLine();
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void ibtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(GeneralConfig.Data[@"AreYouSureThatYouWantToCancel?"],GeneralConfig.Data["Order Pad"]
                                , MessageBoxButtons.YesNo
                                , MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
