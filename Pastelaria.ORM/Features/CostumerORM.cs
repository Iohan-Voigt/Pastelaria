using Pastelaria.Domain;
using Pastelaria.Domain.Repositories;
using Pastelaria.ORM.Shared;

namespace Pastelaria.ORM.Features
{
    public class CostumerORM : RepositoryBase<Costumer>, IRepository<Costumer>
    {
        public CostumerORM(PastelariaDBContext db) : base(db)
        {
        }
    }
}
