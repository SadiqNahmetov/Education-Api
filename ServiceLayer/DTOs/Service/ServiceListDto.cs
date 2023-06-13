using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Service
{
    public class ServiceListDto
    {
        public int Id { get; set; }
        public byte[]? Image { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
