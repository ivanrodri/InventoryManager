using InventoryManager.Domain.DomainEvents;

namespace InventoryManager.Domain.Elements
{
    public class ElementExpired : IDomainEvent
     {
        public Element element { get; }

        public ElementExpired(Element _element) 
        {

            element = _element;
        }
    }
}

