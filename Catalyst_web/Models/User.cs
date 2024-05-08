using Catalyst_web.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Catalyst_web.Models
{
    public class User : BaseEntity
    {
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public string? PinCode { get; set; }
        public string? CatalystLevel { get; set; }
        [Required]
        public DateOnly DateOfBirth { get; set; }
    }
}
