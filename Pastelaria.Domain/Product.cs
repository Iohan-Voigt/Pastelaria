using Pastelaria.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.Domain
{
    public class Product : EntityBase
    {
        public decimal Value { get; set; }
        public int? Quantity { get; set; }
        public bool HasQuantity { get; set; }

        public Product(decimal value, int? quantity, bool hasQuantity, string name)
        {
            this.Value = value;
            this.Quantity = quantity;
            this.HasQuantity = hasQuantity;
            this.Name = name;
        }
    }
}
