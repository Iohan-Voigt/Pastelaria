using Autofac;
using Pastelaria.ORM;
using Pastelaria.WindowsApp.Costumer;
using Pastelaria.WindowsApp.Employee;

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
        }

        private static void AppServiceConfiguration()
        {

        }

        private static void ORMConfiguration()
        {

        }
    }
}
