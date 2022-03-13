using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.Domain.Shared
{
    public enum OrderPadStatus
    {
        open = 0,
        toBePaid = 1,
        onCash = 2,
        canceled = 3
    }
}
