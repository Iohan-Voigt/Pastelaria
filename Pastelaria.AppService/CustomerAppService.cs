using Pastelaria.AppService.Shared;
using Pastelaria.Domain;
using Pastelaria.Domain.Repositories;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.AppService
{
    public class CustomerAppService : AppServiceBase<Customer>
    {
        private readonly ICustomerRepository customerRepository;
        private Stopwatch stopwatch = Stopwatch.StartNew();

        public CustomerAppService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public override string Delete(Customer entity)
        {
            try
            {
                Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Try to delete Customer ({entity.Id})");
                stopwatch.Reset();
                stopwatch.Start();

                customerRepository.Remove(entity.Id);

                stopwatch.Stop();
                Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Try to delete Customer ({entity.Id})");

                return "VALID";
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Customer not removed");
                Log.Logger.Error("Exception: " + ex.Message);
                return "ERROR";
            }
        }

        public override string Exists(Guid Id)
        {
            try
            {
                Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Verify id Customer ({Id}) exists");
                stopwatch.Reset();
                stopwatch.Start();

                Customer customer = customerRepository.GetById(Id);

                stopwatch.Stop();

                if (customer != null)
                {
                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Customer ({Id}) exists | {stopwatch.ToString}");
                    return "YES";
                }

                else
                {
                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Customer ({Id}) not found | {stopwatch.ToString}");
                    return "NO";
                }
                    
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Customer Exists Error");
                Log.Logger.Error("Exception: " + ex.Message);
                return "ERROR";
            }
        }

        public override List<Customer> GetAll()
        {
            List<Customer> customers;

            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Getting all Customers");

            try
            {
                stopwatch.Restart();
                stopwatch.Start();

                return customers = customerRepository.GetAll();

                Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | {customers.Count} Customers returned | {stopwatch.ToString}");
                stopwatch.Stop();
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Customer Get all Error");
                Log.Logger.Error("Exception: " + ex.Message);

                return null;
            }
        }

        public override Customer GetById(Guid Id)
        {
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Get Customer by Id ({Id})");
            try
            {
                stopwatch.Restart();
                stopwatch.Start();

                Customer customer = customerRepository.GetById(Id);              

                stopwatch.Stop();
                Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Customer Found | {stopwatch.ToString}");

                return customer;
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Get Customer error");
                Log.Logger.Error("Exception: " + ex.Message);

                return null;
            }
        }

        public override string Insert(Customer entity)
        {
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Inserting Customer");
            try
            {
                stopwatch.Restart();
                stopwatch.Start();

                if (entity.Validate().Equals("VALID"))
                {
                    customerRepository.Insert(entity);
                    stopwatch.Stop();
                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Customer succeed inserted | {stopwatch.ToString}");

                    return "VALID";
                }
                else
                {
                    stopwatch.Stop();
                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Invalid Customer | {stopwatch.ToString}");
                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | {entity.Validate()}");

                    return entity.Validate();
                }
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Insert Customer error");
                Log.Logger.Error("Exception: " + ex.Message);

                return "ERROR";
            }
        }

        public override string Update(Customer entity)
        {
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Customer update Id ({entity.Id})");
            try
            {
                stopwatch.Restart();
                stopwatch.Start();

                if (entity.Validate().Equals("VALID"))
                {
                    customerRepository.Update(entity);
                    stopwatch.Stop();

                    return "Customer:  " + entity.Name.ToString() + " succeed updated!";
                }

                stopwatch.Stop();

                return entity.Validate();
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Update Customer error");
                Log.Logger.Error("Exception: " + ex.Message);

                return "ERROR";
            }
        }
    }
}
