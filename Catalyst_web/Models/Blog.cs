using Catalyst_web.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Catalyst_web.Models
{
    public class Blog : BaseEntity
    {
        [Required]
        public required string TitleEng { get; set; }
        [Required]
        public required string TitleArm { get; set; }
        [Required]
        public required string DescriptionEng { get; set; }
        [Required]
        public required string DescriptionArm { get; set; }
    }
}
