using ServiceLayer.DTOs.Slider;


namespace ServiceLayer.Services.Interfaces
{
    public interface ISliderService
    {
        Task CreateAsync(SliderCreateDto slider);
        Task< List<SliderListDto>> GetAllAsync();   
        Task< SliderDto> GetAsync(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, SliderUpdateDto slider);
        
    }
}
