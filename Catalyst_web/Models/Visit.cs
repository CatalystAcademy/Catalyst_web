using Catalyst_web.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Catalyst_web.Models
{
    public class Visit : BaseEntity
    {
        [Required]
        public required string Name { get; set; }
        [Required]
        [EmailAddress]
        public required string Email { get; set; }
        [Required]
        public required string PhoneNumber { get; set; }
        [Required]
        public required DateTimeOffset AppointmentDate { get; set; }
        public required TimeOnly AppointmentTime { get; set; }
    }
}
