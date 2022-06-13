using System.Collections.Generic;

namespace Pastelaria.Domain
{
    public class Customer : Person
    {
        public List<OrderPad> OrderPads { get; set; }
        public Customer() { }
        public Customer(string Name,string IdentityDocument, string PhoneNumber) 
        {
            this.Name = Name;
            this.IdentityDocument = IdentityDocument;
            this.PhoneNumber = PhoneNumber;
        }
        
        public override string ToString()
        {
            return "Name: " + Name + " Id: " + Id;
        }

        public override string Validate()
        {
            string validationResult = ValidatePerson();
            if (validationResult == "")
                validationResult = "VALID";
            return validationResult;
        }
    }
}
