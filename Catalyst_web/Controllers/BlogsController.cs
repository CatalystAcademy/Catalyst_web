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
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public BlogsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet("api/Blogs")]
        public async Task<IActionResult> GetAllBlogs()
        {
            return Ok(await _dbContext.Blogs.ToListAsync());
        }

        [HttpPost("api/Blog/Create")]
        public async Task<IActionResult> CreateBlog([FromBody] Blog request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createBlog = new Blog
            {
                TitleArm = request.TitleArm,
                TitleEng = request.TitleEng,
                DescriptionArm = request.DescriptionArm,
                DescriptionEng = request.DescriptionEng,
            };
            _dbContext.Blogs.Add(createBlog);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("api/Blog/Edit/{id}")]
        public async Task<IActionResult> UpdateBlog(Guid id, [FromBody] Blog editedBlog)
        {
            // 1. Validate ID and model existence
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Return bad request if model validation fails
            }
            var existingBlog = await _dbContext.Blogs.FindAsync(id);

            if (existingBlog == null)
            {
                return NotFound();
            }

            existingBlog.TitleEng = editedBlog.TitleEng;
            existingBlog.TitleArm = editedBlog.TitleArm;
            existingBlog.DescriptionEng = editedBlog.DescriptionEng;
            existingBlog.DescriptionArm = editedBlog.DescriptionArm;

            _dbContext.Blogs.Update(existingBlog);
            await _dbContext.SaveChangesAsync();

            return Ok(existingBlog);
        }

        [HttpGet("api/BlogDetails/{id}")]
        public async Task<IActionResult> GetBlogDetails(Guid id)
        {
            try
            {
                // Retrieve course data using the provided ID
                var Blog = await _dbContext.Blogs.FindAsync(id);
                if (Blog == null)
                {
                    return NotFound();
                }
                return Ok(Blog); // Return course data in JSON format
            }
            catch (Exception ex)
            {
                // Handle errors gracefully
                return StatusCode(500, "Error retrieving Blogs details");
            }
        }

        [HttpDelete("api/Blog/{id}")]
        public async Task<IActionResult> DeleteBlog(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingBlog = await _dbContext.Blogs.FindAsync(id);

            if (existingBlog == null)
            {
                return NotFound();
            }

            _dbContext.Blogs.Remove(existingBlog);
            await _dbContext.SaveChangesAsync();

            return Ok(); // Return successful response
        }

    }
}
