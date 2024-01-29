using Catalyst_web.Infrastructure.Persistence;
using Catalyst_web.Interfaces;
using Catalyst_web.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using Npgsql;
using Dapper;

namespace Catalyst_web.Controllers
{
    [EnableCors("AllowSpecificOrigin")]
    // [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public CoursesController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        [HttpGet("api/Courses")]
        public async Task<IActionResult> GetAllCourses()
        {
            return Ok(await _dbContext.Courses.ToListAsync());
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
                    TitleEng = request.TitleEng,
                    TitleArm = request.TitleArm,
                    DescriptionEng = request.DescriptionEng,
                    DescriptionArm = request.DescriptionArm,
                    StartDate = request.StartDate,
                    EndDate = request.EndDate,
                    ImageData = request.ImageData,
                };
                _dbContext.Courses.Add(createCourse);
                await _dbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("api/Courses/Edit/{id}")]
        public async Task<IActionResult> UpdateCourse(Guid id, [FromBody] Course editedCourse)
        {
            // 1. Validate ID and model existence
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Return bad request if model validation fails
            }
                var existingCourse = await _dbContext.Courses.FindAsync(id); // Find existing course

                if (existingCourse == null)
                {
                    return NotFound(); // Return not found if course doesn't exist
                }

                existingCourse.TitleEng = editedCourse.TitleEng;
                existingCourse.TitleArm = editedCourse.TitleArm;
                existingCourse.DescriptionEng = editedCourse.DescriptionEng;
                existingCourse.DescriptionArm = editedCourse.DescriptionArm;
                existingCourse.StartDate = editedCourse.StartDate;
                existingCourse.EndDate = editedCourse.EndDate;
                // existingCourse.ImageData = editedCourse.ImageData;

                _dbContext.Courses.Update(existingCourse);
                await _dbContext.SaveChangesAsync();

                return Ok(existingCourse);
            }

        [HttpDelete("api/Courses/{id}")]
        public async Task<IActionResult> DeleteCourse(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingCourse = await _dbContext.Courses.FindAsync(id);

            if (existingCourse == null)
            {
                return NotFound();
            }

            _dbContext.Courses.Remove(existingCourse);
            await _dbContext.SaveChangesAsync();

            return Ok(); // Return successful response
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
/*        using (var memoryStream = new MemoryStream())
        {
                var connectionString = _configuration.GetValue<string>("ConnectionStrings");
                await file.CopyToAsync(memoryStream);
                byte[] imageData = memoryStream.ToArray();
                // Use Dapper to insert the image data into the database
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    connection.Execute("INSERT INTO RegisterForCourse (ImageData) VALUES (@ImageData)",
                                        new { ImageData = memoryStream.ToArray() });
                }*/

            // 3. Enroll user in the course (this might involve creating a registration record or updating a join table)
            var courseRegistration = new RegisterForCourse
            {
                Id = request.Id,
                CourseId = request.CourseId,
                Email = request.Email,
                FullName = request.FullName,
                Message = request.Message,
                PhoneNumber = request.PhoneNumber,
                ParentPhoneNumber = request.ParentPhoneNumber,
                //ImageData = imageData,
            };
            _dbContext.RegisterForCourses.Add(courseRegistration);
            await _dbContext.SaveChangesAsync();

            const string emailContent = @"Hi {{UserName}},
                                Congratulations on registering for the {{CourseName}} course! 
                                We're excited to have you on board and eager to share the knowledge. Check out these resources to get started:
                                * Course homepage: [Course Link]
                                * Welcome video: [Video Link]
                                * Q&A forum: [Forum Link]
                                Don't hesitate to reach out if you have any questions. We're here to help you succeed!

                                Best regards,
                                The Catalyst Academy Team";

            var course = await _dbContext.Courses.FirstOrDefaultAsync(c => c.Id == request.CourseId);

            // Replace emailContent placeholders
            var personalizedContent = emailContent.Replace("{{UserName}}", courseRegistration.FullName)
                                                 .Replace("{{CourseName}}", course?.TitleEng);

            var sendGridApiKey = _configuration.GetValue<string>("SendGrid:sendgrid_api_key");

/*            var dynamicTemplateData = new Dictionary<string, string>()
                {
                    {"UserName", request.Name},
                    {"CourseName", "Web Development 101"},
                    {"CourseLink", "https://your-course-link.com"},
                    {"VideoLink", "https://your-welcome-video.com"},
                    {"ForumLink", "https://your-forum-link.com"},
                    {"unsubscribe", "https://your-unsubscribe-link.com"},
                    {"unsubscribe_preferences", "https://your-preferences-link.com"}
                };*/
            // var templateId = "d-a9963b3ed9ee452d805ef6ef8c2a09db"
            // 4. Send registration confirmation email using SendGrid
            try
            {
                var fromEmail = _configuration.GetValue<string>("SendGrid:FromEmail");

                var email = new SendGridMessage()
                {
                    From = new EmailAddress(fromEmail),
                    ReplyTo = new EmailAddress(request.Email),
                    Subject = "Welcome to the course!",
                    HtmlContent = personalizedContent
                };

                var client = new SendGridClient(sendGridApiKey); // Replace with your SendGrid API key
                await client.SendEmailAsync(email);

                // Email sent successfully
            }
            catch (Exception ex)
            {
                // Handle email sending error (log the error, potentially notify user)
                return StatusCode(500, ex);
            }

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
