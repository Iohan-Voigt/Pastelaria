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
    public class ProcessingProductConfiguration : IEntityTypeConfiguration<ProcessingProduct>
    {     
        public void Configure(EntityTypeBuilder<ProcessingProduct> builder)
        {
            builder.ToTable("PROCESSING.PRODUCT");

            builder.HasKey(x => x.Id);            

            builder.Property(p => p.Name).HasColumnType("VARCHAR(75)").IsRequired();
            builder.Property(p => p.Value).HasColumnType("DECIMAL(25,2)").IsRequired();
            builder.Property(p => p.Description).HasColumnType("VARCHAR(100)");

            builder.HasOne(p => p.OrderPad).WithMany(p => p.ProcessingProducts);
        }
        
    }
}
