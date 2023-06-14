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
            private readonly DbSet<Author> _authors;
            public AuthorRepository(AppDbContext context) : base(context)
            {
                _context = context;
                _authors = _context.Set<Author>();
            }

            public async Task<List<Author>> GetAllWithCoursesAsync()
            {
                var authors = await _authors
                    .Where(a => !a.isDeleted)
                    .Include("CourseAuthors")
                    .Include("CourseAuthors.Course")
                    .ToListAsync();

                return authors;
            }
        }
}
