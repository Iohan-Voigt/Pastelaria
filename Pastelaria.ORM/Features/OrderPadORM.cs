using Microsoft.EntityFrameworkCore;
using Pastelaria.Domain;
using Pastelaria.Domain.Repositories;
using Pastelaria.ORM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pastelaria.ORM.Features
{
    public class OrderPadORM : RepositoryBase<OrderPad>, IOrderPadRepository
    {
        public OrderPadORM(PastelariaDBContext db) : base(db)
        {

        }

        public override List<OrderPad> GetAll()
        {
            return db.OrderPads
                .Include(x => x.Employee)
                .Include(x => x.Customer)
                .Include(x => x.ProcessingProducts)
                .ToList<OrderPad>();
        }

        public override OrderPad GetById(Guid id)
        { 
            return db.OrderPads
                .Include(x=> x.Employee)
                .Include(x => x.Customer)
                .Include(x => x.ProcessingProducts)
                .FirstOrDefault(x => x.Id == id);
        }
    }
}


