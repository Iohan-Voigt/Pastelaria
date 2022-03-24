using Pastelaria.AppService;
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
        private readonly EmployeeAppService employeeAppService;

        private EmployeeForm screen;

        public EmployeeOperations(EmployeeAppService employeeAppService)
        {
            this.employeeAppService = employeeAppService;
            table = new();
        }

        public UserControl ObtainTable()
        {
            List<Domain.Employee> employees = employeeAppService.GetAll();

            table.UpdateRegisters(employees);

            return table;
        }

        public void RegisterInsertNew()
        {
            screen = new ("Employee Register");

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
