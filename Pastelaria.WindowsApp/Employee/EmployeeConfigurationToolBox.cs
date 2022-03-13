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
            get { return "Add new employee"; }
        }

        public string ToolType
        {
            get { return "Employee register"; }
        }

        public string ToolTipEdit
        {
            get { return "Update a employee"; }
        }

        public string ToolTipRemove
        {
            get { return "Remove a employee"; }
        }
    }
}
