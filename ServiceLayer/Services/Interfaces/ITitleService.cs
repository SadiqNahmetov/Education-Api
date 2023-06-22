using ServiceLayer.DTOs.Title;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ITitleService
    {
        Task<List<TitleListDto>> GetAllAsync();

        Task<TitleDto> GetAsync(int id);

        Task CreateAsync(TitleCreateDto titleCreate);

        Task UpdateAsync(int id, TitleUpdateDto titleUpdate);

        Task DeleteAsync(int id);

        Task SoftDeleteAsync(int id);

    }
}
