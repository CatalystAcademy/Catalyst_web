using Azure.Core;
using Catalyst_web.Infrastructure.Persistence;
using Catalyst_web.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Catalyst_web.Controllers
{
    [EnableCors("AllowSpecificOrigin")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        public TeachersController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet("api/Teachers")]
        public async Task<IActionResult> GetAllTeachers()
        {
            return Ok(await _dbContext.Teachers.Where(x => x.IsFromLeadership == false).ToListAsync());
        }
        [HttpPost("api/Teachers/Create")]
        public async Task<IActionResult> CreateTeacher([FromBody] Teacher request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createTeacher = new Teacher
            {
                FullNameArm = request.FullNameArm,
                FullNameEng = request.FullNameEng,
                DescriptionArm = request.DescriptionArm,
                DescriptionEng = request.DescriptionEng,
                Email = request.Email,
                ProfessionArm = request.ProfessionArm,
                ProfessionEng = request.ProfessionEng,
                IsFromLeadership = request.IsFromLeadership
            };
            _dbContext.Teachers.Add(createTeacher);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("api/Teacher/Edit/{id}")]
        public async Task<IActionResult> UpdateTeacher(Guid id, [FromBody] Teacher editedTeacher)
        {
            // 1. Validate ID and model existence
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Return bad request if model validation fails
            }
            var existingTeacher = await _dbContext.Teachers.FindAsync(id);

            if (existingTeacher == null)
            {
                return NotFound();
            }

            existingTeacher.FullNameArm = editedTeacher.FullNameArm;
            existingTeacher.FullNameEng = editedTeacher.FullNameEng;
            existingTeacher.DescriptionEng = editedTeacher.DescriptionEng;
            existingTeacher.DescriptionArm = editedTeacher.DescriptionArm;
            existingTeacher.ProfessionArm = editedTeacher.ProfessionArm;
            existingTeacher.ProfessionEng = editedTeacher.ProfessionEng;
            existingTeacher.Email = editedTeacher.Email;
            existingTeacher.IsFromLeadership = editedTeacher.IsFromLeadership;

            _dbContext.Teachers.Update(existingTeacher);
            await _dbContext.SaveChangesAsync();

            return Ok(existingTeacher);
        }
        [HttpGet("api/TeacherDetails/{id}")]
        public async Task<IActionResult> GetTeacherDetails(Guid id)
        {
            try
            {
                var teacher = await _dbContext.Teachers.FindAsync(id);
                if (teacher == null)
                {
                    return NotFound();
                }
                return Ok(teacher); 
            }
            catch (Exception ex)
            {
                // Handle errors gracefully
                return StatusCode(500, "Error retrieving teacher details");
            }
        }
        [HttpDelete("api/Teacher/{id}")]
        public async Task<IActionResult> DeleteTeacher(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var existingTeacher = await _dbContext.Teachers.FindAsync(id);
            if (existingTeacher == null)
            {
                return NotFound();
            }
            _dbContext.Teachers.Remove(existingTeacher);
            await _dbContext.SaveChangesAsync();
            return Ok(); 
        }

        [HttpGet("api/Leaders")]
        public async Task<IActionResult> GetAllLeaders()
        {
            var leaders = await _dbContext.Teachers.Where(x => x.IsFromLeadership == true).ToListAsync();

            return Ok(leaders);
            
        }
    }
}
