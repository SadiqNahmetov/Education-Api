using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Product;
using ServiceLayer.DTOs.Slider;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class SliderService : ISliderService
    {

        private readonly ISliderRepository _repo;
        private readonly IMapper _mapper;

   

        public SliderService(ISliderRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(SliderCreateDto slider)
        {
            var model = _mapper.Map<Slider>(slider);
            await _repo.CreateAsync(model);
        }

        public async Task<List<SliderListDto>> GetAllAsync()
        {
           var model = await _repo.GetAllAsync();
           var result = _mapper.Map<List<SliderListDto>>(model);
            return result;
        }

        
        public async Task<SliderListDto> GetAsync(int id)
        {
            var model = await _repo.GetAsync(id);
            var res = _mapper.Map<SliderListDto>(model);
            return res;
        }
    }
}
