using AutoMapper;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Title;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
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

        public async Task<List<TitleDto>> GetAllAsync()
        {
            var model = await _repo.GetAllAsync();

            var mapData = _mapper.Map<List<TitleDto>>(model);

            return mapData;

        }

        public async Task<TitleDto> GetAsync(int id)
        {
            var model = await _repo.GetAsync(id);
            var res = _mapper.Map<TitleDto>(model);

            return res;
        }

    }
}
