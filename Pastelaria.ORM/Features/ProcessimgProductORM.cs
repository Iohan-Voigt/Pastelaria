using Microsoft.EntityFrameworkCore;
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

        public List<ProcessingProduct> GetAllByOrderPadId(Guid id)
        {
            try
            {
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool RemoveByOrderPadId(Guid id)
        {
            try
            {
                var products = db.ProcessingProducts
                    .Include(x => x.OrderPad)
                    .Where(x => x.OrderPad.Id == id)
                    .ToList<ProcessingProduct>();
                foreach (var product in products)
                {
                    db.ProcessingProducts.Remove(product);
                }                
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
