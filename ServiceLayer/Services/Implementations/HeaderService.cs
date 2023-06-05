﻿using AutoMapper;
using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.Header;
using ServiceLayer.DTOs.Slider;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Implementations
{
    public class HeaderService : IHeaderService
    {
        private readonly IHeaderRepository _repo;
        private readonly IMapper _mapper;

     

        public HeaderService(IHeaderRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        public async Task CreateAsync(HeaderCreateDto headerCreateDto)
        {
           if (! await _repo.IsExsist(m=>m.Title == headerCreateDto.Title)) 
            {
                var mapData = _mapper.Map<Header>(headerCreateDto);

                await _repo.CreateAsync(mapData);
            }
            else
            {
                throw new Exception("Header is alerdy exsist");
            }
        }

    

        public async Task<List<HeaderListDto>> GetAllAsync()
        {

            var result = _mapper.Map<List<HeaderListDto>>(await _repo.GetAllAsync());

            return result;
        }

        public async Task<HeaderDto> GetAsync(int id)
        {
            
            var result = _mapper.Map<HeaderDto>(await _repo.GetAsync(id));

            return result;
        }

        public async Task UpdateAsync(int id, HeaderUpdateDto headerUpdateDto)
        {
           var dbHeader = await _repo.GetAsync(id);

            _mapper.Map(headerUpdateDto, dbHeader);

            await _repo.UpdateAsync(dbHeader);

        }

        public async Task DeleteAsync(int id)
        {
            await _repo.DeleteAsync(await _repo.GetAsync(id));
        }
    }
}
