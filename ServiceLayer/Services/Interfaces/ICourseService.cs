using ServiceLayer.DTOs.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ICourseService
    {
        Task<CourseDto> GetAsync(int id);
        Task<List<CourseListDto>> GetAllAsync();
        Task CreateAsync(CourseCreateDto courseCreateDto);
        Task UpdateAsync(int id, CourseUpdateDto courseUpdateDto);
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);


        Task<List<CourseListDto>> SearchAsync(string searchText);
    }
}
