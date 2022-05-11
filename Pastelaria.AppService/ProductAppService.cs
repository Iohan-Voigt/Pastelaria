using Pastelaria.AppService.Shared;
using Pastelaria.Domain;
using Pastelaria.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace Pastelaria.AppService
{
    public class ProductAppService : AppServiceBase<Product>
    {
        private readonly IProductRepository productRepository;

        public ProductAppService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public override string Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public override string Exists(Guid Id)
        {
            throw new NotImplementedException();
        }

        public override List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public override Product GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public override string Insert(Product entity)
        {
            try
            {
                if (entity.Validate().Equals("VALID"))
                {
                    productRepository.Insert(entity);
                    return "VALID";
                }
                else
                {
                    return entity.Validate();
                }
            }
            catch (Exception)
            {
                return "ERROR";
            }
        }

        public override string Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
