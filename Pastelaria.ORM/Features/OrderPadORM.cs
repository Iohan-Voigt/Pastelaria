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
                .ToList<OrderPad>();
        }
    }
}


