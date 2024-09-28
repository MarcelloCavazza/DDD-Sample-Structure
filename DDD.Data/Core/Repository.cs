using DDD.Data.Context;
using DDD.Shared.Data.Core;
using Microsoft.EntityFrameworkCore;

namespace DDD.Data.Core
{
    public class Repository<T> : IRespository<T>
        where T : PersistentData
    {
        private readonly DataDBContext _context;

        public Repository(DataDBContext context)
        {
            _context = context;
        }

        public async Task<T?> Get(Guid id, bool includeDeleted = false)
        {
            return await _context.Set<T>()
                                 .AsQueryable()
                                 .Where(p => p.Deleted == includeDeleted)
                                 .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<T>> GetAll(bool includeDeleted = false)
        {
            return await _context.Set<T>()
                                 .AsQueryable()
                                 .Where(p => p.Deleted == includeDeleted)
                                 .ToListAsync();
        }

        public async Task<List<T>> GetList(IEnumerable<Guid> Ids, bool includeDeleted = false)
        {
            return await _context.Set<T>()
                                 .AsQueryable()
                                 .Where(p => Ids.Contains(p.Id) && 
                                             p.Deleted == includeDeleted)
                                 .ToListAsync();
        }
    }
}
