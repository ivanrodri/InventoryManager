using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InventoryManager.Infraestructura
{
    public class MemoryUnitOfWork : IUnitOfWork
    {
        public void Commit()
        {
            //commit
        }

        public void Rollback()
        {
            //rollback
        }

        public void Dispose()
        {
            //dispose
        }
    }
}
