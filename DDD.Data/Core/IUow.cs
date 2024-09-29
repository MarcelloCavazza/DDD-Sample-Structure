using DDD.Shared.Data.Core;

namespace DDD.Data.Core
{
    interface IUow<T> 
    {
        int SaveChanges();

        Task<int> SaveChangesAsync();

        IRepository<T> Repository<T>() where T : PersistentData;

        void BeginTransaction();

        void Commit();

        void Rollback();


    }
}
