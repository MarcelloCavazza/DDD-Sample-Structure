using DDD.Domain;
using Microsoft.EntityFrameworkCore;

namespace DDD.Data.Context
{
    public class DataDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "DDD");

            base.OnConfiguring(optionsBuilder);
        }

        public DataDBContext(DbContextOptions<DataDBContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
