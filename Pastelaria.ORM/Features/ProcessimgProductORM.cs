using Pastelaria.Domain;
using Pastelaria.Domain.Repositories;
using Pastelaria.ORM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.ORM.Features
{
    public class ProcessingProductORM : RepositoryBase<ProcessingProduct>, IProcessingProductRepository
    {
        public ProcessingProductORM(PastelariaDBContext db) : base(db)
        {
        }

        public bool RemoveByOrderPadId(Guid id)
        {
            try
            {
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
