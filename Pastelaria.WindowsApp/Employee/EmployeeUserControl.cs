using Pastelaria.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.Employee
{
    public partial class EmployeeUserControl : UserControl
    {
        public EmployeeUserControl()
        {
            InitializeComponent();
            employeeGrid.ConfigColoredGrid();
            employeeGrid.ConfigJustReadGrid();
            employeeGrid.Columns.AddRange(ObtainColuns());
        }

        private static DataGridViewColumn[] ObtainColuns()
        {
            var coluns = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Nome"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Registration", HeaderText = "Registration"},
                new DataGridViewTextBoxColumn { DataPropertyName = "AcessUser", HeaderText = "User"},
                new DataGridViewTextBoxColumn { DataPropertyName = "EmployeePermissionsEnum", HeaderText = "Permission"},
                new DataGridViewTextBoxColumn { DataPropertyName = "EmployeeActiveEnum", HeaderText = "Active"}

           };

            return coluns;
        }
        public void UpdateRegisters(List<Domain.Employee> employees)
        {
            employeeGrid.DataSource = null;
            employeeGrid.DataSource = (employees);
        }

        public Guid GetSelectedId()
        {
            return employeeGrid.SelectId<Guid>();
        }
    }
}
