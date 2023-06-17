using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Author
{
    public class AuthorDto
    {
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Position { get; set; }
        public List<string>? CourseName { get; set; }
        public List<CourseAuthor>? CourseAuthors { get; set; }
    }
}
