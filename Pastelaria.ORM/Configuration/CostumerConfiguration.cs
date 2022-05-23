using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pastelaria.Domain;

namespace Pastelaria.ORM.Configuration
{
    public class CostumerConfiguration : IEntityTypeConfiguration<Costumer>
    {
        public void Configure(EntityTypeBuilder<Costumer> builder)
        {
            builder.ToTable("DOMAIN.COSTUMER");

            builder.HasKey(x => x.Id);

            builder.Property(p => p.Name).HasColumnType("VARCHAR(75)").IsRequired();
            builder.Property(p => p.IdentityDocument).HasColumnType("VARCHAR(14)");
            builder.Property(p => p.PhoneNumber).HasColumnType("VARCHAR(20)");
        }
    }
}
