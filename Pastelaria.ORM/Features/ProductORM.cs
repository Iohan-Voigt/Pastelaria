using Pastelaria.Domain;
using Pastelaria.Domain.Repositories;
using Pastelaria.ORM.Shared;

namespace Pastelaria.ORM.Features
{
    public class ProductORM : RepositoryBase<Product>, IProductRepository
    {
        public ProductORM(PastelariaDBContext db) : base(db)
        {
        }
    }
}
