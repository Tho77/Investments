using System;

namespace Investments.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
        void Dispose(bool disposing);
        IRepository<TEntity> Repository<TEntity>() where TEntity : IObjectState;
        void BeginTransaction();
        bool Commit();
        void Rollback();
    }
}