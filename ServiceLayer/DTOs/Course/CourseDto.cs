using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Course
{
    public class CourseDto
    {
        public byte[]? Image { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }

        public List<string>? AuthorName { get; set; }
        public List<string>? StudentFullName { get; set; }
      
    }
}
