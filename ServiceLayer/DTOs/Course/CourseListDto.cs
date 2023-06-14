using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Course
{
    public class CourseListDto
    {
         public int Id { get; set; }
        public byte[]? Image { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public List<string>? StudentFullName { get; set; }
        public List<string>? AuthorName { get; set; }
    }
}
