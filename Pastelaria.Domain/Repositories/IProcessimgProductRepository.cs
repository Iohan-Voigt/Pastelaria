using System;

namespace Pastelaria.Domain.Repositories
{
    public interface IProcessingProductRepository : IRepository<ProcessingProduct>
    {
        bool RemoveByOrderPadId(Guid id);
    }
}
