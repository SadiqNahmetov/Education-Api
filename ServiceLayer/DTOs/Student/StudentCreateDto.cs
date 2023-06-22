using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Student
{
    public class StudentCreateDto
    {
        public IFormFile? Photo { get; set; }
        public string? FullName { get; set; }
        public int Age { get; set; }
        public string? Info { get; set; }
        public int CourseId { get; set; }
    }
}
