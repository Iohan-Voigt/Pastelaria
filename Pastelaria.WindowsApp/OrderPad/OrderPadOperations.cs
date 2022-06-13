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
        private readonly ProductAppService productAppService;
        private readonly CustomerAppService customerAppService;

        private OrderPadForm screen;

        public OrderPadOperations(OrderPadAppService orderPadAppService, ProductAppService productAppService, CustomerAppService customerAppService)
        {
            this.orderPadAppService = orderPadAppService;
            this.productAppService = productAppService;
            this.customerAppService = customerAppService;
            table = new ();
        }
        public UserControl ObtainTable()
        {
            LoadGrid();

            return table;
        }

        public void RegisterInsertNew()
        {

            screen = new(GeneralConfig.Data["Employee Register"],false,productAppService.GetAll(),customerAppService.GetAll());

            if (screen.ShowDialog() == DialogResult.OK)
            {
                screen.OrderPad.OpenTime = DateTime.Now;
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
