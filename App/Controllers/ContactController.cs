using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Banner;
using ServiceLayer.DTOs.Contact;
using ServiceLayer.Services.Implementations;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.Vakidations.Contact;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class ContactController : AppController
    {
        private readonly IContactService _contactService;


        public ContactController(IWebHostEnvironment env, IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(await _contactService.GetAllAsync());
            }
            catch (NullReferenceException)
            {

                return NotFound();
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetById([Required] int id)
        {
            try
            {
                return Ok(await _contactService.GetAsync(id));
            }
            catch (NullReferenceException)
            {

                return NotFound();
            }
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ContactCreateDto contactCreateDto)
        {
            ContactCreateDtoValidator validator = new();
            var validationResult = validator.Validate(contactCreateDto);

            if (!validationResult.IsValid)
            {
                return BadRequest(new { ErrorMessage = "Error! Please enter valid data." });
            }

            try
            {
                await _contactService.CreateAsync(contactCreateDto);

                return Ok();
            }
            catch (NullReferenceException)
            {
                return BadRequest(new { ErrorMessage = "Not Created" });
            }
        }

        [HttpPut, Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, ContactUpdateDto contactUpdateDto)
        {
            ContactUpdateDtoValidator validator = new();
            var validationResult = validator.Validate(contactUpdateDto);

            if (!validationResult.IsValid)
            {
                return BadRequest(new { ErrorMessage = "Error! Please enter valid data." });
            }
            try
            {
                await _contactService.UpdateAsync(id, contactUpdateDto);

                return Ok();
            }
            catch (Exception)
            {
                return BadRequest(new { ErrorMessage = "Not Updated" });
            }
        }

    }
}
