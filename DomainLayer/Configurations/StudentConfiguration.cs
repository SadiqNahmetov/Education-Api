using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(m => m.Image).IsRequired();
            builder.Property(m => m.FullName).IsRequired().HasMaxLength(50);
            builder.Property(m => m.Info).IsRequired().HasMaxLength(255);
            builder.Property(m => m.IsGraduated).IsRequired().HasDefaultValue(false);
            builder.Property(m => m.CourseId).IsRequired();
            builder.Property(m => m.Age).IsRequired();
        }
    }
}
