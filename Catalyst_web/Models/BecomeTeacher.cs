using Catalyst_web.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Catalyst_web.Models
{
    public class BecomeTeacher : BaseEntity
    {
        public Guid? CourseId { get; set; } 
        [Required]
        public required Guid CurriculumId { get; set; }
        [Required]
        public required string FullName { get; set; }
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        public string? Message { get; set; }
        public required string PhoneNumber { get; set; }
        public byte[]? File { get; set; } 
    }
}
