using Pastelaria.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.WindowsApp.OrderPad
{
    public class OrderPadConfigurationToolBox : IConfigurationToolBox

    {
        public string ToolTipAdd
        {
            get { return "Add new order"; }
        }

        public string ToolType
        {
            get { return "Order register"; }
        }

        public string ToolTipEdit
        {
            get { return "Update a order"; }
        }

        public string ToolTipRemove
        {
            get { return "Remove a order"; }
        }
    }
}
