using NUnit.Framework;
using Pastelaria.Domain;
using Pastelaria.Domain.Repositories;
using Pastelaria.Domain.Shared;
using Pastelaria.ORM;
using Pastelaria.ORM.Features;
namespace Pastelatia.Domain.Tests
{
    public class CustomerORMTest
    {
        private ICustomerRepository _customerRepository;
        PastelariaDBContext dbContext = new();

        Customer customer = new("Jorge", "68318572050", "47996993249");
        [SetUp]
        public void Setup()
        {
            _customerRepository = new CustomerORM(dbContext);
        }

        [Test]
        public void InsertInDBCorrect()
        {
            _customerRepository.Insert(customer);
            dbContext.SaveChanges();
            var employeeFound = _customerRepository.GetById(customer.Id);

            Assert.AreEqual(employeeFound, customer);
        }
    }
}
