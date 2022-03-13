using Pastelaria.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.Employee
{
    public class EmployeeOperations : IRegisterable
    {
        private readonly EmployeeUserControl table;

        public EmployeeOperations()
        {
            table = new();
        }

        public UserControl ObtainTable()
        {
            List<Domain.Employee> employee = new List<Domain.Employee>();

            table.UpdateRegisters(employee);

            return table;
        }

        public void RegisterInsertNew()
        {
            EmployeeForm screen = new EmployeeForm("Employee Register");

            if (screen.ShowDialog() == DialogResult.OK)
            {

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
    }
}
