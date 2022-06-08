using System;
using System.Collections.Generic;

namespace Pastelaria.Domain.Repositories
{
    public interface IProcessingProductRepository : IRepository<ProcessingProduct>
    {
        List<ProcessingProduct> GetAllByOrderPadId(Guid id);
        bool RemoveByOrderPadId(Guid id);
    }
}
