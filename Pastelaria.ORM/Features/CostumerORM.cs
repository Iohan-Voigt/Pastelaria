using Pastelaria.Domain;
using Pastelaria.ORM.Shared;

namespace Pastelaria.ORM.Features
{
    public class CostumerORM : RepositoryBase<Costumer>
    {
        public CostumerORM(PastelariaDBContext db) : base(db)
        {
        }
    }
}
