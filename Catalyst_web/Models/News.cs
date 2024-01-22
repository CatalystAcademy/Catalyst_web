using Catalyst_web.Models.Abstract;

namespace Catalyst_web.Models
{
    public class News : BaseEntity
    {
        public required string? Title { get; set; }
        public required string? Description { get; set; }
        public string? ImagePath { get; set; }
        public byte[]? ImageData { get; set; }
    }
}
