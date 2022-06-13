using Pastelaria.RescourcesLib;
using Pastelaria.WindowsApp.Shared;

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

        public string ToolTipSpun
        {
            get { return GeneralConfig.Data["Order Pad"] + " | " + "Spun"; }
        }
    }
}
