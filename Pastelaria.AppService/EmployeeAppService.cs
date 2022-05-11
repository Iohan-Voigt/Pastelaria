using Pastelaria.AppService.Shared;
using Pastelaria.Domain;
using Pastelaria.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace Pastelaria.AppService
{
    public class EmployeeAppService : AppServiceBase<Employee>
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeAppService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
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
                    return "Employee:  " + entity.Name.ToString() + " succeed updated!";
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

        public Employee GetByAcessUserAndPassword(Employee value)
        {
            try
            {
                return employeeRepository.GetByAcessUserAndPassword(value);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
