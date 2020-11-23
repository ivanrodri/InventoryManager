using System;

namespace InventoryManager.Domain
{
     public class Element
    {
        public Guid Id { get; protected set; }

        public string Name { get; protected set; }

        public DateTime ExpirationDate { get; protected set; }

        public DateTime EntryDate { get; protected set; }

        public string Type { get; protected set; }

    }
}
