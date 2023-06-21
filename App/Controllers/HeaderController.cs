using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.DTOs.About;
using ServiceLayer.DTOs.Header;
using ServiceLayer.Services.Implementations;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class HeaderController : AppController
    {
        private readonly IHeaderService _headerService;
        private readonly IWebHostEnvironment _env;

        public HeaderController(IHeaderService headerService, IWebHostEnvironment env)
        {
            _headerService = headerService;
            _env = env;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm]HeaderCreateDto headerCreateDto)
        {
            await _headerService.CreateAsync(headerCreateDto);

             return Ok();
        }
    
        [HttpGet]
        public async Task<IActionResult> GetById([Required] int id)
        {
            var result = await _headerService.GetAsync(id);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _headerService.GetAllAsync();

            return Ok(result);
        }

        [HttpPut, Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, [FromForm] HeaderUpdateDto headerUpdateDto)
        {
            try
            {
                await _headerService.UpdateAsync(id, headerUpdateDto);

                return Ok(headerUpdateDto);
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
                await _headerService.DeleteAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            {

                return NotFound();
            }

        }
    









    }
}
