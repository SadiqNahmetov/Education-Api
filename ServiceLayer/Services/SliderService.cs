using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Product;
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
            var mapData = _mapper.Map<Slider>(slider);
            await _repo.Create(mapData);
        }

        public async Task<List<SliderCreateDto>> GetAllAsync()
        {
           var model = await _repo.GetAll();
           var result = _mapper.Map<List<SliderCreateDto>>(model);
            return result;
        }
    }
}
