using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Slider;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
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

        public async Task CreateAsync(SliderCreateDto sliderCreateDto)
        {
            if (!await _repo.IsExsist(m => m.Title == sliderCreateDto.Title))
            {
                var mapData = _mapper.Map<Slider>(sliderCreateDto);
                await _repo.CreateAsync(mapData);
            }
            else
            {
                throw new Exception("Slider is alerdy exsist");
            }


        }

        public async Task DeleteAsync(int id)
        {
            var slider = await _repo.GetAsync(id);

            await _repo.DeleteAsync(slider);
        }

        public async Task<List<SliderListDto>> GetAllAsync()
        {
            var model = await _repo.GetAllAsync();

            var result = _mapper.Map<List<SliderListDto>>(model);

            return result;
        }


        public async Task<SliderDto> GetAsync(int id)
        {
            var model = await _repo.GetAsync(id);

            var res = _mapper.Map<SliderDto>(model);

            return res;
        }

        public async Task UpdateAsync(int id, SliderUpdateDto sliderUpdateDto)
        {
            var dbSlider = await _repo.GetAsync(id);

            _mapper.Map(sliderUpdateDto, dbSlider);

            await _repo.UpdateAsync(dbSlider);
        }
    }
}
