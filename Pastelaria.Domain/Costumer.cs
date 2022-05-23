namespace Pastelaria.Domain
{
    public class Costumer : Person
    {
        public override string ToString()
        {
            return "Name: " + Name + " Id: " + Id;
        }

        public override string Validate()
        {
            return ValidatePerson();          
        }
    }
}
