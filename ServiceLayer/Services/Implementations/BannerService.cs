using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.About;
using ServiceLayer.DTOs.Banner;
using ServiceLayer.DTOs.Header;
using ServiceLayer.Helpers;
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
                var mapBanner = _mapper.Map<Banner>(bannerCreateDto);

                mapBanner.Image = await bannerCreateDto.Photo.GetBytes();

                await _repo.CreateAsync(mapBanner);

            }
            else
            {
                throw new Exception("Banner is alerdy exsist");
            }
        }

 

        public async Task<List<BannerListDto>> GetAllAsync()
        {
            return _mapper.Map<List<BannerListDto>>(await _repo.GetAllAsync());
        }

        public async Task<BannerDto> GetAsync(int id)
        {
            return _mapper.Map<BannerDto>(await _repo.GetAsync(id));
        }

        public async Task UpdateAsync(int id, BannerUpdateDto bannerUpdateDto)
        {
            var dbBaner = await _repo.GetAsync(id);

            var mapAbout = _mapper.Map(bannerUpdateDto, dbBaner);

            mapAbout.Image = await bannerUpdateDto.Photo.GetBytes();

            await _repo.UpdateAsync(dbBaner);


        }
        public async Task DeleteAsync(int id)
        {
            await _repo.DeleteAsync(await _repo.GetAsync(id));
        }
    }
}
