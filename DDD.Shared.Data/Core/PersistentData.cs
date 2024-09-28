using System.ComponentModel.DataAnnotations;

namespace DDD.Shared.Data.Core
{
    public abstract class PersistentData : IPersistentData
    {
        public PersistentData()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
            Deleted = false;
        }

        [Key]
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public bool Deleted { get; set; }

        [Timestamp]
        public byte[]? Timestamp { get; set; }
    }
}
