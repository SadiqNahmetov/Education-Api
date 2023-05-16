using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Slider;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class SliderController : AppController
    {
        private readonly ISliderService _sliderService;
        private readonly IWebHostEnvironment _env;

        public SliderController(ISliderService sliderService, IWebHostEnvironment env)
        {
            _sliderService = sliderService;
            _env = env;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SliderCreateDto slider)
        {

            await _sliderService.CreateAsync(slider);
            return Ok();

          
        }

        [HttpGet]
        public async Task<IActionResult> GetById([Required] int id)
        {
            var result = await _sliderService.GetAsync(id);

            return Ok(result);
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _sliderService.GetAllAsync();
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([Required]int id)
        {
            await _sliderService.DeleteAsync(id);

            return Ok();
        }

        [HttpPut, Route("{id}")]
        public async Task<IActionResult> Update([Required][FromRoute] int id, SliderUpdateDto sliderUpdateDto)
        {
            try
            {
                await _sliderService.UpdateAsync(id, sliderUpdateDto);

                return Ok(sliderUpdateDto);
            }
            catch (NullReferenceException)
            {
                return NotFound();  
            }
        }

    }
}
