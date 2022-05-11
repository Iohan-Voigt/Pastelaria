using Pastelaria.Domain.Shared;
using Pastelaria.RescourcesLib;
using System.Drawing;

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

        public Product() {   }

        public override string Validate()
        {
            string result = "";
            if(Name.Length == 0)
                result += (GeneralConfig.Data["Must have a Name"] + "\n");
            if(Value == 0)
                result += (GeneralConfig.Data["Must have a Value"] + "\n");
            if(Image == null)
                result += (GeneralConfig.Data["Must hava a Image"] + "\n");

            if (result == "")
                return "VALID";
            else
                return result;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
