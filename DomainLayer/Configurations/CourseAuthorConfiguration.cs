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
    public class CourseAuthorConfiguration : IEntityTypeConfiguration<CourseAuthor>
    {
        public void Configure(EntityTypeBuilder<CourseAuthor> builder)
        {
            builder.Property(ca => ca.CourseId).IsRequired();
            builder.Property(ca => ca.AuthorId).IsRequired();
            builder.Property(ca => ca.SoftDeleted).HasDefaultValue(false);
        }
    }
}
