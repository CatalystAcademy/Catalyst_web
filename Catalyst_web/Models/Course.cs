using Catalyst_web.Models.Abstract;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catalyst_web.Models
{
    public class Course : BaseEntity
    {
        [Required]
        public required string TitleEng { get; set; }
        [Required]
        public required string TitleArm { get; set; }
        [Required]
        public required string DescriptionEng { get; set; }
        [Required]
        public required string DescriptionArm { get; set; }
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string? ImagePath { get; set; }
        [NotMapped]
        public IFormFile? ImageData { get; set; }

    }
}
