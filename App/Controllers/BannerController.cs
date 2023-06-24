using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Banner;
using ServiceLayer.DTOs.Header;
using ServiceLayer.Services.Implementations;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class BannerController : AppController
    {
        private readonly IBannerService _bannerService;
        private readonly IWebHostEnvironment _env;

        public BannerController(IBannerService bannerService, IWebHostEnvironment env)
        {
            _bannerService = bannerService;
            _env = env;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] BannerCreateDto bannerCreateDto)
        {
            await _bannerService.CreateAsync(bannerCreateDto);

            return Ok();
        }



        [HttpGet]
        public async Task<IActionResult> GetById([Required] int id)
        {
            var result = await _bannerService.GetAsync(id);

            return Ok(result);
        }




        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _bannerService.GetAllAsync();

            return Ok(result);
        }

        [HttpPut, Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, [FromForm] BannerUpdateDto bannerUpdateDto)
        {
            try
            {
                await _bannerService.UpdateAsync(id, bannerUpdateDto);

                return Ok(bannerUpdateDto);

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
                await _bannerService.DeleteAsync(id);

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
                await _bannerService.SoftDeleteAsync(id);

                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

    }
}
