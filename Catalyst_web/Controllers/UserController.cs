using Catalyst_web.Infrastructure.Persistence;
using Catalyst_web.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Catalyst_web.Controllers
{
    [EnableCors("AllowSpecificOrigin")]
    [ApiController]
    public class UserController(ApplicationDbContext dbContext) : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext = dbContext;
        private static readonly string JwtSecretKey = "C4+YZ2BkQH86viAvQ5dKZu45nJX/MNQaCM8QaiDukNM="; // Replace with actual key

        [HttpPost("/api/login/admin")]
        public async Task<IActionResult> LoginAdmin([FromBody] User user)
        {
            var existingUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == user.Email);
            user.Username = existingUser.Username;
            if (user.Email == existingUser.Email)
            {
                var token = GenerateJwtToken(user.Email, existingUser.Id); // Implement JWT generation
                return Ok(new { token });
            }
            if (existingUser == null || user.Email != existingUser.Email)
            {
                // Username not found - Handle appropriately
                return BadRequest("Invalid username or password"); // Or a more descriptive message
            }
            else
            {
                return Unauthorized();
            }
        }

        private string GenerateJwtToken(string userEmail, Guid userId)
        {
            var claims = new List<Claim>
            {
            new(ClaimTypes.NameIdentifier, userId.ToString()),
            new(ClaimTypes.Email, userEmail),
            };

            var claimsIdentity = AddClaimsToIdentity(userEmail, userId);

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtSecretKey)); // Replace with your secret key
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claimsIdentity),
                Expires = DateTime.UtcNow.AddHours(1), // Adjust expiration time as needed
                SigningCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature)
            };
            var token = jwtTokenHandler.CreateToken(tokenDescriptor);
            var tokenString = jwtTokenHandler.WriteToken(token);

            return tokenString;
        }

        [HttpGet("/api/generate-secret-key")]
        public string GenerateSecretKey()
        {
            using var randomNumberGenerator = RandomNumberGenerator.Create();
            var keyBytes = new byte[32]; // Adjust size as needed
            randomNumberGenerator.GetBytes(keyBytes);
            return Convert.ToBase64String(keyBytes);
        }
        private static ClaimsIdentity AddClaimsToIdentity(string userEmail, Guid userId)
        {
            var claims = new List<Claim>
            {
                new(ClaimTypes.NameIdentifier, userId.ToString()),
                new(ClaimTypes.Email, userEmail)
            };
            // Add other claims as needed, e.g., roles

            return new ClaimsIdentity(claims);
        }
        [HttpGet("/api/auth/user")] // Add this endpoint
        public async Task<IActionResult> GetUser()
        { 

            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == "admin@gmail.com"); 
            if (user == null)
            {
                return NotFound(); // Return 404 if user not found
            }

            var userData = new
            {
                user = new // Nest user data under "user" field
                {
                    username = user.Username,
                    email = user.Email,
                    userId = user.Id,
                }
            };

            return Ok(userData); // Return user data as JSON
        }

    }
}

