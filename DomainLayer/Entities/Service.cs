using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Service : BaseEntity
    {
        public byte[]? Image { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
