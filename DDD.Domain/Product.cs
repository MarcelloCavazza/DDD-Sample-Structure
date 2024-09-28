using DDD.Shared.Data.Core;

namespace DDD.Domain
{
    public class Product : PersistentData
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }
    }
}
