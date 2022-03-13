using System;

namespace Pastelaria.Domain
{
    public class Costumer : Person
    {

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public override string Validate()
        {
            ValidatePerson();
            throw new NotImplementedException();
        }
    }
}
