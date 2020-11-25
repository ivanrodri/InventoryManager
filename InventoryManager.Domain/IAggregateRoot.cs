using System;

namespace InventoryManager.Domain
{
    /// <summary>Esta clase permite definir la interfaz del método AggregateRoot. El AggregateRoot permite definir la jerarquia de las clases que lo implementan.</summary>
    public interface IAggregateRoot
    {
        Guid Id { get; }
    }
}
