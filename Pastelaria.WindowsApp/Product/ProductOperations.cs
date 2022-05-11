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
            List<Domain.Product> product = new List<Domain.Product>();

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
            throw new NotImplementedException();
        }

        public void RegistersFilter()
        {
            throw new NotImplementedException();
        }

        public void RegistersGroup()
        {
            throw new NotImplementedException();
        }

        public void RegisterUpdate()
        {
            throw new NotImplementedException();
        }
        private void LoadGrid()
        {
            
        }
    }
}
