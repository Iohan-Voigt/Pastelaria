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

namespace Pastelaria.WindowsApp.OrderPad
{
    public partial class OrderPadUserControl : UserControl
    {
        public OrderPadUserControl()
        {
            InitializeComponent();
            orderPadGrid.ConfigColoredGrid();
            orderPadGrid.ConfigJustReadGrid();
            orderPadGrid.Columns.AddRange(ObtainColuns());
        }

        private static DataGridViewColumn[] ObtainColuns()
        {
            var coluns = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Costumer", HeaderText = "Costumer"},
                new DataGridViewTextBoxColumn { DataPropertyName = "TotalValue", HeaderText = "Total Value"},
                new DataGridViewTextBoxColumn { DataPropertyName = "OrderPadStatus", HeaderText = "Status"},
                new DataGridViewTextBoxColumn { DataPropertyName = "OpenTime", HeaderText = "Open date"}
                
           };

            return coluns;
        }

        public void UpdateRegisters(List<Domain.OrderPad> orders)
        {
            orderPadGrid.Rows.Clear();

            foreach (Domain.OrderPad orderPad in orders)
            {
                orderPadGrid.Rows.Add(orderPad);
            }
        }

        public Guid GetSelectedId()
        {
            return orderPadGrid.SelectId<Guid>();
        }
    }
}
