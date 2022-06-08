using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using Pastelaria.Domain;
using System.Data;
using System.IO;
using System.Linq;

namespace Pastelaria.ORM
{
    public class PastelariaDBContext : DbContext
    {
        private static ILoggerFactory loggerFactoryConsole = LoggerFactory.Create(x => x.AddConsole());
        private DbSet<Customer> Costumers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DataSet ds = new();

            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Pastelaria");

            //var connectionString = "";
            var connectionString = key.GetValue("ConnectionString").ToString();

            optionsBuilder
                .UseLoggerFactory(loggerFactoryConsole)
                .UseSqlServer(connectionString);    
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PastelariaDBContext).Assembly);
            modelBuilder.HasDefaultSchema("PASTELARIA");
            
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                var properties = entity.GetProperties().Where(p => p.ClrType == typeof(decimal));

                foreach (var property in properties)
                {
                    if (string.IsNullOrEmpty(property.GetColumnType()) && !property.GetMaxLength().HasValue)
                        property.SetColumnType("decimal(18,2)");
                }
            }
        }

        public static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .SetBasePath(Directory.GetCurrentDirectory())
                .Build();
            return config;
        }
    }
}
