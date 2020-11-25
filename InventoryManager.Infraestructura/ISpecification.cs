using System;
using System.Linq.Expressions;

namespace InventoryManager.Infraestructura
{
    /// <summary>Esta es la interfaz de ISpecification. Permite implementar el patraon de especificación</summary>
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> SpecExpression { get; }

        bool IsSatisfiedBy(T obj);
    }
}
