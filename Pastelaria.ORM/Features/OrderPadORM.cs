using Pastelaria.Domain;
using Pastelaria.Domain.Shared;
using Pastelaria.ORM.Shared;

namespace Pastelaria.ORM.Features
{
    public class OrderPadORM : RepositoryBase<Costumer>, IRepository<Costumer>
    {
        public OrderPadORM(PastelariaDBContext db) : base(db)
        {
        }
    }
}
