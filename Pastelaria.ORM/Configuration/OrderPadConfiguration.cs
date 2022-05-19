using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pastelaria.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pastelaria.ORM.Configuration
{
    public class OrderPadConfiguration : IEntityTypeConfiguration<OrderPad>
    {
        public void Configure(EntityTypeBuilder<OrderPad> builder)
        {
            builder.ToTable("TBORDERPAD");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Costumer);
            builder.HasOne(x => x.Employee);
            builder.HasMany(x => x.Products).WithMany(x => x.);

            builder.Property(x => x.OrderPadStatus).HasColumnType("INT");
            builder.Property(x => x.OrderPadPaymentStatus).HasColumnType("INT");
            builder.Property(x => x.OpenTime).HasColumnType("DATE");
        }
    }
}
