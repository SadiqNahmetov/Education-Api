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
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(m => m.Image).IsRequired();
            builder.Property(m => m.Name).IsRequired().HasMaxLength(250);
            builder.Property(m => m.Description).IsRequired().HasMaxLength(500);
            builder.Property(m => m.Price).IsRequired().HasPrecision(18, 2);
            builder.Property(m => m.SoftDeleted).HasDefaultValue(false);
        }
    }
}
