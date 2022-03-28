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
            try
            {
                if (entity.Validate().Equals("VALID"))
                {

                    employeeRepository.Update(entity);
                    return "VALID";

                }

                return entity.Validate();
            }
            catch (Exception)
            {

                return "ERROR";
            }
        }

        public override string Exists(Guid Id)
        {
            try
            {
                if (employeeRepository.GetById(Id) != null)
                    return "YES";
                else
                    return "NO";
            }
            catch (Exception)
            { 
                return "ERROR";
            }
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
            try
            {
                return employeeRepository.GetById(Id);
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
