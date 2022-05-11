using Pastelaria.Domain;
using Pastelaria.Domain.Repositories;
using Pastelaria.ORM.Shared;
using System;
using System.Linq;

namespace Pastelaria.ORM.Features
{
    public class EmployeeORM : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeORM(PastelariaDBContext db) : base(db)
        {

        }

        public Employee GetByAcessUserAndPassword(Employee value)
        {
            try
            {
                return dbSet.FirstOrDefault(x => x.AcessUser.Equals(value.AcessUser) && x.Password.Equals(value.Password));
            }
            catch (Exception ex)
            {
                return null;
            }
            return null;
        }
    }
}
