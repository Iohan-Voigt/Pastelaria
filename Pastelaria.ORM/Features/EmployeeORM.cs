using Pastelaria.Domain;
using Pastelaria.ORM.Shared;

namespace Pastelaria.ORM.Features
{
    public class EmployeeORM : RepositoryBase<Employee>
    {
        public EmployeeORM(PastelariaDBContext db) : base(db)
        {
        }
    }
}
