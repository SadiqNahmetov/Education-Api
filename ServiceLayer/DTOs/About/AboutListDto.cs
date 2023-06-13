using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.About
{
    public class AboutListDto
    {
        public int Id { get; set; }
        public byte[]? Image { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
