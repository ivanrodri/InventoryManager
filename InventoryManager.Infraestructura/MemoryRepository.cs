using InventoryManager.Domain;
using InventoryManager.Domain.Specification;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManager.Infraestructura
{
    /// <summary>Esta clase implementa el Repositorio en memoria.</summary>
    /// <param name="elementDto">el nuevo elemtento</param>
    public class MemoryRepository<TEntity> : IRepository<TEntity>
        where TEntity : IAggregateRoot
    {
        protected static List<TEntity> entities = new List<TEntity>();

        /// <summary>Este método permite obtener un elemento mediante el id Guid.</summary>
        /// <param name="id">el id Guid</param>
        public TEntity FindById(Guid id)
        {
            return entities.Where(x => x.Id == id).FirstOrDefault();
        }

        /// <summary>Este método permite obtener un elemento mediante el id Guid.</summary>
        /// <param name="spec">la especificación</param>
        public TEntity FindOne(ISpecification<TEntity> spec)
        {
            return entities.Where(spec.IsSatisfiedBy).FirstOrDefault();
        }

        /// <summary>Este método permite obtener un elemento mediantela especificación</summary>
        /// <param name="spec">la especificación</param>
        public IEnumerable<TEntity> Find(ISpecification<TEntity> spec)
        {
            return entities.Where(spec.IsSatisfiedBy);
        }

        /// <summary>Este método permite añadir un nuevo objeto.</summary>
        /// <param name="entity">la especificación</param>
        public void Add(TEntity entity)
        {
            entities.Add(entity);
        }

        /// <summary>Este método permite eliminar logicamente un elemento.</summary>
        /// <param name="entity">la entidad</param>
        public void Remove(TEntity entity)
        {
            entities.Remove(entity);
        }

        /// <summary>Este método permite actualizar un elemento del inventario.</summary>
        /// <param name="entity">la entidad</param>
        public void Update(TEntity entity)
        {
            if (entity != null)
            {
                TEntity oldEntity = this.FindById(entity.Id);
                entities.Remove(oldEntity);
                entities.Add(entity);
            }
        }
    }
}
