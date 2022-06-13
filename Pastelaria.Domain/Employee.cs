using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pastelaria.Domain.Shared;
using Pastelaria.RescourcesLib;

namespace Pastelaria.Domain
{
    public class Employee : Person
    {
        public List<OrderPad> OrderPads { get; set; }
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

        public Employee(string name, string acessUser, string password, string registration, string identityDocument,string phoneNumber,EmployeePermissionsEnum employeePermissionsEnum)
        {
            this.Name = name;
            this.AcessUser = acessUser;
            this.Password = password;
            this.Registration = registration;
            this.IdentityDocument = identityDocument;
            this.PhoneNumber = phoneNumber;
            this.EmployeePermissionsEnum = employeePermissionsEnum;
            this.EmployeeActiveEnum = EmployeeActiveEnum.Active;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {AcessUser}, {Registration}";
        }

        public override string Validate()
        {
            string validationResult = "";

            validationResult += ValidatePerson();

            if (AcessUser.Length < 5)
                validationResult += GeneralConfig.Data["The AcessUser must have at least 5 characters"] + "\n";
            if (Password.Length < 8)
                validationResult += GeneralConfig.Data["The Password must have at least 8 characters"] + "\n";
            if (Registration.Length < 3)
                validationResult += GeneralConfig.Data["The Registration must have at least 3 characters"] + "\n";
            if (PhoneNumber.Length < 10)
                validationResult += GeneralConfig.Data["The Phone Number is not completed"] + "\n";

                if (validationResult == "")
                    return "VALID";
            else
                    return validationResult;
        }
    }
}
