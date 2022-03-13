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
        public string AcessUser { get; set; }
        public string Password { get; set; }
        public string Registration { get; set; }
        public EmployeePermissionsEnum EmployeePermissionsEnum { get; set; }

        public Employee(string name, string acessUser) 
        {
            this.Name = name;
            this.AcessUser = acessUser;
        }

        public Employee(string name, string acessUser, string password, string indentityDocument,string phoneNumber,EmployeePermissionsEnum employeePermissionsEnum)
        {
            this.Name = name;
            this.AcessUser = acessUser;
            this.Password = password;
            this.IndentityDocument = indentityDocument;
            this.PhoneNumber = phoneNumber;
            this.EmployeePermissionsEnum = employeePermissionsEnum;
        }

        public override string ToString()
        {
            return (Name + " " + EmployeePermissionsEnum.GetType());
        }

        public override string Validate()
        {
            return "";
        }
    }
}
