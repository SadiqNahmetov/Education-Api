using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.About;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class AboutService : IAboutService
    {
        private readonly IAboutRepository _repo;
        private readonly IMapper _mapper;

        public AboutService(IAboutRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(AboutCreateDto aboutCreateDto)
        {
            if (!await _repo.IsExsist(a => a.Title == aboutCreateDto.Title))
            {
                await _repo.CreateAsync(_mapper.Map<About>(aboutCreateDto));
            }
            else
            {
                throw new Exception("About is already exsist");
            }
        }

    

        public async Task<List<AboutListDto>> GetAllAsync()
        {
            return _mapper.Map<List<AboutListDto>>(await _repo.GetAllAsync());
        }

        public async Task<AboutDto> GetAsync(int id)
        {
            return _mapper.Map<AboutDto>(await _repo.GetAsync(id));
        }

        public async Task UpdateAsync(int id, AboutUpdateDto aboutUpdateDto)
        {
            var dbAbout = await _repo.GetAsync(id);

            _mapper.Map(aboutUpdateDto, dbAbout);

            await _repo.UpdateAsync(dbAbout);

        }

        public async Task DeleteAsync(int id)
        {
            await _repo.DeleteAsync(await _repo.GetAsync(id));
        }
    }
}
