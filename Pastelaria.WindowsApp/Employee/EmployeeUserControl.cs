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
           };

            return coluns;
        }
        internal void UpdateRegisters(List<Domain.Employee> employeers)
        {
            employeeGrid.Rows.Clear();

            foreach (Domain.Employee employee in employeers)
            {
                employeeGrid.Rows.Add(employee);
            }
        }

        internal Guid GetSelectedId()
        {
            return employeeGrid.SelectId<Guid>();
        }
    }
}
