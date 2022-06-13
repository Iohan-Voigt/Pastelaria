using Pastelaria.AppService;
using Pastelaria.RescourcesLib;
using Pastelaria.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.Costumer
{
    public class CostumerOperations : IRegisterable
    {
        private readonly CostumerUserControl table;
        private readonly CustomerAppService customerAppService;

        private CostumerForm screen;

        public CostumerOperations(CustomerAppService customerAppService)
        {
            this.customerAppService = customerAppService;
            table = new();
        }

        public UserControl ObtainTable()
        {
            List<Domain.Customer> costumers = customerAppService.GetAll();

            table.UpdateRegisters(costumers);

            return table;
        }

        public void RegisterInsertNew()
        {
            screen = new ("Costumer Register");

            if(screen.ShowDialog() == DialogResult.OK)
            {
                customerAppService.Insert(screen.Customer);
                LoadGrid();
            }
        }

        private void LoadGrid()
        {
            List<Domain.Customer> customer = customerAppService.GetAll();
            table.UpdateRegisters(customer);
        }

        public void RegisterRemove()
        {
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
            Guid customerId = table.GetSelectedId();

            if(customerId==default)
            {
                MainFrameForm.instance.UpdateFooter("Any Customer selected!");
                return;
            }
            screen = null;
            screen = new("Customer Update");

            screen.Customer = customerAppService.GetById(customerId);

            if(screen.ShowDialog() == DialogResult.OK)
            {
                customerAppService.Update(screen.Customer);
            }
            LoadGrid();
        }
    }
}
