using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTOs.Product;
using ServiceLayer.DTOs.Slider;
using ServiceLayer.DTOs.Title;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Slider, SliderCreateDto>();
            CreateMap<Slider, SliderListDto>();
            CreateMap<Title, TitleDto>();
        }
    }
}
