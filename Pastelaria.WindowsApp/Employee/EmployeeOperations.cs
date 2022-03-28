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

        private void LoadGrid()
        {
            List<Domain.Employee> employees = employeeAppService.GetAll();
            table.UpdateRegisters(employees);
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
                employeeAppService.Insert(screen.Employee);
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
            Guid employeeId = table.GetSelectedId();

            if(employeeId==default)
            {
                MainFrameForm.instance.UpdateFooter("Any employee selected!");
                return;
            }
            screen = null;
            screen = new("Employee Update");

            screen.Employee = employeeAppService.GetById(employeeId);

            if(screen.ShowDialog() == DialogResult.OK)
            {
                employeeAppService.Update(screen.Employee);
            }
        }
    }
}
