using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Slider;
using ServiceLayer.Services.Implementations;
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
        public async Task<IActionResult> Create([FromForm] SliderCreateDto sliderCreateDto)
        {

            try
            {
                await _sliderService.CreateAsync(sliderCreateDto);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest(new { ErrorMessage = "Not Created" });
            }


        }

        [HttpGet]
        public async Task<IActionResult> GetById([Required] int id)
        {
            try
            {
                return Ok(await _sliderService.GetAsync(id));
            }
            catch (Exception)
            {
                return NotFound("Please enter a valid Id!");
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _sliderService.GetAllAsync());
            }
            catch (Exception)
            {
                return NotFound("No records found!");
            }
        }

     
        [HttpPut, Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, [FromForm] SliderUpdateDto sliderUpdateDto)
        {
            try
            {
                await _sliderService.UpdateAsync(id, sliderUpdateDto);

                return Ok(sliderUpdateDto);
            }
            catch (Exception)
            {

                return BadRequest(new { ErrorMessage = "Not Updated" });
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([Required] int id)
        {
            try
            {
                await _sliderService.DeleteAsync(id);

                return Ok();
            }
            catch (NullReferenceException)
            {

                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> SoftDelete([Required] int id)
        {
            try
            {
                await _sliderService.SoftDeleteAsync(id);

                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }
    }
}
