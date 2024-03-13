using Catalyst_web.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Catalyst_web.Models
{
    public class Curriculum : BaseEntity
    {
        [Required]
        public required string TitleEng { get; set; }
        [Required]
        public required string TitleArm { get; set; }
        [Required]
        public required string CategoryArm { get; set; }
        [Required]
        public required string CategoryEng { get; set; }
        [Required]
        public required string DescriptionEng { get; set; }
        [Required]
        public required string DescriptionArm { get; set; }
        [Required]
        public required string CurriculumEng { get; set; }
        [Required]
        public required string CurriculumArm { get; set; }
        public string? Duration { get; set; }
        public string? Lectures { get; set; }
        public string? Students { get; set; }
        public string? SkillLevel { get; set; }
        public string? Language { get; set; }
        public string? StudentsCountOnCurriculum { get; set; }
        public string? Rating { get; set; }
        [Required]
        public required string CurriculumDescriptionTitleEng { get; set; }
        [Required]
        public required string CurriculumDescriptionTitleArm { get; set; }
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int Order { get; set; }
    }
}
