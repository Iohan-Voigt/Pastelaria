using Pastelaria.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.Domain
{
    internal class OrderPad : EntityBase
    {
        public List<Product> Products { get; set; }
        public Employee Employee { get; set; }
        public Costumer Costumer { get; set; }
        public DateTime OpenTime { get; set; }
        public OrderPadStatus OrderPadStatus { get; set; }
        public OrderPadPaymentStatus orderPadPaymentStatus { get; set; }
        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public override string Validate()
        {
            throw new NotImplementedException();
        }
    }
}
