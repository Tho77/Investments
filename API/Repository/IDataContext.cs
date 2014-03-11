using System;

namespace Investments.Repository
{
    public interface IDataContext : IDisposable
    {
        int SaveChanges();
        void SyncObjectState(object entity);
    }
}