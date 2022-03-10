using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.WindowsApp.Shared
{
    public interface IConfigurationToolBox
    {
        string ToolTipAdd { get; }
        string ToolType { get; }
        string ToolTipUpdate { get; }
        string ToolTipRemove { get; }
    }
}
