using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Author
{
    public class AuthorListDto
    {
        public int Id { get; set; }
        public byte[]? Image { get; set; }

        public string? Name { get; set; }

        public string? Position { get; set; }
        public List<string>? CourseTitle { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }



 
    }
}
