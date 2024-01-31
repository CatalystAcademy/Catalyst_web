using Catalyst_web.Infrastructure.Persistence;
using Catalyst_web.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Catalyst_web.Controllers
{
    [EnableCors("AllowSpecificOrigin")]
    // [Route("api/[controller]")]
    [ApiController]
    public class CurriculumsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public CurriculumsController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        [HttpGet("api/Curriculums")]
        public async Task<IActionResult> GetAllCurriculums()
        {
            return Ok(await _dbContext.Curriculums.ToListAsync());
        }

        [HttpGet("api/CurriculumDetails/{id}")]
        public async Task<IActionResult> GetCurriculumDetails(Guid id)
        {
            try
            {
                // Retrieve curriculum data using the provided ID
                var curriculum = await _dbContext.Curriculums.FindAsync(id);
                if (curriculum == null)
                {
                    return NotFound(); // Handle case where curriculum is not found
                }
                return Ok(curriculum); // Return curriculum data in JSON format
            }
            catch (Exception ex)
            {
                // Handle errors gracefully
                return StatusCode(500, "Error retrieving curriculum details");
            }
        }

        // POST: Create a new curriculum
        [HttpPost("api/Curriculums/Create")]
        public async Task<IActionResult> CreateCurriculum([FromBody] Curriculum request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createCurriculum = new Curriculum
            {
                TitleEng = request.TitleEng,
                TitleArm = request.TitleArm,
                DescriptionEng = request.DescriptionEng,
                DescriptionArm = request.DescriptionArm,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                RegistrationDate = new DateTime()
                };
                _dbContext.Curriculums.Add(createCurriculum);
                await _dbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("api/Curriculums/Edit/{id}")]
        public async Task<IActionResult> UpdateCurriculum(Guid id, [FromBody] Curriculum editedcurriculum)
        {
            // 1. Validate ID and model existence
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Return bad request if model validation fails
            }
                var existingCurriculum = await _dbContext.Curriculums.FindAsync(id); // Find existing curriculum

                if (existingCurriculum == null)
                {
                    return NotFound(); // Return not found if curriculum doesn't exist
                }

                    existingCurriculum.TitleEng = editedcurriculum.TitleEng;
                    existingCurriculum.TitleArm = editedcurriculum.TitleArm;
                    existingCurriculum.DescriptionEng = editedcurriculum.DescriptionEng;
                    existingCurriculum.DescriptionArm = editedcurriculum.DescriptionArm;
                    existingCurriculum.StartDate = editedcurriculum.StartDate;
                    existingCurriculum.EndDate = editedcurriculum.EndDate;

                _dbContext.Curriculums.Update(existingCurriculum);
                await _dbContext.SaveChangesAsync();

                return Ok(existingCurriculum);
            }

        [HttpDelete("api/Curriculums/{id}")]
        public async Task<IActionResult> DeleteCurriculum(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingCurriculum = await _dbContext.Curriculums.FindAsync(id);

            if (existingCurriculum == null)
            {
                return NotFound();
            }

            _dbContext.Curriculums.Remove(existingCurriculum);
            await _dbContext.SaveChangesAsync();

            return Ok(); // Return successful response
        }


        [HttpPost("api/Curriculums/Register")]
        public async Task<IActionResult> RegisterForCurriculum([FromBody] RegisterForCurriculum request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            // 2. Validate eligibility (check if user already registered)
            if (!IsUserEligibleForCurriculum(request.Id, request.CurriculumId))
            {
                return BadRequest("User is not eligible to register for this curriculum.");
            }

            var curriculumRegistration = new RegisterForCurriculum
            {
                Id = request.Id,
                CurriculumId = request.CurriculumId,
                Email = request.Email,
                FullName = request.FullName,
                Message = request.Message,
                PhoneNumber = request.PhoneNumber,
                ParentPhoneNumber = request.ParentPhoneNumber,
                Address = request.Address,
                EducationalInstitution = request.EducationalInstitution,
                ParentEmail = request.ParentEmail,
                ParentFullName = request.ParentFullName,
                ParentProfession = request.ParentProfession,
                DateOfBirth = request.DateOfBirth
            };
            _dbContext.RegisterForCurriculums.Add(curriculumRegistration);
            await _dbContext.SaveChangesAsync();

            const string emailContent = @"Hi {{UserName}},
                                Congratulations on registering for the {{curriculumName}} curriculum! 
                                We're excited to have you on board and eager to share the knowledge. Check out these resources to get started:
                                * curriculum homepage: [curriculum Link]
                                * Welcome video: [Video Link]
                                * Q&A forum: [Forum Link]
                                Don't hesitate to reach out if you have any questions. We're here to help you succeed!

                                Best regards,
                                The Catalyst Academy Team";

            var curriculum = await _dbContext.Curriculums.FirstOrDefaultAsync(c => c.Id == request.CurriculumId);

            // Replace emailContent placeholders
            var personalizedContent = emailContent.Replace("{{UserName}}", curriculumRegistration.FullName)
                                                 .Replace("{{curriculumName}}", curriculum?.TitleEng);

            var sendGridApiKey = _configuration.GetValue<string>("SendGrid:sendgrid_api_key");

            try
            {
                var fromEmail = _configuration.GetValue<string>("SendGrid:FromEmail");

                var email = new SendGridMessage()
                {
                    From = new EmailAddress(fromEmail),
                    ReplyTo = new EmailAddress(request.Email),
                    Subject = "Welcome to the curriculum!",
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

        private bool IsUserEligibleForCurriculum(Guid userId, Guid curriculumId)
        {
            // Check if user is already registered for the curriculum
            var existingRegistration = _dbContext.RegisterForCurriculums
                .SingleOrDefault(r => r.Id == userId && r.CurriculumId == curriculumId);
            if (existingRegistration != null)
            {
                return false; // Already registered
            }

            return true; // User is eligible
        }
    }

}
