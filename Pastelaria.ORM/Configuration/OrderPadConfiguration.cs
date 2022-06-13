using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pastelaria.Domain;

namespace Pastelaria.ORM.Configuration
{
    public class OrderPadConfiguration : IEntityTypeConfiguration<OrderPad>
    {
        public void Configure(EntityTypeBuilder<OrderPad> builder)
        {
            builder.ToTable("DOMAIN.ORDERPAD");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Customer).WithMany(x => x.OrderPads);
            builder.HasOne(x => x.Employee).WithMany(x => x.OrderPads);
            builder.HasMany(x => x.ProcessingProducts).WithOne(x => x.OrderPad);

            builder.Property(x => x.OrderPadStatus).HasColumnType("INT");
            builder.Property(x => x.OrderPadPaymentStatus).HasColumnType("INT");
            builder.Property(x => x.OpenTime).HasColumnType("DATE");
            builder.Property(x => x.Total).HasColumnType("DECIMAL");
        }
    }
}
