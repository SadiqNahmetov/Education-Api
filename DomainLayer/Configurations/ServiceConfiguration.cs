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
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.Property(m => m.Image).IsRequired();
            builder.Property(m => m.Name).IsRequired().HasMaxLength(100);
            builder.Property(m => m.Description).IsRequired().HasMaxLength(500);
        }
    }
}
