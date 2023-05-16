using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Services.Interfaces;

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


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _headerService.GetAllAsync();

            return Ok(result);
        }

        

    }
}
