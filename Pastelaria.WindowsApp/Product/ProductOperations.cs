using Pastelaria.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.Product
{
    public class ProductOperations : IRegisterable
    {
        private readonly ProductUserControl table;
        private ProductForm screen;

        public ProductOperations()
        {
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
            screen = new("Product Register");

            if (screen.ShowDialog() == DialogResult.OK)
            {
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
