using DDD.Data.Context;
using DDD.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace DDD.Data.Core
{
    class Uow : IUow
    {
        protected DataDBContext _context { get; }

        public Uow(DbContextOptions<DataDBContext> options)
        {
            _context = new DataDBContext(options);

            ProductRepository = new ProductRepository(_context);
        }

        public ProductRepository ProductRepository { get; private set; }
    }
}
