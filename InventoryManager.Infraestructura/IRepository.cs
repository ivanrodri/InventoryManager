using InventoryManager.Domain;
using System;
using System.Collections.Generic;

namespace InventoryManager.Infraestructura
{
    /// <summary>Esta es la interfaz del Repotitorio del tipo TEntity.</summary>
    public interface IRepository<TEntity> 
        where TEntity : IAggregateRoot
    {
        TEntity FindById(Guid id);

        TEntity FindOne(ISpecification<TEntity> spec);

        IEnumerable<TEntity> Find(ISpecification<TEntity> spec);

        void Add(TEntity entity);

        void Remove(TEntity entity);
    }
}
