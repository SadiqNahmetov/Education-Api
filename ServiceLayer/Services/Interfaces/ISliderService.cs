using ServiceLayer.DTOs.Product;
using ServiceLayer.DTOs.Slider;


namespace ServiceLayer.Services.Interfaces
{
    public interface ISliderService
    {
        Task CreateAsync(SliderCreateDto slider);
        Task< List<SliderListDto>> GetAllAsync();   
        Task< SliderListDto> GetAsync(int id);
        
    }
}
