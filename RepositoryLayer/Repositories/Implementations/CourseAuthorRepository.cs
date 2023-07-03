using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Implementations
{
    public class CourseAuthorRepository : Repository<CourseAuthor>, ICourseAuthorRepository
    {
        public CourseAuthorRepository(AppDbContext context) : base(context)
        {
        }
        
    }
}
