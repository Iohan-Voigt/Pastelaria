using Pastelaria.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.Domain
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public string Description { get; set; }
        public Bitmap Image { get; set; }

        public Product(decimal value, string description, string name,Bitmap image)
        {
            this.Value = value;
            this.Description = description;
            this.Name = name;
            this.Image = image;
        }

        public override string Validate()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "";
        }
    }
}
