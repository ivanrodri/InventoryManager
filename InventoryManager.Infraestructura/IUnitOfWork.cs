using System;

namespace InventoryManager.Infraestructura
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        void Rollback();
    }
}
