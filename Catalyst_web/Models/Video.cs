using Catalyst_web.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Catalyst_web.Models
{
    public class Video : BaseEntity
    {
        [Required]
        public string? Title { get; set; }
        public string? Description { get; set; }

        public byte[]? Data { get; set; } 
        public string? Url { get; set; } // If storing references (URLs)

        public string? ContentType { get; set; } // Mime type of the video data
        public string? FileName { get; set; } // Optional filename (if applicable)
        public DateTimeOffset? UploadedDate { get; set; }
    }
}
