using DomainLayer.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Author
{
    public class AuthorUpdateDto
    {
        public IFormFile? Photo { get; set; }

        public string? Name { get; set; }

        public string? Position { get; set; }

        public ICollection<CourseAuthor>? CourseAuthors { get; set; }
    }
}
