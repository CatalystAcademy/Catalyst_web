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
        public DateOnly DateOfBirth { get; set;  }
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        [Required]
        public required string Address { get; set; }
        [Required]
        public required string EducationalInstitution { get; set; }
        public required string PhoneNumber { get; set; }
        [Required]
        public required string ParentFullName { get; set; }
        [Required]
        public required string ParentPhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public required string ParentEmail { get; set; }
        [Required]
        public required string ParentProfession { get; set; }
        public string? Message { get; set; }
    }
}
