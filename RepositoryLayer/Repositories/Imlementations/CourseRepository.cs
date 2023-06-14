using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Imlementations
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Course> _courses;

        public CourseRepository(AppDbContext context) : base(context)
        {
            _context = context;
            _courses = _context.Set<Course>();
        }

        public async Task<Course> GetWithAuthorsAndStudentsAsync(int id)
        {
            var course = await _courses
              .Where(a => !a.isDeleted)
              .Include("Students")
              .Include("CourseAuthors")
              .Include("CourseAuthors.Author")
              .FirstOrDefaultAsync(c => c.Id == id);

            return course;
        }

        public async Task<List<Course>> GetAllWithAuthorsAndStudentsAsync()
        {
            var courses = await _courses
                 .Where(c => !c.isDeleted)
                 .Include("Students")
                 .Include("CourseAuthors")
                 .Include("CourseAuthors.Author")
                 .ToListAsync();
            return courses;
        }
    }
}
