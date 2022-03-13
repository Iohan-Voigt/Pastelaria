using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pastelaria.Domain;

namespace Pastelaria.ORM
{
    public class PastelariaDBContext : DbContext
    {
        public DbSet<Costumer> Costumers { get; set; }
    }
}
