using DDD.Data.Context;
using DDD.Data.Core;
using DDD.Domain;

namespace DDD.Data.Repository
{
    class ProductRepository : Repository<Product>
    {
        public ProductRepository(DataDBContext context) : base(context)
        {
        }
    }
}
