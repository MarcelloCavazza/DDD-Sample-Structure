using DDD.Shared.Data.Core;

namespace DDD.Data.Core
{
    public interface IRespository<T>
        where T : PersistentData
    {
        Task<T?> Get(Guid id, bool includeDeleted = false);

        Task<List<T>> GetAll(bool includeDeleted = false);

        Task<List<T>> GetList(IEnumerable<Guid> Ids, bool includeDeleted = false);

        Task Save(T entity, bool saveChanges = true);

        Task<T> Update(T entity, bool saveChanges = true);

        Task Delete(T entity, bool saveChanges = true);
    }
}