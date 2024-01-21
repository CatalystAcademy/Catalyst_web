using Catalyst_web.Infrastructure.Persistence;
using Catalyst_web.Interfaces;
using Catalyst_web.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Catalyst_web.Controllers
{
    [EnableCors("AllowSpecificOrigin")]
    // [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ILocService _locService;

        public CoursesController(ApplicationDbContext dbContext, ILocService locService)
        {
            _dbContext = dbContext;
            _locService = locService;
        }

        [HttpGet("api/Courses")]
        public async Task<IActionResult> GetAllCourses()
        {
            return Ok(await _dbContext.Courses.ToListAsync());
        }

        [HttpGet("api/Courses/GetWelcomeMessage")]
        public IActionResult GetWelcomeMessage()
        {
            string welcomeMessage = _locService.Get("WelcomeMessage");

            return Ok(new { message = welcomeMessage });

        }

        [HttpGet("api/CourseDetails/{id}")]
        public async Task<IActionResult> GetCourseDetails(Guid id)
        {
            try
            {
                // Retrieve course data using the provided ID
                var course = await _dbContext.Courses.FindAsync(id);
                if (course == null)
                {
                    return NotFound(); // Handle case where course is not found
                }
                return Ok(course); // Return course data in JSON format
            }
            catch (Exception ex)
            {
                // Handle errors gracefully
                return StatusCode(500, "Error retrieving course details");
            }
        }

        // POST: Create a new course
        [HttpPost("api/Courses/Create")]
        public async Task<IActionResult> CreateCourse([FromBody] Course request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createCourse = new Course
            {
                Title = request.Title,
                Description = request.Description,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                ImageData = request.ImageData,
            };
            _dbContext.Courses.Add(createCourse);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("api/Courses/Register")]
        public async Task<IActionResult> RegisterForCourse([FromBody] RegisterForCourse request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // 2. Validate eligibility (check if user already registered)
            if (!IsUserEligibleForCourse(request.Id, request.CourseId))
            {
                return BadRequest("User is not eligible to register for this course.");
            }

            // 3. Enroll user in the course (this might involve creating a registration record or updating a join table)
            var courseRegistration = new RegisterForCourse
            {
                Id = request.Id, 
                CourseId = request.CourseId,
                Email = request.Email,
                Name = request.Name,
                PhoneNumber = request.PhoneNumber,
            };
            _dbContext.RegisterForCourses.Add(courseRegistration);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }

        private bool IsUserEligibleForCourse(Guid userId, Guid courseId)
        {
            // Check if user is already registered for the course
            var existingRegistration = _dbContext.RegisterForCourses
                .SingleOrDefault(r => r.Id == userId && r.CourseId == courseId);
            if (existingRegistration != null)
            {
                return false; // Already registered
            }

            return true; // User is eligible
        }
    }

}
