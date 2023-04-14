using CodeHomeWork_4_3.DB_Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_4_3.Configurations
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder
               .ToTable("Office")
               .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .HasColumnName("OfficeId");

            builder
                .Property(c => c.Title)
                .HasColumnName("Title")
                .HasMaxLength(100);

            builder
                 .Property(c => c.Location)
                 .HasColumnName("Location")
                 .HasMaxLength(100);
        }
    }
}
