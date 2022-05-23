using Pastelaria.AppService.Shared;
using Pastelaria.Domain;
using Pastelaria.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace Pastelaria.AppService
{
    public class OrderPadAppService : AppServiceBase<OrderPad>
    {
        private readonly IProcessingProductRepository processingProductRepository;
        private readonly IOrderPadRepository orderPadRepository;

        public OrderPadAppService(IProcessingProductRepository processingProductRepository
                                  ,IOrderPadRepository orderPadRepository)
        {
            this.processingProductRepository = processingProductRepository;
            this.orderPadRepository = orderPadRepository;
        }

        public override List<OrderPad> GetAll()
        {
            try
            {
                return null;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public override string Delete(OrderPad entity)
        {
            throw new NotImplementedException();
        }

        public override string Exists(Guid Id)
        {
            throw new NotImplementedException();
        }

        public override OrderPad GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public override string Insert(OrderPad entity)
        {
            throw new NotImplementedException();
        }

        public override string Update(OrderPad entity)
        {
            throw new NotImplementedException();
        }
    }
}
