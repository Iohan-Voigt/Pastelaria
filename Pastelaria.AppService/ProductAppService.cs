using Pastelaria.AppService.Shared;
using Pastelaria.Domain;
using Pastelaria.Domain.Repositories;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Pastelaria.AppService
{
    public class ProductAppService : AppServiceBase<Product>
    {
        private readonly IProductRepository productRepository;
        private Stopwatch stopwatch = Stopwatch.StartNew();

        public ProductAppService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public override string Delete(Product entity)
        {
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Try to delete Product ({entity.Id})");
            try
            {
                stopwatch.Restart();
                stopwatch.Start();

                productRepository.Remove(entity.Id);

                stopwatch.Stop();
                Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Product succeed removed | {stopwatch.ToString}");

                return "VALID";
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Product not removed");
                Log.Logger.Error("Exception: " + ex.Message);

                return "ERROR";
            }
        }

        public override string Exists(Guid Id)
        {
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Verify id Product ({Id}) exists");
            try
            {
                stopwatch.Restart();
                stopwatch.Start();
                Product product = productRepository.GetById(Id);
                stopwatch.Stop();

                if (product != null)
                {
                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Product ({Id}) exists | {stopwatch.Elapsed}");
                    return "YES";
                }                   
                else
                {
                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Product ({Id}) not found | {stopwatch.Elapsed}");
                    return "NO";
                }
                    
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Product Exists Error");
                Log.Logger.Error("Exception: " + ex.Message);

                return "ERROR";
            }
        }

        public override List<Product> GetAll()
        {
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Getting all Products");
            try
            {
                stopwatch.Restart();
                stopwatch.Start();
                List<Product> products = productRepository.GetAll();
                stopwatch.Stop();

                Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | {products.Count} Products returned | {stopwatch.Elapsed}");

                return products;
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Product Get all Error");
                Log.Logger.Error("Exception: " + ex.Message);

                return null;
            }
        }

        public override Product GetById(Guid Id)
        {
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Get Product by Id ({Id})");
            try
            {
                stopwatch.Restart();
                stopwatch.Start();

                Product product = productRepository.GetById(Id);

                Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Product Found | {stopwatch.Elapsed}");
                stopwatch.Stop();

                return product;               
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Get Product error");
                Log.Logger.Error("Exception: " + ex.Message);

                return null;
            }
        }

        public override string Insert(Product entity)
        {
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Inserting Product");
            try
            {
                stopwatch.Restart();
                stopwatch.Start();

                if (entity.Validate().Equals("VALID"))
                {
                    productRepository.Insert(entity);
                    stopwatch.Stop();
                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Product succeed inserted | {stopwatch.Elapsed}");
                    return "VALID";
                }
                else
                {
                    stopwatch.Stop();
                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Invalid Product | {stopwatch.Elapsed}");
                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | {entity.Validate()}");
                    return entity.Validate();
                }
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Insert Product error");
                Log.Logger.Error("Exception: " + ex.Message);
                return "ERROR";
            }
        }

        public override string Update(Product entity)
        {
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Product update Id ({entity.Id})");
            try
            {
                stopwatch.Restart();
                stopwatch.Start();

                if (entity.Validate().Equals("VALID"))
                {
                    productRepository.Update(entity);
                    stopwatch.Stop();

                    return "Product:  " + entity.Name.ToString() + " succeed updated!";
                }

                stopwatch.Stop();

                return entity.Validate();
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Update Product error");
                Log.Logger.Error("Exception: " + ex.Message);

                return "ERROR";
            }
        }
    }
}
