using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalPortfolio.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolio.Data.Configurations
{
    public class ExperienceConfiguration : IEntityTypeConfiguration<Experience>
    {
        public void Configure(EntityTypeBuilder<Experience> builder)
        {
           builder.HasKey(x => x.Id);
           builder.Property(x=> x.Title).IsRequired().HasMaxLength(100);
           builder.Property(x=> x.Description).IsRequired().HasMaxLength(500);
           builder.Property(x=> x.StartDate).IsRequired();
        }
    }
}
