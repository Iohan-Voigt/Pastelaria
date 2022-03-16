using Pastelaria.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pastelaria.WindowsApp.Costumer
{
    public class CostumerOperations : IRegisterable
    {
        private readonly CostumerUserControl table;

        private CostumerForm screen;

        public CostumerOperations()
        {
            table = new();
        }

        public UserControl ObtainTable()
        {
            List<Domain.Costumer> costumers = new List<Domain.Costumer>();

            table.UpdateRegisters(costumers);

            return table;
        }

        public void RegisterInsertNew()
        {
            screen = new ("Costumer Register");

            if(screen.ShowDialog() == DialogResult.OK)
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
