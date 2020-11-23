using System;

namespace InventoryManager.Domain
{
    public interface IAggregateRoot
    {
        Guid Id { get; }
    }
}
