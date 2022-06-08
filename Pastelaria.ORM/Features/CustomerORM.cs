using Pastelaria.Domain;
using Pastelaria.Domain.Repositories;
using Pastelaria.ORM.Shared;

namespace Pastelaria.ORM.Features
{
    public class CustomerORM : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerORM(PastelariaDBContext db) : base(db)
        {
        }
    }
}
