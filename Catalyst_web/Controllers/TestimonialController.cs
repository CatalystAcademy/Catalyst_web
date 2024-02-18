using Catalyst_web.Infrastructure.Persistence;
using Catalyst_web.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Catalyst_web.Controllers
{
    [EnableCors("AllowSpecificOrigin")]
    [ApiController]
    public class TestimonialController(ApplicationDbContext dbContext) : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext = dbContext;

        [HttpPost("api/Testimonials/Create")]
        public async Task<IActionResult> CreateTestimonial([FromBody] Testimonial request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createTestimonial = new Testimonial
            {
                FullNameArm = request.FullNameArm,
                FullNameEng = request.FullNameEng,
                PositionArm = request.PositionArm,
                PositionEng = request.PositionEng,
                TextArm = request.TextArm,
                TextEng = request.TextEng,
            };
            _dbContext.Testimonials.Add(createTestimonial);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("api/Testimonial/Edit/{id}")]
        public async Task<IActionResult> UpdateTestimonial(Guid id, [FromBody] Testimonial editedTestimonial)
        {
            // 1. Validate ID and model existence
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Return bad request if model validation fails
            }
            var existingTestimonial = await _dbContext.Testimonials.FindAsync(id);

            if (existingTestimonial == null)
            {
                return NotFound();
            }

            existingTestimonial.FullNameArm = editedTestimonial.FullNameArm;
            existingTestimonial.FullNameEng = editedTestimonial.FullNameEng;
            existingTestimonial.PositionArm = editedTestimonial.PositionArm;
            existingTestimonial.PositionEng = editedTestimonial.PositionEng;
            existingTestimonial.TextArm = editedTestimonial.TextArm;
            existingTestimonial.TextEng = editedTestimonial.TextEng;

            _dbContext.Testimonials.Update(existingTestimonial);
            await _dbContext.SaveChangesAsync();

            return Ok(existingTestimonial);
        }

        [HttpGet("api/Testimonials")]
        public async Task<IActionResult> GetAllTestimonials()
        {
            return Ok(await _dbContext.Testimonials.ToListAsync());
        }

        [HttpGet("api/TestimonialDetails/{id}")]
        public async Task<IActionResult> GetTestimonialDetails(Guid id)
        {
            try
            {
                // Retrieve course data using the provided ID
                var testimonial = await _dbContext.Testimonials.FindAsync(id);
                if (testimonial == null)
                {
                    return NotFound();
                }
                return Ok(testimonial); // Return course data in JSON format
            }
            catch (Exception ex)
            {
                // Handle errors gracefully
                return StatusCode(500, "Error retrieving Testimonials details");
            }
        }

        [HttpDelete("api/Testimonial/{id}")]
        public async Task<IActionResult> DeleteTestimonial(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingTestimonial = await _dbContext.Testimonials.FindAsync(id);

            if (existingTestimonial == null)
            {
                return NotFound();
            }

            _dbContext.Testimonials.Remove(existingTestimonial);
            await _dbContext.SaveChangesAsync();

            return Ok(); // Return successful response
        }

    }
}
