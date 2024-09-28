using DDD.Shared.Data.Core;
using System.ComponentModel.DataAnnotations;

namespace DDD.Shared.Data.DTO
{
    public class ProductDTO : IPersistentData
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }
    }
}
