using Pastelaria.AppService.Shared;
using Pastelaria.Domain;
using Pastelaria.Domain.Shared;
using Pastelaria.ORM.Features;
using Pastelaria.ORM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.AppService
{
    public class EmployeeAppService : AppServiceBase<Employee>
    {
        //update XX
        private readonly IRepository<Employee> employeeRepository;

        public EmployeeAppService(IRepository<Employee> employeeORM)
        {
            this.employeeRepository = employeeORM;
        }

        public override string Insert(Employee entity)
        {
            try
            {
                if (entity.Validate().Equals("VALID"))
                {
                    employeeRepository.Insert(entity);
                    return "VALID";
                }
                else
                {
                    return entity.Validate();
                }
            }
            catch (Exception)
            {
                return "ERROR";
            }
            
        }
        public override string Delete(Employee entity)
        {
            try
            {
                employeeRepository.Remove(entity.Id);
                return "VALID";
            }
            catch (Exception)
            {

                return "ERROR";
            }
        }
        public override string Update(Employee entity)
        {
            throw new NotImplementedException();
        }

        public override string Exists(Guid Id)
        {
            throw new NotImplementedException();
        }

        public override List<Employee> GetAll()
        {
            List<Employee> employees;
            try
            {
                return employees = employeeRepository.GetAll();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public override Employee GetById(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
