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
            try
            {
                productRepository.Remove(entity.Id);
                return "VALID";
            }
            catch (Exception)
            {
                return "ERROR";
            }
        }

        public override string Exists(Guid Id)
        {
            try
            {
                if (productRepository.GetById(Id) != null)
                    return "YES";
                else
                    return "NO";
            }
            catch (Exception)
            {
                return "ERROR";
            }
        }

        public override List<Product> GetAll()
        {
            try
            {
                return productRepository.GetAll();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public override Product GetById(Guid Id)
        {
            try
            {
                return productRepository.GetById(Id);               
            }
            catch (Exception)
            {
                return null;
            }
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
            try
            {
                if (entity.Validate().Equals("VALID"))
                {
                    productRepository.Update(entity);
                    return "Product:  " + entity.Name.ToString() + " succeed updated!";
                }

                return entity.Validate();
            }
            catch (Exception)
            {

                return "ERROR";
            }
        }
    }
}
