using DomainLayer.Entities;
using RepositoryLayer.Data;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Imlementations
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext context) : base(context)
        {
        }
    }
}
