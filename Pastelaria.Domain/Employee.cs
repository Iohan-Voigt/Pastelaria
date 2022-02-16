using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pastelaria.Domain.Shared;

namespace Pastelaria.Domain
{
    public class Employee : UserEntity
    {
        public string user { get; set; }
        public string password { get; set; }

        public Employee(string name,string RegisterNumber, string ContactNumber, string user, string passowrd)
        {
            this.Name = name;
            this.RegisterNumber = RegisterNumber;
            this.ContactNumber = ContactNumber;
            this.user = user;
            this.password = passowrd;
        }
    }
}
