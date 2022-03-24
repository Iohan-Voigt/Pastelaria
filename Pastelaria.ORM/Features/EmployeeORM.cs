using Pastelaria.Domain;
using Pastelaria.Domain.Shared;
using Pastelaria.ORM.Shared;

namespace Pastelaria.ORM.Features
{
    public class EmployeeORM : RepositoryBase<Employee> , IRepository<Employee>
    {
        public EmployeeORM(PastelariaDBContext db) : base(db)
        {
        }
    }
}
