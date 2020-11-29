﻿using InventoryManager.Domain.DomainEvents;

namespace InventoryManager.Domain.Elements
{
    public class ElementDelete : IDomainEvent
     {
        public Element element { get; }

        public ElementDelete(Element _element) 
        {

            element = _element;
        }
    }
}

