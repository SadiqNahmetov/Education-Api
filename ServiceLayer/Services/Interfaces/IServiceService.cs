using ServiceLayer.DTOs.Banner;
using ServiceLayer.DTOs.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IServiceService
    {
        Task<List<ServiceListDto>> GetAllAsync();
        Task<ServiceDto> GetAsync(int id);
        Task CreateAsync(ServiceCreateDto serviceCreateDto);
        Task UpdateAsync(int id, ServiceUpdateDto serviceUpdateDto);
        Task DeleteAsync(int id);


    }
}
