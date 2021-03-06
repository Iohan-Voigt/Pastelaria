using Pastelaria.AppService;
using Pastelaria.RescourcesLib;
using Pastelaria.WindowsApp.Shared;
using System;
using System.Collections.Generic;
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
            screen = new (GeneralConfig.Data["Employee Register"]);

            if (screen.ShowDialog() == DialogResult.OK)
            {
                employeeAppService.Insert(screen.Employee);
                LoadGrid();
            }
            
        }

        public void RegisterRemove()
        {
            Guid employeeId = table.GetSelectedId();

            if (employeeId == default)
            {
                MainFrameForm.instance.UpdateFooter(GeneralConfig.Data["Any employee selected!"]);
                return;
            }

            Domain.Employee employee = employeeAppService.GetById(employeeId);
            if ((MessageBox.Show(GeneralConfig.Data["Are you sure that you want to remove"] + employee.Name
                , GeneralConfig.Data["Employee"] + " | " + GeneralConfig.Data["Registration"]
                ,MessageBoxButtons.YesNo
                , MessageBoxIcon.Exclamation) == DialogResult.Yes))
            {
                employeeAppService.Delete(employee);
            }

            LoadGrid();
        }

        public void RegistersFilter()
        {
            
        }

        public void RegistersGroup()
        {
            
        }

        public void RegisterUpdate()
        {
            Guid employeeId = table.GetSelectedId();

            if(employeeId==default)
            {
                MainFrameForm.instance.UpdateFooter(GeneralConfig.Data[@"Any employee selected!"]);
                return;
            }
            screen = null;
            screen = new(GeneralConfig.Data["Employee"] + " " + GeneralConfig.Data["Update"]);

            screen.Employee = employeeAppService.GetById(employeeId);

            if(screen.ShowDialog() == DialogResult.OK)
            {
                employeeAppService.Update(screen.Employee);
            }

            LoadGrid();
        }
    }
}
