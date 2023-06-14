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
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
       

        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(m => m.Name).IsRequired().HasMaxLength(100);
            builder.Property(m => m.Message).IsRequired().HasMaxLength(500);
            builder.Property(m => m.Email).IsRequired().HasMaxLength(100);
        

        }
    }
}
