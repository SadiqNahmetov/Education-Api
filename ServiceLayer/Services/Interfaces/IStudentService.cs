using ServiceLayer.DTOs.Author;
using ServiceLayer.DTOs.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IStudentService
    {
        Task<StudentDto> GetAsync(int id);

        Task<List<StudentListDto>> GetAllAsync();

        Task CreateAsync(StudentCreateDto studentCreateDto);

        Task UpdateAsync(int id, StudentUpdateDto studentUpdateDto);

        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);
    }
}
