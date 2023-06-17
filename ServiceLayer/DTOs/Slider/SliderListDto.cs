using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Slider
{
    public class SliderListDto
    {
        public int Id { get; set; } 
        public string? Title { get; set; }
        public string? Image { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
