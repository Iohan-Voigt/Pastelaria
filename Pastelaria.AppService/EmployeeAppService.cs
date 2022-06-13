using Pastelaria.AppService.Shared;
using Pastelaria.Domain;
using Pastelaria.Domain.Repositories;
using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Pastelaria.AppService
{
    public class EmployeeAppService : AppServiceBase<Employee>
    {
        private readonly IEmployeeRepository employeeRepository;
        private Stopwatch stopwatch = Stopwatch.StartNew();

        public EmployeeAppService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public override string Insert(Employee entity)
        {
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Inserting Employee");
            try
            {
                stopwatch.Restart();
                stopwatch.Start();

                if (entity.Validate().Equals("VALID"))
                {
                    employeeRepository.Insert(entity);

                    stopwatch.Stop();
                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Employee succeed inserted | {stopwatch.ToString}");

                    return "VALID";
                }
                else
                {
                    stopwatch.Stop();
                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Invalid Employee | {stopwatch.ToString}");
                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | {entity.Validate()}");

                    return entity.Validate();
                }
            }
            catch (Exception ex )
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Insert Employee error");
                Log.Logger.Error("Exception: " + ex.Message);

                return "ERROR";
            }
            
        }

        public override string Delete(Employee entity)
        {
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Try to delete Employee ({entity.Id})");
            try
            {
                stopwatch.Restart();
                stopwatch.Start();

                employeeRepository.Remove(entity.Id);

                stopwatch.Stop();
                Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Employee succeed removed | {stopwatch.ToString}");

                return "VALID";
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Employee not removed");
                Log.Logger.Error("Exception: " + ex.Message);

                return "ERROR";
            }
        }

        public override string Update(Employee entity)
        {
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Employee update Id ({entity.Id})");
            try
            {
                stopwatch.Restart();
                stopwatch.Start();

                if (entity.Validate().Equals("VALID"))
                {
                    employeeRepository.Update(entity);
                    stopwatch.Stop();

                    return "Employee:  " + entity.Name.ToString() + " succeed updated!";
                }

                stopwatch.Stop();

                return entity.Validate();
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Update Employee error");
                Log.Logger.Error("Exception: " + ex.Message);

                return "ERROR";
            }
        }

        public override string Exists(Guid Id)
        {
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Verify id Employee ({Id}) exists");
            try
            {
                stopwatch.Restart();
                stopwatch.Start();
                Employee employee = employeeRepository.GetById(Id);
                stopwatch.Stop();

                if (employee != null)
                {
                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Employee ({Id}) exists | {stopwatch.ToString}");
                    return "YES";
                }
                else
                {
                    Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Employee ({Id}) not found | {stopwatch.ToString}");
                    return "NO";
                }

            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Employee Exists Error");
                Log.Logger.Error("Exception: " + ex.Message);

                return "ERROR";
            }
        }

        public override List<Employee> GetAll()
        {
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Getting all Employee");
            try
            {
                stopwatch.Restart();
                stopwatch.Start();
                List<Employee> employee = employeeRepository.GetAll();
                stopwatch.Stop();

                Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | {employee.Count} Employee returned | {stopwatch.ToString}");

                return employee;
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Employee Get all Error");
                Log.Logger.Error("Exception: " + ex.Message);

                return null;
            }
        }

        public override Employee GetById(Guid Id)
        {
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Get Employee by Id ({Id})");
            try
            {
                stopwatch.Restart();
                stopwatch.Start();

                Employee employee = employeeRepository.GetById(Id);

                Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Employee Found | {stopwatch.ToString}");
                stopwatch.Stop();

                return employee;
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Get Employee error");
                Log.Logger.Error("Exception: " + ex.Message);

                return null;
            }
        }

        public Employee GetByAcessUserAndPassword(Employee value)
        {
            Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Employee get by username and passwod | User: {value.AcessUser}");           
            try
            {
                stopwatch.Restart();
                stopwatch.Start();

                Employee employee = employeeRepository.GetByAcessUserAndPassword(value);

                stopwatch.Stop();
                Log.Logger.Information($"{this.ToString().Replace(", Text: ", "")} | Employee success found | {stopwatch.ToString}");

                return employee;
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                Log.Logger.Error($"{this.ToString().Replace(", Text: ", "")} | Get Employee by username and password");
                Log.Logger.Error("Exception: " + ex.Message);

                return null;
            }
        }
    }
}
