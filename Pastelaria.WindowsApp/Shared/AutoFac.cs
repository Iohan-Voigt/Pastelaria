﻿using Autofac;
using Pastelaria.ORM;
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

            OperationConfiguration();

            AppServiceConfiguration();

            ORMConfiguration();

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

        }

        private static void ORMConfiguration()
        {

        }
    }
}
