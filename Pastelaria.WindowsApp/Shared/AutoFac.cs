﻿using Autofac;
using Pastelaria.AppService;
using Pastelaria.AppService.Shared;
using Pastelaria.Domain.Shared;
using Pastelaria.ORM;
using Pastelaria.ORM.Features;
using Pastelaria.ORM.Shared;
using Pastelaria.WindowsApp.Costumer;
using Pastelaria.WindowsApp.Employee;
using Pastelaria.WindowsApp.OrderPad;
using Pastelaria.WindowsApp.Product;

namespace Pastelaria.WindowsApp.Shared
{
    public class AutoFac
    {
        public static ContainerBuilder Builder = new();
        public static IContainer Container;
        
        static AutoFac()         
        {                  
            Builder.RegisterType<PastelariaDBContext>().InstancePerLifetimeScope();

            ORMConfiguration();

            AppServiceConfiguration();

            OperationConfiguration();

            Container = Builder.Build();
        }

        private static void OperationConfiguration() 
        {
            Builder.RegisterType<CostumerOperations>().InstancePerDependency();
            Builder.RegisterType<EmployeeOperations>().InstancePerDependency();
            Builder.RegisterType<ProductOperations>().InstancePerDependency(); 
            Builder.RegisterType<OrderPadOperations>().InstancePerDependency();
        }

        private static void AppServiceConfiguration()
        {
            Builder.RegisterType<EmployeeAppService>().InstancePerDependency();
        }

        private static void ORMConfiguration()
        {
            Builder.RegisterType<EmployeeORM>().As<IRepository<Domain.Employee>>().InstancePerDependency();
        }
    }
}
