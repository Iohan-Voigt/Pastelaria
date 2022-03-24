using Pastelaria.AppService.Shared;
using Pastelaria.Domain;
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
        private readonly RepositoryBase<Employee> employeeORM;

        public EmployeeAppService(RepositoryBase<Employee> employeeORM)
        {
            this.employeeORM = employeeORM;
        }

        public override string Insert(Employee entity)
        {
            try
            {
                if (entity.Validate().Equals("VALID"))
                {
                    employeeORM.Insert(entity);
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
                employeeORM.Remove(entity);
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

        public override IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Employee GetById(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
