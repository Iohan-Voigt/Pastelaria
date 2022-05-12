using Pastelaria.RescourcesLib;
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
            get { return GeneralConfig.Data["Order Pad"] + " | " + GeneralConfig.Data["Add new"]; }
        }

        public string ToolType
        {
            get { return GeneralConfig.Data["Order Pad"] + " | " + GeneralConfig.Data["Register"]; }
        }

        public string ToolTipEdit
        {
            get { return GeneralConfig.Data["Order Pad"] + " | " + GeneralConfig.Data["Remove"]; }
        }

        public string ToolTipRemove
        {
            get { return GeneralConfig.Data["Order Pad"] + " | " + GeneralConfig.Data["Remove"]; }
        }
    }
}
