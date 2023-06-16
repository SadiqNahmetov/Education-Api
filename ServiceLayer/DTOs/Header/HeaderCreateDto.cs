using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Header
{
    public class HeaderCreateDto
    {
        public IFormFile? Photo { get; set; }


        public string? Title { get; set; }
    }
}
