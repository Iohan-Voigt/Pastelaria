using Pastelaria.RescourcesLib;
using Pastelaria.WindowsApp.Shared;

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
        public string ToolTipSpun
        {
            get { return ""; }
        }
    }
}
