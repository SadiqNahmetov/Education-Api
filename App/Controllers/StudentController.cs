using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Student;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class StudentController : AppController
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }



        [HttpPost]
        public async Task<IActionResult> Create([FromForm] StudentCreateDto studentCreateDto)
        {
            try
            {
                await _studentService.CreateAsync(studentCreateDto);

                return Ok();
            }
            catch (NullReferenceException)
            {
                return BadRequest(new { ErrorMessage = "Not Created" });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetById([Required] int id)
        {
            try
            {
                var data = await _studentService.GetAsync(id);

                return Ok(data);
            }
            catch (Exception)
            {
                return NotFound("Please enter a valid Id!");
            }
        }
    }
}
