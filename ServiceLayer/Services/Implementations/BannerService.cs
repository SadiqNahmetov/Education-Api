using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Banner;
using ServiceLayer.DTOs.Header;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class BannerService : IBannerService
    {
        private readonly IBannerRepository _repo;
        private readonly IMapper _mapper;
        public BannerService(IBannerRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(BannerCreateDto bannerCreateDto)
        {
            if (!await _repo.IsExsist(m => m.Title == bannerCreateDto.Title))
            {
                var mapData = _mapper.Map<Banner>(bannerCreateDto);

                await _repo.CreateAsync(mapData);
            }
            else
            {
                throw new Exception("Banner is alerdy exsist");
            }
        }

 

        public async Task<List<BannerListDto>> GetAllAsync()
        {
            var model = await _repo.GetAllAsync();

            var result = _mapper.Map<List<BannerListDto>>(model);

            return result;
        }

        public async Task<BannerDto> GetAsync(int id)
        {
            var model = await _repo.GetAsync(id);

            var result = _mapper.Map<BannerDto>(model);

            return result;
        }

        public async Task UpdateAsync(int id, BannerUpdateDto bannerUpdateDto)
        {
            var dbBaner = await _repo.GetAsync(id);

            _mapper.Map(bannerUpdateDto, dbBaner);

            await _repo.UpdateAsync(dbBaner);
        }
        public async Task DeleteAsync(int id)
        {
            var slider = await _repo.GetAsync(id);

            await _repo.DeleteAsync(slider);
        }
    }
}
