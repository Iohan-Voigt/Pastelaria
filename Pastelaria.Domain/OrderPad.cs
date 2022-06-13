using Pastelaria.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.Domain
{
    public class OrderPad : EntityBase
    {
        public List<ProcessingProduct> ProcessingProducts { get; set; }
        public Employee Employee { get; set; }
        public Customer Customer { get; set; }
        public DateTime OpenTime { get; set; }
        public OrderPadStatus OrderPadStatus { get; set; }
        public OrderPadPaymentStatus OrderPadPaymentStatus { get; set; }
        public decimal Total { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Employee}, {Customer}, {OpenTime}, {OrderPadStatus}, {OrderPadPaymentStatus}, {Total}";
        }

        public override string Validate()
        {
            string validationResult = "";

            if (ProcessingProducts.Count < 1)
                validationResult += "Must have at least one product\n";
            if (Customer == null)
                validationResult += "Must select a Customer\n";
            if (Employee == null)
                validationResult += "Must have a Employee Logged\n";

            if (validationResult.Equals(""))
            {
                validationResult = "VALID";
            }
            return validationResult;
        }
    }
}
