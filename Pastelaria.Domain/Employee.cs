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
        public EmployeeActiveEnum EmployeeActiveEnum { get; set; }

        public Employee() { }
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
            string validationResult = "";

            validationResult += ValidatePerson();

            if (AcessUser.Length < 5)
                validationResult += "The AcessUser must have at least 5 characters\n";
            if (Password.Length < 8)
                validationResult += "The Password must have at least 8 characters\n";
            if (Registration.Length < 3)
                validationResult += "The Registration must have at least 3 characters\n";
            if (PhoneNumber.Length < 10)
                validationResult += "The Phone Number is not completed\n";

                if (validationResult == "")
                    return "VALID";
            else
                    return validationResult;
        }
    }
}
