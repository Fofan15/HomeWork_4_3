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
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder
               .ToTable("Title")
               .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .HasColumnName("TitleId");

            builder
                .Property(c => c.Name)
                .HasColumnName("Name")
                .HasMaxLength(50);
        }
    }
}
