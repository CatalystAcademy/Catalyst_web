using Catalyst_web.Models.Abstract;

namespace Catalyst_web.Models
{
    public class Course : BaseEntity
    {
        public required string? Title { get; set; }
        public required string? Description { get; set; }
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string? ImagePath { get; set; }
        public byte[]? ImageData { get; set; }

    }
}
