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
    internal class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder
                .Property(p => p.Id)
                .HasColumnName("EmployeeProjectId");

            builder
               .Property(c => c.StartedDate)
               .HasColumnName("StartedDate")
               .HasMaxLength(7);
        }
    }
}
