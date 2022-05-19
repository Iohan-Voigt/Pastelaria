using Pastelaria.RescourcesLib;
using Pastelaria.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.WindowsApp.Product
{
    public class ProductConfigurationToolBox : IConfigurationToolBox
    {
        public string ToolTipAdd
        {
            get { return GeneralConfig.Data["Product"] + " | " + GeneralConfig.Data["Add new"]; }
        }

        public string ToolType
        {
            get { return GeneralConfig.Data["Product"] + " | " + GeneralConfig.Data["Register"]; }
        }

        public string ToolTipEdit
        {
            get { return GeneralConfig.Data["Product"] + " | " + GeneralConfig.Data["Update"]; }
        }

        public string ToolTipRemove
        {
            get { return GeneralConfig.Data["Product"] + " | " + GeneralConfig.Data["Remove"]; }
        }
    }
}
