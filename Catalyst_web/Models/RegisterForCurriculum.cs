using Catalyst_web.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Catalyst_web.Models
{
    public class RegisterForCurriculum : BaseEntity
    {
        public required Guid CurriculumId { get; set; }
        [Required]
        public required string FullName { get; set; }
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        public string? Message { get; set; }
        public required string PhoneNumber { get; set; }
        public required string ParentPhoneNumber { get; set; }
    }
}
