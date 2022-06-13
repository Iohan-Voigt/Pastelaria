using Pastelaria.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.OrderPad
{
    public partial class OrderPadUserControl : UserControl
    {
        public OrderPadUserControl()
        {
            InitializeComponent();
            debitsGrid.ConfigColoredGrid();
            debitsGrid.ConfigJustReadGrid();
            debitsGrid.Columns.AddRange(ObtainColuns());
        }

        private static DataGridViewColumn[] ObtainColuns()
        {
            var coluns = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Employee", HeaderText = "Employee"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Customer", HeaderText = "Customer"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Total", HeaderText = "Total Value"},
                new DataGridViewTextBoxColumn { DataPropertyName = "OrderPadStatus", HeaderText = "Status"},
                new DataGridViewTextBoxColumn { DataPropertyName = "OpenTime", HeaderText = "Open date"}
           };

            return coluns;
        }

        public void UpdateRegisters(List<Domain.OrderPad> orders)
        {
            debitsGrid.Rows.Clear();

            foreach (Domain.OrderPad orderPad in orders)
            {
                debitsGrid.Rows.Add(orderPad.Id, orderPad.Employee.Name, orderPad.Customer.Name, orderPad.Total, orderPad.OrderPadStatus, orderPad.OpenTime);
            }
        }

        public Guid GetSelectedId()
        {
            return debitsGrid.SelectId<Guid>();
        }
    }
}
