using DomainLayer.Entities;
using RepositoryLayer.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<Student> GetWithCoursesAsync(int id);
        Task<List<Student>> GetAllWithCoursesAsync();
    }
}
