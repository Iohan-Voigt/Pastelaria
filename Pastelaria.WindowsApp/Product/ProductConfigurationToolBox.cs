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
            get { return "Add new product"; }
        }

        public string ToolType
        {
            get { return "Employee product"; }
        }

        public string ToolTipEdit
        {
            get { return "Update a product"; }
        }

        public string ToolTipRemove
        {
            get { return "Remove a product"; }
        }
    }
}
