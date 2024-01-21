using Catalyst_web.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Catalyst_web.Models
{
    public class RegisterForCourse : BaseEntity
    {
        public required Guid CourseId { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        public string? Message { get; set; }
        public required string PhoneNumber { get; set; }
    }
}
