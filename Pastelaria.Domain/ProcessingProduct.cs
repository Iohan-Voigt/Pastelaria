using Pastelaria.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.Domain
{
    public class ProcessingProduct : EntityBase
    {
        public OrderPad OrderPad { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        public ProcessingProduct(decimal value, string description, string name)
        {
            this.Value = value;
            this.Description = description;
            this.Name = name;
        }

        public ProcessingProduct() { }

        public override string Validate()
        {
            return "VALID";
        }

        public override string ToString()
        {
            return "";
        }

        public Product ParseToProduct()
        {
            Product product = new();
            product.Id = Id;
            product.Name = Name;
            product.Value = Value;
            product.Description = Description;

            return product;
        }
    }
}
