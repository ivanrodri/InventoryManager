using System;

namespace InventoryManager.Domain.Elements
{
     public class Element : IAggregateRoot
    {
        public Guid Id { get; protected set; }

        public string Name { get; protected set; }

        public DateTime ExpirationDate { get; protected set; }

        public DateTime EntryDate { get; protected set; }

        public string Type { get; protected set; }


        public static Element Create(string name, DateTime expirationDate, DateTime entryDate, string type )
        {
            return Create(Guid.NewGuid(), name, expirationDate, entryDate, type);
        }

        public static Element Create(Guid id, string name, DateTime expirationDate, DateTime entryDate, string type)
        {
            Element element = new Element()
            {
                Id = id,
                Name = name,
                ExpirationDate = expirationDate,
                EntryDate = DateTime.Now,
                Type = type,

            };

            return element;
        }




    }
}
