using Pastelaria.WindowsApp.Shared;

namespace Pastelaria.WindowsApp.Costumer
{
    public class CostumerConfigurationToolBox : IConfigurationToolBox
    {
        public string ToolTipAdd
        {
            get { return "Add new costumer"; }
        }

        public string ToolType
        {
            get { return "Costumers register"; }
        }

        public string ToolTipUpdate
        {
            get { return "Update a costumer"; }
        }

        public string ToolTipRemove
        {
            get { return "Remove a costumer"; }
        }
    }
}
