using ServiceLayer.DTOs.Banner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IBannerService
    {
        Task<List<BannerListDto>> GetAllAsync();
        Task<BannerDto> GetAsync(int id);
        Task CreateAsync(BannerCreateDto bannerCreateDto);
        Task UpdateAsync(int id ,BannerUpdateDto bannerUpdateDto);
        Task DeleteAsync(int id);
        Task SoftDeleteAsync(int id);

    }
}
