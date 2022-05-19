using Pastelaria.AppService;
using Pastelaria.RescourcesLib;
using Pastelaria.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.Product
{
    public class ProductOperations : IRegisterable
    {
        private readonly ProductUserControl table;
        private readonly ProductAppService productAppService;

        private ProductForm screen;

        public ProductOperations(ProductAppService productAppService)
        {
            this.productAppService = productAppService;
            table = new();
        }
        public UserControl ObtainTable()
        {
            List<Domain.Product> product = productAppService.GetAll();

            table.UpdateRegisters(product);

            return table;
        }

        public void RegisterInsertNew()
        {
            screen = new(GeneralConfig.Data["Product Register"]);

            if (screen.ShowDialog() == DialogResult.OK)
            {
                productAppService.Insert(screen.product);
                LoadGrid();
            }
        }

        public void RegisterRemove()
        {
            Guid productId = table.GetSelectedId();

            if (productId == default)
            {
                MainFrameForm.instance.UpdateFooter("Any employee selected!");
                return;
            }

            Domain.Product product = productAppService.GetById(productId);
            if ((MessageBox.Show(GeneralConfig.Data["Are you sure that you want to remove"] + product.Name
                , GeneralConfig.Data["Product"] + " | " + GeneralConfig.Data["Registration"]
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Exclamation) == DialogResult.Yes))
            {
                productAppService.Delete(product);
            }

            LoadGrid();
        }

        public void RegistersFilter()
        {
            
        }

        public void RegistersGroup()
        {
            
        }

        public void RegisterUpdate()
        {
            Guid productId = table.GetSelectedId();

            if (productId == default)
            {
                MainFrameForm.instance.UpdateFooter("Any product selected!");
                return;
            }
            screen = null;
            screen = new("Product Update");
            screen.Product = productAppService.GetById(productId);

            if (screen.ShowDialog() == DialogResult.OK)
            {
                productAppService.Update(screen.Product);
            }

            LoadGrid();
        }
        private void LoadGrid()
        {
            List<Domain.Product> products = productAppService.GetAll();
            table.UpdateRegisters(products);
        }
    }
}
