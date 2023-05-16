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
    public class HeaderConfiguration : IEntityTypeConfiguration<Header>
    {
        public void Configure(EntityTypeBuilder<Header> builder)
        {
            builder.Property(m => m.Image).IsRequired();
            builder.Property(m => m.Title).IsRequired().HasMaxLength(100);
            builder.Property(m => m.SoftDeleted).HasDefaultValue(false);
            builder.Property(m => m.CreateDate).HasDefaultValue(DateTime.UtcNow);
            builder.Property(m => m.UpdateDate).HasDefaultValue(DateTime.UtcNow);

        }
    }
}
