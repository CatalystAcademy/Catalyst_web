using Catalyst_web.Models.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catalyst_web.Models
{
    public class RegisterForCourse : BaseEntity
    {
        public required Guid CourseId { get; set; }
        [Required]
        public required string FullName { get; set; }
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        public string? Message { get; set; }
        public required string PhoneNumber { get; set; }
        public required string ParentPhoneNumber { get; set; }
        public byte[]? ImageData { get; set; }
        public string? ImageUrl { get; set; }
    }
}
