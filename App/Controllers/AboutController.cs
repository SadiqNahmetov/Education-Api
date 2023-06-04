using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.About;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class AboutController : AppController
    {
        private readonly IAboutService _aboutService;
     

        public AboutController(IAboutService aboutService, IWebHostEnvironment env)
        {
            _aboutService = aboutService;
           
        }


        [HttpGet]
        public async Task<IActionResult> Get([Required] int id)
        {
            try
            {
                return Ok(await _aboutService.GetAsync(id));
            }
            catch (NullReferenceException)
            {

                return NotFound();
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _aboutService.GetAllAsync());
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }

        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AboutCreateDto aboutCreateDto)
        {
            await _aboutService.CreateAsync(aboutCreateDto);

            return Ok();
        }


        [HttpPut, Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, AboutUpdateDto aboutUpdateDto)
        {
            try
            {
                await _aboutService.UpdateAsync(id, aboutUpdateDto);

                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }


        [HttpDelete]
        public async Task<IActionResult> Delete([Required] int id)
        {
            try
            {
                await _aboutService.DeleteAsync(id);

                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }
    }
}
