﻿using Pastelaria.Domain;
using Pastelaria.Domain.Repositories;
using Pastelaria.ORM.Shared;
using System;

namespace Pastelaria.ORM.Features
{
    public class OrderPadORM : RepositoryBase<OrderPad>, IOrderPadRepository
    {
        public OrderPadORM(PastelariaDBContext db) : base(db)
        {

        }
    }
}


