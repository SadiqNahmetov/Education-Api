using Microsoft.AspNetCore.Mvc;
using ServiceLayer.DTOs.Course;
using ServiceLayer.Services.Interfaces;

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
    }
}
