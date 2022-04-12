using Pastelaria.RescourcesLib;
using Pastelaria.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.WindowsApp.Employee
{
    public class EmployeeConfigurationToolBox : IConfigurationToolBox
    {
        public string ToolTipAdd
        {
            get { return GeneralConfig.Data["Employee"] + " | " + GeneralConfig.Data["Add new"]; }
        }

        public string ToolType
        {
            get { return GeneralConfig.Data["Employee"] + " | " + GeneralConfig.Data["Register"]; }
        }

        public string ToolTipEdit
        {
            get { return GeneralConfig.Data["Employee"] + " | " + GeneralConfig.Data["Update"]; }
        }

        public string ToolTipRemove
        {
            get { return GeneralConfig.Data["Employee"] + " | " + GeneralConfig.Data["Remove"]; }
        }
    }
}
