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

namespace Pastelaria.WindowsApp.Costumer
{
    public partial class CostumerUserControl : UserControl
    {
        public CostumerUserControl()
        {
            InitializeComponent();
            costumerGrid.ConfigColoredGrid();
            costumerGrid.ConfigJustReadGrid();
            costumerGrid.Columns.AddRange(ObtainColuns());
            
        }

        private static DataGridViewColumn[] ObtainColuns()
        {
            var coluns = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Name"}
           };

            return coluns;
        }

        internal void UpdateRegisters(List<Domain.Customer> costumers)
        {
            costumerGrid.Rows.Clear();

            foreach(Domain.Customer costumer in costumers)
            {
                costumerGrid.Rows.Add(costumer);
            }
        }

        internal Guid GetSelectedId()
        {
            return costumerGrid.SelectId<Guid>();
        }
    }
}
