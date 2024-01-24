using Catalyst_web.Models.Abstract;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catalyst_web.Models
{
    public class Course : BaseEntity
    {
        [Required]
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string? ImagePath { get; set; }
        [NotMapped]
        public IFormFile? ImageData { get; set; }

    }
}
