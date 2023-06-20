using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Imlementations;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Imlementations
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
       
            private readonly AppDbContext _context;
            private readonly DbSet<Author> _author;
            private readonly DbSet<CourseAuthor> _courseAuthors;
        public AuthorRepository(AppDbContext context) : base(context)
            {
                _context = context;
                _author = _context.Set<Author>();
               _courseAuthors = _context.Set<CourseAuthor>();
        }

        public async Task<Author> GetWithCoursesAsync(int id)
        {
            var author = await _author
                .Where(a => !a.isDeleted)
                .Include("CourseAuthors")
                .Include("CourseAuthors.Course")
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.Id == id) ?? throw new NullReferenceException();

            return author;
        }


        public async Task<List<Author>> GetAllWithCoursesAsync()
        {
            var authors = await _author
                .Where(a => !a.isDeleted)
                .Include("CourseAuthors")
                .Include("CourseAuthors.Course")
                .ToListAsync();

            return authors;
        }

      
    }

}
