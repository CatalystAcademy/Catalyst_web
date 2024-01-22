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
        private readonly ILocService _locService;

        public NewsController(ApplicationDbContext dbContext, ILocService locService)
        {
            _dbContext = dbContext;
            _locService = locService;
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
                Title = request.Title,
                Description = request.Description,
                ImageData = request.ImageData,
            };
            _dbContext.Newses.Add(createNews);
            await _dbContext.SaveChangesAsync();

            return Ok();
        }

    }
}
