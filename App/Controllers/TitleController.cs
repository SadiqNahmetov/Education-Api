using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;

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

      
    }
}
