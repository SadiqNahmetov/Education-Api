using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Author :BaseEntity
    {
        public byte? Image { get; set; }

        public string? Name { get; set; }

        public string? Position { get; set; }

        public ICollection<CourseAuthor>? CourseAuthors { get; set; }




    }
}
