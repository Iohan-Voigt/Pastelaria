using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pastelaria.Domain.Shared;

namespace Pastelaria.Domain
{
    public class Employee : Person
    {
        protected string password { get; set; }

        public override string ToString()
        {
            return "";
        }

        public override string Validate()
        {
            return "";
        }
    }
}
