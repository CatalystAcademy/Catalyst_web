using Catalyst_web.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Catalyst_web.Models
{
    public class Testimonial : BaseEntity
    {
        [Required]
        public required string FullNameArm { get; set; }
        [Required]
        public required string FullNameEng { get; set; }
        [Required]
        public required string PositionArm { get; set; }
        [Required]
        public required string PositionEng { get; set; }
        [Required]
        public required string TextArm { get; set; }
        [Required]
        public required string TextEng { get; set; }
        public int Order { get; set; }
    }
}
