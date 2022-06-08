using Pastelaria.AppService.Shared;
using Pastelaria.Domain;
using Pastelaria.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.AppService
{
    public class ProcessingProductAppService : AppServiceBase<ProcessingProduct>
    {
        private readonly IProcessingProductRepository processingProductRepository;

        public ProcessingProductAppService(IProcessingProductRepository processingProductRepository)
        {
            this.processingProductRepository = processingProductRepository;
        }
        public override string Delete(ProcessingProduct entity)
        {
            throw new NotImplementedException();
        }

        public override string Exists(Guid Id)
        {
            throw new NotImplementedException();
        }

        public override List<ProcessingProduct> GetAll()
        {
            throw new NotImplementedException();
        }

        public override ProcessingProduct GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public override string Insert(ProcessingProduct entity)
        {
            throw new NotImplementedException();
        }

        public override string Update(ProcessingProduct entity)
        {
            throw new NotImplementedException();
        }
    }
}
