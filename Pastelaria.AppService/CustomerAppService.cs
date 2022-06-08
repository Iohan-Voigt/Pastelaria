using Pastelaria.AppService.Shared;
using Pastelaria.Domain;
using Pastelaria.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.AppService
{
    public class CustomerAppService : AppServiceBase<Customer>
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerAppService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public override string Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public override string Exists(Guid Id)
        {
            throw new NotImplementedException();
        }

        public override List<Customer> GetAll()
        {
            List<Customer> customers;
            try
            {
                return customers = customerRepository.GetAll();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public override Customer GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public override string Insert(Customer entity)
        {
            throw new NotImplementedException();
        }

        public override string Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
