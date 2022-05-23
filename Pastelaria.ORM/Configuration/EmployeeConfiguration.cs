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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("DOMAIN.EMPLOYEE");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasColumnType("VARCHAR(75)").IsRequired();
            builder.Property(x => x.IdentityDocument).HasColumnType("VARCHAR(14)").IsRequired();
            builder.Property(x => x.PhoneNumber).HasColumnType("VARCHAR(20)").IsRequired();
            builder.Property(x => x.AcessUser).HasColumnType("VARCHAR(20)").IsRequired();
            builder.Property(x => x.Password).HasColumnType("VARCHAR(20)").IsRequired();
            builder.Property(x => x.Registration).HasColumnType("VARCHAR(30)").IsRequired();
            builder.Property(x => x.EmployeePermissionsEnum).HasColumnType("INT").IsRequired();
            builder.Property(x => x.EmployeeActiveEnum).HasColumnType("INT").IsRequired();

        }
    }
}
