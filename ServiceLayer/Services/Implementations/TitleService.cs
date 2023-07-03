using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Implementations;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Title;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class TitleService : ITitleService
    {

        private readonly ITitleRepository _repo;

        private readonly IMapper _mapper;

        public TitleService(ITitleRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(TitleCreateDto titleCreate)
        {
            if (! await _repo.IsExsist(m=>m.Name == titleCreate.Name))
            {
                await _repo.CreateAsync(_mapper.Map<Title>(titleCreate));
            }
            else
            {
                throw new Exception("Title is alerdy exsist");
            }
        }


        public async Task<List<TitleListDto>> GetAllAsync()
        {
            var model = await _repo.GetAllAsync();

            var mapData = _mapper.Map<List<TitleListDto>>(model);

            return mapData;

        }

        public async Task<TitleDto> GetAsync(int id)
        {
            var model = await _repo.GetAsync(id);
            var res = _mapper.Map<TitleDto>(model);

            return res;
        }

        public async Task UpdateAsync(int id, TitleUpdateDto titleUpdate)
        {
            var dbTitle = await _repo.GetAsync(id); 

            _mapper.Map(titleUpdate, dbTitle);

            await _repo.UpdateAsync(dbTitle);
        }

        public async Task DeleteAsync(int id)
        {
            var title = await _repo.GetAsync(id);

            await _repo.DeleteAsync(title);
        }

        public async Task SoftDeleteAsync(int id)
        {
            await _repo.SoftDelete(await _repo.GetAsync(id));
        }

    }
}
