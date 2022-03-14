using Pastelaria.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pastelaria.Domain;

namespace Pastelaria.WindowsApp.OrderPad
{
    public class OrderPadOperations : IRegisterable
    {
        private readonly OrderPadUserControl table;

        public OrderPadOperations()
        {
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
            throw new NotImplementedException();
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
