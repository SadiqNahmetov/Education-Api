using ServiceLayer.DTOs.About;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IAboutService
    {
        Task<AboutDto> GetAsync(int id);
        Task<List<AboutListDto>> GetAllAsync();
        Task CreateAsync(AboutCreateDto aboutCreateDto);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, AboutUpdateDto aboutUpdateDto);
    }
}
