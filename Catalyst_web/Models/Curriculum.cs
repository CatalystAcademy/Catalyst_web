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
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
