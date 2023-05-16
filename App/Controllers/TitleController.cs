using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Title;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class TitleController : AppController
    {
        private readonly ITitleService _titleService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public TitleController(ITitleService titleService, IWebHostEnvironment webHostEnvironment)
        {
            _titleService = titleService;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TitleCreateDto titleCreateDto)
        {
            await _titleService.CreateAsync(titleCreateDto);

            return Ok();
        }


        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _titleService.GetAsync(id);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result  = await _titleService.GetAllAsync();
            return Ok(result);
        }

        [HttpPut, Route("{id}")]
        public async Task<IActionResult> Update([Required][FromRoute]int id, TitleUpdateDto titleUpdateDto)
        {
            try
            {
                await _titleService.UpdateAsync(id, titleUpdateDto);

                return Ok();
            }
            catch (NullReferenceException)
            {

                return NotFound();
            }
        }

        [HttpDelete]
       public async Task<IActionResult> Delete([Required]int id)
        {
            await _titleService.DeleteAsync(id);

            return Ok();
        }
    }
}
