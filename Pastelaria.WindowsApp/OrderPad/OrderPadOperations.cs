using Pastelaria.AppService;
using Pastelaria.RescourcesLib;
using Pastelaria.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.OrderPad
{
    public class OrderPadOperations : IRegisterable
    {
        private readonly OrderPadUserControl table;
        private readonly OrderPadAppService orderPadAppService;

        private OrderPadForm screen;

        public OrderPadOperations(OrderPadAppService orderPadAppService)
        {
            this.orderPadAppService = orderPadAppService;
            table = new ();
        }
        public UserControl ObtainTable()
        {
            List<Domain.OrderPad> employee = new List<Domain.OrderPad>();

            table.UpdateRegisters(employee);

            return table;
        }

        public void RegisterInsertNew()
        {
            screen = new(GeneralConfig.Data["Employee Register"],false);

            if (screen.ShowDialog() == DialogResult.OK)
            {
                orderPadAppService.Insert(screen.OrderPad);
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
            throw new NotImplementedException();
        }

        private void LoadGrid()
        {
            List<Domain.OrderPad> orderPads = orderPadAppService.GetAll();
            table.UpdateRegisters(orderPads);
        }
    }
}
