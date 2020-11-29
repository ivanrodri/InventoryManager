using System;
using System.Collections.Generic;

namespace InventoryManager.Domain.DomainEvents
{
    public static class DomainEvents
    {
        private static Dictionary<Type, List<Delegate>> _handlers;

        public static void Register<T>(Action<T> eventHandler)
            where T : IDomainEvent
        {
            _handlers[typeof(T)].Add(eventHandler);
        }

        public static void Raise<T>(T domainEvent)
            where T : IDomainEvent
        {            
           // envío del evento de dominio al distribuidor de eventos internos o externos de la aplicación.
            
        }
    }
}
