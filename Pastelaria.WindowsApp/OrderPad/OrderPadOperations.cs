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
            Guid orderPadId = table.GetSelectedId();

            if (orderPadId == default)
            {
                MainFrameForm.instance.UpdateFooter(GeneralConfig.Data["Any employee selected!"]);
                return;
            }

            Domain.OrderPad orderpad = orderPadAppService.GetById(orderPadId);
            if ((MessageBox.Show(GeneralConfig.Data["Are you sure that you want to remove"] + " "
                , "OrderPad" + " | " + GeneralConfig.Data["Registration"]
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Exclamation) == DialogResult.Yes))
            {
                orderPadAppService.Delete(orderpad);
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
            Guid orderPadId = table.GetSelectedId();

            if(orderPadId == default)
            {
                MainFrameForm.instance.UpdateFooter("Any OrderPad selected!");
                return;
            }

            screen = null;
            screen = new("OrderPad", true, productAppService.GetAll(), customerAppService.GetAll());

            screen.OrderPad = orderPadAppService.GetById(orderPadId);

            if(screen.ShowDialog() == DialogResult.OK)
            {
                orderPadAppService.Update(screen.OrderPad);
            }

            LoadGrid();
        }

        private void LoadGrid()
        {
            List<Domain.OrderPad> orderPads = orderPadAppService.GetAll();
            table.UpdateRegisters(orderPads);
        }
    }
}
