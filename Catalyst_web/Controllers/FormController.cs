using Catalyst_web.Infrastructure.Persistence;
using Catalyst_web.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using SendGrid.Helpers.Mail;
using System.Data;

namespace Catalyst_web.Controllers
{
    [EnableCors("AllowSpecificOrigin")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public FormController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }
        [HttpPost("api/Form/Submit")]
        public async Task<IActionResult> SubmitForm([FromBody] FormData request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var formData = new FormData { Email = request.Email, PhoneNumber = request?.PhoneNumber };

            _dbContext.FormDatas.Add(formData);
            await _dbContext.SaveChangesAsync();

            // Send a response back to the client
            return Ok(new { success = true, message = "Form submitted successfully" });
        }  
        
        [HttpPost("api/Contact/Submit")]
        public async Task<IActionResult> ContactForm([FromBody] Contact request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var contact = new Contact { Email = request.Email,  FullName = request.FullName, Message = request.Message };

            _dbContext.Contacts.Add(contact);
            await _dbContext.SaveChangesAsync();

            // Send a response back to the client
            return Ok();
        }

        [HttpPost("api/Visit/Submit")]
        public async Task<IActionResult> VisitForm([FromBody] Visit request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var visit = new Visit { 
                Email = request.Email,  
                Name = request.Name, 
                PhoneNumber = request.PhoneNumber ,
                AppointmentDate = request.AppointmentDate,
                AppointmentTime = request.AppointmentTime
            };

            _dbContext.Visits.Add(visit);
            await _dbContext.SaveChangesAsync();

            // Send a response back to the client
            return Ok();
        }

        [HttpPost("api/BecomeTeacher/Register")]
        public async Task<IActionResult> TeacherRegister([FromBody] BecomeTeacher request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            // 2. Validate eligibility (check if user already registered)
            if (!IsUserEligibleForCourse(request.Id, request.CurriculumId))
            {
                return BadRequest("User is not eligible to register for this course.");
            }

            var teacherRegistration = new BecomeTeacher
            {
                Id = request.Id,
                CurriculumId = request.CurriculumId,
                Email = request.Email,
                FullName = request.FullName,
                Message = request.Message,
                PhoneNumber = request.PhoneNumber
            };
            _dbContext.BecomeTeachers.Add(teacherRegistration);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }

        private bool IsUserEligibleForCourse(Guid userId, Guid curriculumId)
        {
            // Check if user is already registered for the course
            var existingRegistration = _dbContext.BecomeTeachers
                .SingleOrDefault(r => r.Id == userId && r.CurriculumId == curriculumId);
            if (existingRegistration != null)
            {
                return false; // Already registered
            }

            return true; // User is eligible
        }

    }

}
