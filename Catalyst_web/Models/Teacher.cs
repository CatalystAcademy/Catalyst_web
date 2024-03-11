using Catalyst_web.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Catalyst_web.Models
{
    public class Teacher : BaseEntity
    {
        [Required]
        public required string FullNameArm { get; set; }
        [Required]
        public required string FullNameEng { get; set; }
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        [Required]
        public required string DescriptionArm { get; set; }
        [Required]
        public required string DescriptionEng { get; set; }
        [Required]
        public required string ProfessionArm { get; set; }
        [Required]
        public required string ProfessionEng { get; set; }
        public Guid? CourseId { get; set; }
        public Guid? CurriculumId { get; set; }
        public string Link { get; set; }
        public bool IsFromLeadership { get; set; }
    }
}
