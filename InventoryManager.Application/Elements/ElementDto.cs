using System;

namespace InventoryManager.Application.Element
{
    public class ElementDto
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }

        public DateTime ExpirationDate { get; set; }

        public DateTime EntryDate { get; set; }

        public string Type { get; set; }

    }
}
