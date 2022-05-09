using Pastelaria.Domain;
using Pastelaria.Domain.Shared;
using Pastelaria.ORM.Shared;


namespace Pastelaria.ORM.Features
{
    public class ProductORM : RepositoryBase<Product>, IRepository<Product>
    {
        public ProductORM(PastelariaDBContext db) : base(db)
        {
        }
    }
}
