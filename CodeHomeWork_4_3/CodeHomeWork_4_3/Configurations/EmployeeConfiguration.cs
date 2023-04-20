using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using CodeHomeWork_4_3.DB_Models;

namespace CodeHomeWork_4_3.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
               .ToTable("Employee")
               .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .HasColumnName("EmployeeId");

            builder
                .Property(c => c.FirstName)
                .HasColumnName("FirstName")
                .HasMaxLength(50);

            builder
                .Property(c => c.LastName)
                .HasColumnName("LastName")
                .HasMaxLength(50);

            builder
                .Property(c => c.HiredDate)
                .HasColumnName("HiredDate")
                .HasMaxLength(7);
            
            builder
                .HasOne(b => b.Titles)
                .WithMany(x => x.Employees)
                .HasForeignKey(k => k.TitleId);

            builder
                .HasOne(b => b.Offices)
                .WithMany(x => x.Employees)
                .HasForeignKey(k => k.OfficeId);

        }
    }
}
