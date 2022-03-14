using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Pastelaria.Domain;
using System.IO;
using System.Linq;

namespace Pastelaria.ORM
{
    public class PastelariaDBContext : DbContext
    {
        private static ILoggerFactory loggerFactoryConsole = LoggerFactory.Create(x => x.AddConsole());
        private DbSet<Costumer> Costumers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(loggerFactoryConsole)
                .UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBPASTELARIA;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PastelariaDBContext).Assembly);
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
