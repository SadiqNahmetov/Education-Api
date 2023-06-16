using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Banner
{
    public class BannerCreateDto
    {
        public IFormFile? Photo { get; set; }


        public string? Title { get; set; }
    }
}
