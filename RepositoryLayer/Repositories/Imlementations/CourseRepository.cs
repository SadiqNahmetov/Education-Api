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
        private readonly DbSet<CourseAuthor>_courseAuthors;


        public CourseRepository(AppDbContext context) : base(context)
        {
            _context = context;
            _courses = _context.Set<Course>();
            _courseAuthors = _context.Set<CourseAuthor>();


        }

        public async Task<Course> GetWithAuthorsAndStudentsAsync(int id)
        {
            var course = await _courses
              .Where(a => !a.isDeleted)
              //.Include("Students")
              .AsNoTracking()
              .Include("CourseAuthors")
              .Include("CourseAuthors.Author")
              .FirstOrDefaultAsync(c => c.Id == id) ?? throw new NullReferenceException(); 

            return course;
        }

        public async Task<List<Course>> GetAllWithAuthorsAndStudentsAsync()
        {
            var courses = await _courses
                 .Where(c => !c.isDeleted)
                 //.Include("Students")
                 .Include("CourseAuthors")
                 .Include("CourseAuthors.Author")
                 .ToListAsync();
            return courses;
        }

        public async Task DeleteCartAuthor(List<CourseAuthor> courseAuthors)
        {
            foreach (var item in courseAuthors)
            {
               _courseAuthors.Remove(item);
            }

            await _context.SaveChangesAsync();
        }




        //public async Task<List<Course>> GetAllCartAuthor()
        //{
        //    var data = await _courses
        //        .Where(a => !a.SoftDeleted)
        //        .Include(x => x.CourseAuthors)
        //        .ThenInclude(x => x.Author)
        //        .ToListAsync();
        //    return data;
        //}



        //public async Task<Course> GetByIdCartAuthor(int id)
        //{
        //    var data = await _courses
        //    .Where(a => !a.SoftDeleted)
        //    .Include(x => x.CourseAuthors)
        //    .ThenInclude(x => x.Author)
        //    .AsNoTracking()
        //    .FirstOrDefaultAsync(x => x.Id == id) ?? throw new NullReferenceException();
        //    return data;
        //}
    }
}
