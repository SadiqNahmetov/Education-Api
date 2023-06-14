using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Author;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class AuthorController : AppController
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }



        [HttpPost]
        public async Task<IActionResult> Create( [FromForm]AuthorCreateDto authorCreateDto)
        {
            try
            {
                await _authorService.CreateAsync(authorCreateDto);

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
                return Ok(await _authorService.GetAsync(id));
            }
            catch (Exception)
            {
                return NotFound("Please enter a valid Id!");
            }
        }
    }
}
