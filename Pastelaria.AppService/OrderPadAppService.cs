using Pastelaria.AppService.Shared;
using Pastelaria.Domain;
using Pastelaria.Domain.Repositories;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Pastelaria.AppService
{
    public class OrderPadAppService : AppServiceBase<OrderPad>
    {
        private readonly IProcessingProductRepository processingProductRepository;
        private readonly IEmployeeRepository employeeRepository;
        private readonly IOrderPadRepository orderPadRepository;
        private readonly ICustomerRepository customerRepository;
        private Stopwatch stopwatch = Stopwatch.StartNew();

        public OrderPadAppService(IOrderPadRepository orderPadRepository
                                  ,IProcessingProductRepository processingProductRepository
                                  ,IEmployeeRepository employeeRepository
                                  ,ICustomerRepository customerRepository)
        {
            this.processingProductRepository = processingProductRepository;
            this.orderPadRepository = orderPadRepository;
            this.employeeRepository = employeeRepository;
            this.customerRepository = customerRepository;
        }

        public override List<OrderPad> GetAll()
        {
            try
            {               
                return orderPadRepository.GetAll();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public override string Delete(OrderPad entity)
        {
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Try to delete OrderPad ({entity.Id})");
            try
            {
                stopwatch.Restart();
                stopwatch.Start();

                processingProductRepository.RemoveByOrderPadId(entity.Id);
                orderPadRepository.Remove(entity.Id);

                stopwatch.Stop();
                Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | OrderPad succeed removed | {stopwatch.ToString}");

                return "VALID";
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | OrderPad not removed");
                Log.Logger.Error("Exception: " + ex.Message);

                return "ERROR";
            }
        }

        public override string Exists(Guid Id)
        {
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | OrderPad Exists ({Id})");
            try
            {
                stopwatch.Restart();
                stopwatch.Start();

                OrderPad orderPad = orderPadRepository.GetById(Id);

                Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | OrdePad Found | {stopwatch.ToString}");
                stopwatch.Stop();
                if (orderPad != null)
                    return "YES";
                else
                    return "NO";
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Get OrderPad error");
                Log.Logger.Error("Exception: " + ex.Message);

                return null;
            }
        }

        public override OrderPad GetById(Guid Id)
        {
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Get OrderPad by Id ({Id})");
            try
            {
                stopwatch.Restart();
                stopwatch.Start();

                OrderPad orderPad = orderPadRepository.GetById(Id);

                Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | OrdePad Found | {stopwatch.ToString}");
                stopwatch.Stop();

                return orderPad;
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Get OrderPad error");
                Log.Logger.Error("Exception: " + ex.Message);

                return null;
            }
        }

        public override string Insert(OrderPad entity)
        {
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Inserting OrderPad");
            try
            {
                if (entity.Validate().Equals("VALID"))
                {
                    stopwatch.Restart();
                    stopwatch.Start();

                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Processing OrderPad");
                    foreach (var item in entity.ProcessingProducts)
                    {
                        item.Id = Guid.Empty;
                    }

                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Getting Employe from database OrderPad");
                    entity.Employee = employeeRepository.GetById(entity.Employee.Id);
                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Getting Customer from database OrderPad");
                    entity.Customer = customerRepository.GetById(entity.Customer.Id);

                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Processing OrderPad succeed");

                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Inserting OrderPad into database");
                    orderPadRepository.Insert(entity);

                    stopwatch.Stop();
                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Insert OrderPad success | {stopwatch.ToString}");

                    return "VALID";
                }
                else
                {
                    stopwatch.Stop();
                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | OrderPad Invalid | {entity.Validate()} | {stopwatch.ToString}");

                    return entity.Validate();
                }
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Insert OrderPad error");
                Log.Logger.Error("Exception: " + ex.Message);

                return "ERROR";
            }
            
        }

        public override string Update(OrderPad entity)
        {
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | OrderPad update Id ({entity.Id})");
            try
            {
                stopwatch.Restart();
                stopwatch.Start();

                if (entity.Validate().Equals("VALID"))
                {
                    orderPadRepository.Update(entity);
                    stopwatch.Stop();

                    return "OrderPad succeed updated!";
                }

                stopwatch.Stop();

                return entity.Validate();
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Update OrderPad error");
                Log.Logger.Error("Exception: " + ex.Message);

                return "ERROR";
            }
        }
    }
}
