using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Course;
using ServiceLayer.Services.Implementations;
using ServiceLayer.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace App.Controllers
{
    public class CourseController : AppController
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }




        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CourseCreateDto courseCreateDto)
        {
            try
            {
                await _courseService.CreateAsync(courseCreateDto);

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
                return Ok(await _courseService.GetAsync(id));
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
                return Ok(await _courseService.GetAllAsync());
            }
            catch (Exception)
            {
                return NotFound("No information found!");
            }
        }



        [HttpGet]
        public async Task<IActionResult> Search([Required] string search)
        {
            try
            {
                return Ok(await _courseService.SearchAsync(search));
            }
            catch (NullReferenceException)
            {
                return NotFound("The word you were looking for was not found!");
            }
        }



        [HttpPut, Route("{id}")]
        public async Task<IActionResult> Update([FromRoute][Required] int id, [FromForm] CourseUpdateDto courseUpdateDto)
        {
            try
            {
                await _courseService.UpdateAsync(id, courseUpdateDto);

                return Ok();
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
                await _courseService.DeleteAsync(id);

                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }
    }
}
