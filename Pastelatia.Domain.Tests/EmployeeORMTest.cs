using NUnit.Framework;
using Pastelaria.Domain;
using Pastelaria.Domain.Repositories;
using Pastelaria.Domain.Shared;
using Pastelaria.ORM;
using Pastelaria.ORM.Features;

namespace Pastelatia.Domain.Tests
{
    public class EmployeeORMTest
    {
        private IEmployeeRepository employeeRepository;
        PastelariaDBContext dbContext = new();

        Employee employeecomplete = new();
        Employee employeetest = new("123", "123", "123", "reg123", "99999999999", "99999999999", EmployeePermissionsEnum.Admin);
        Employee employeeincorrect = new();

        [SetUp]
        public void Setup()
        {
            employeeRepository = new EmployeeORM(dbContext);
        }

        [Test]
        public void InsertInDBCorrect()
        {
            employeeRepository.Insert(employeetest);
            dbContext.SaveChanges();
            var employeeFound = employeeRepository.GetById(employeetest.Id);
            
            Assert.AreEqual(employeeFound, employeetest);
        }
    }
}
