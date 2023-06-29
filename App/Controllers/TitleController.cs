using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Title;
using ServiceLayer.Services.Implementations;
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
            try
            {
                await _titleService.CreateAsync(titleCreateDto);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest(new { ErrorMessage = "Not Created" });
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(await _titleService.GetAsync(id));
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
                return Ok(await _titleService.GetAllAsync());
            }
            catch (Exception)
            {
                return NotFound("No records found!");
            }
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
            try
            {
                await _titleService.DeleteAsync(id);

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
                await _titleService.SoftDeleteAsync(id);

                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }
    }
}
