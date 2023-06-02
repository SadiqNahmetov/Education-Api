using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Banner;
using ServiceLayer.DTOs.Contact;
using ServiceLayer.Services.Implementations;
using ServiceLayer.Services.Interfaces;

namespace App.Controllers
{
    public class ContactController : AppController
    {
        private readonly IContactService _contactService;
        private readonly IWebHostEnvironment _env;

        public ContactController(IWebHostEnvironment env, IContactService contactService)
        {
            _env = env;
            _contactService = contactService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ContactCreateDto contactCreateDto)
        {
            await _contactService.CreateAsync(contactCreateDto);

            return Ok();
        }
    }
}
