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
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder
               .ToTable("Project")
               .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .HasColumnName("ProjectId");

            builder
                .Property(c => c.Name)
                .HasColumnName("Name")
                .HasMaxLength(50);

            builder
                .Property(c => c.StartedDate)
                .HasColumnName("StartedDate")
                .HasMaxLength(7);
        }
    }
}
