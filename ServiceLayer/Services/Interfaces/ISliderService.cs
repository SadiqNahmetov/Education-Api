using ServiceLayer.DTOs.Slider;


namespace ServiceLayer.Services.Interfaces
{
    public interface ISliderService
    {
        Task< List<SliderListDto>> GetAllAsync();   
        Task< SliderDto> GetAsync(int id);

        Task CreateAsync(SliderCreateDto slider);

        Task UpdateAsync(int id, SliderUpdateDto slider);
        Task DeleteAsync(int id);


    }
}
