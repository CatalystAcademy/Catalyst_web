using Catalyst_web.Models.Abstract;

namespace Catalyst_web.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public string? PinCode { get; set; }
    }
}
