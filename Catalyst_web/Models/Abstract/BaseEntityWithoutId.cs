using System.ComponentModel.DataAnnotations;

namespace Catalyst_web.Models.Abstract
{
    public abstract class BaseEntityWithoutId
    {
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public string? CreatedBy { get; set; }

        public DateTime Modified { get; set; } = DateTime.UtcNow;
        public string? ModifiedBy { get; set; }

        public bool IsDeleted { get; set; }

        [ConcurrencyCheck]
        [Timestamp]
        public byte[]? RowVersion { get; set; }
    }
}
