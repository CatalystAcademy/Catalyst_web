using Catalyst_web.Infrastructure.Persistence;
using Catalyst_web.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Catalyst_web.Controllers
{
    [EnableCors("AllowSpecificOrigin")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        public FormController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpPost("api/Form/Submit")]
        public async Task<IActionResult> SubmitForm([FromBody] FormData request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var formData = new FormData { Email = request.Email, PhoneNumber = request.PhoneNumber };

            _dbContext.FormDatas.Add(formData);
            await _dbContext.SaveChangesAsync();

            // Send a response back to the client
            return Ok(new { success = true, message = "Form submitted successfully" });
        }
    }
}
