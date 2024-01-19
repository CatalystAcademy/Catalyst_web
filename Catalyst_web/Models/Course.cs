using Catalyst_web.Models.Abstract;

namespace Catalyst_web.Models
{
    public class Course : BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndtDate { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}
