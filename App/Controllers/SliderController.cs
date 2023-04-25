using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Product;
using ServiceLayer.Services.Interfaces;

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




        //[HttpPost]
        //public async Task<IActionResult> Create([FromForm] SliderCreateDto slider, [FromForm] IFormFile file)
        //{
        //    // Get the file name and extension
        //    var fileName = file.FileName;
        //    var fileExtension = Path.GetExtension(fileName);

        //    // Save the file to the server
        //    var filePath = Path.Combine(_env.WebRootPath, "images", fileName);
        //    using (var stream = new FileStream(filePath, FileMode.Create))
        //    {
        //        await file.CopyToAsync(stream);
        //    }

        //    // Use ImageProcessing or other library to create the image
        //    // ...

        //    await _sliderService.CreateAsync(slider);
        //    return Ok();
        //}

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _sliderService.GetAllAsync();
            return Ok(result);
        }

    }
}
