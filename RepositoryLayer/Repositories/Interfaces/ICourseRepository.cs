using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface ICourseRepository : IRepository<Course> 
    {
        Task<Course> GetWithAuthorsAndStudentsAsync(int id);

        Task<List<Course>> GetAllWithAuthorsAndStudentsAsync();
        
    }
}
