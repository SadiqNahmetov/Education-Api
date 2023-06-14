using DomainLayer.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Author
{
    public class AuthorCreateDto
    {
        public IFormFile? Photo { get; set; }
        public string? FullName { get; set; }
        public string? Position { get; set; }
        public List<int>? CourseIds { get; set; }
    }
}
