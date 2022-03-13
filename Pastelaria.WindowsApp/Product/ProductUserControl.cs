using Pastelaria.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.Product
{
    public partial class ProductUserControl : UserControl
    {
        public ProductUserControl()
        {
            InitializeComponent();
            productGrid.ConfigColoredGrid();
            productGrid.ConfigJustReadGrid();
            productGrid.Columns.AddRange(ObtainColuns());
        }

        private DataGridViewColumn[] ObtainColuns()
        {
            var coluns = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Nome"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Value", HeaderText = "Value"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Description", HeaderText = "Description"}
           };

            return coluns;
        }

        public void UpdateRegisters(List<Domain.Product> products)
        {
            productGrid.Rows.Clear();

            foreach (Domain.Product product in products)
            {
                productGrid.Rows.Add(product);
            }
        }

        public Guid GetSelectedId()
        {
            return productGrid.SelectId<Guid>();
        }
    }
}
