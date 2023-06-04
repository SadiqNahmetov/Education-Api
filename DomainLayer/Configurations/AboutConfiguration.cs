using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Configurations
{
    public class AboutConfiguration : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.Property(a => a.Image).IsRequired();
            builder.Property(a => a.Title).IsRequired().HasMaxLength(50);
            builder.Property(a => a.Description).IsRequired().HasMaxLength(800);
            builder.Property(a => a.SoftDeleted).HasDefaultValue(false);
            builder.Property(a => a.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(a => a.UpdateDate).HasDefaultValue(DateTime.Now);
        }
    }
}
