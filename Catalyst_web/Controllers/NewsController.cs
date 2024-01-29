using Catalyst_web.Infrastructure.Persistence;
using Catalyst_web.Interfaces;
using Catalyst_web.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Catalyst_web.Controllers
{
    [EnableCors("AllowSpecificOrigin")]
    // [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public NewsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet("api/News")]
        public async Task<IActionResult> GetAllNews()
        {
            return Ok(await _dbContext.Newses.ToListAsync());
        }

        [HttpPost("api/News/Create")]
        public async Task<IActionResult> CreateNews([FromBody] News request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createNews = new News
            {
                TitleArm = request.TitleArm,
                TitleEng = request.TitleEng,
                DescriptionArm = request.DescriptionArm,
                DescriptionEng = request.DescriptionEng,
                ImageData = request.ImageData,
            };
            _dbContext.Newses.Add(createNews);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("api/News/Edit/{id}")]
        public async Task<IActionResult> UpdateNews(Guid id, [FromBody] News editedNews)
        {
            // 1. Validate ID and model existence
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Return bad request if model validation fails
            }
            var existingNews = await _dbContext.Newses.FindAsync(id);

            if (existingNews == null)
            {
                return NotFound();
            }

            existingNews.TitleEng = editedNews.TitleEng;
            existingNews.TitleArm = editedNews.TitleArm;
            existingNews.DescriptionEng = editedNews.DescriptionEng;
            existingNews.DescriptionArm = editedNews.DescriptionArm;

            _dbContext.Newses.Update(existingNews);
            await _dbContext.SaveChangesAsync();

            return Ok(existingNews);
        }

        [HttpGet("api/NewsDetails/{id}")]
        public async Task<IActionResult> GetNewsDetails(Guid id)
        {
            try
            {
                // Retrieve course data using the provided ID
                var news = await _dbContext.Newses.FindAsync(id);
                if (news == null)
                {
                    return NotFound();
                }
                return Ok(news); // Return course data in JSON format
            }
            catch (Exception ex)
            {
                // Handle errors gracefully
                return StatusCode(500, "Error retrieving news details");
            }
        }

        [HttpDelete("api/News/{id}")]
        public async Task<IActionResult> DeleteNews(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingNews = await _dbContext.Newses.FindAsync(id);

            if (existingNews == null)
            {
                return NotFound();
            }

            _dbContext.Newses.Remove(existingNews);
            await _dbContext.SaveChangesAsync();

            return Ok(); // Return successful response
        }

    }
}
