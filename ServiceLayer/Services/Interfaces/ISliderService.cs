using ServiceLayer.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface ISliderService
    {
        Task CreateAsync(SliderCreateDto slider);
        Task< List<SliderCreateDto>> GetAllAsync();
        
    }
}
