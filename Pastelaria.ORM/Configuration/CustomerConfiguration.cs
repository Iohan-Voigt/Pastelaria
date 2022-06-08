using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pastelaria.Domain;

namespace Pastelaria.ORM.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("DOMAIN.CUSTOMER");

            builder.HasKey(x => x.Id); 

            builder.Property(p => p.Name).HasColumnType("VARCHAR(75)").IsRequired();
            builder.Property(p => p.IdentityDocument).HasColumnType("VARCHAR(14)");
            builder.Property(p => p.PhoneNumber).HasColumnType("VARCHAR(20)");

            builder.HasMany(x => x.OrderPads).WithOne(x => x.Customer);
        }
    }
}
