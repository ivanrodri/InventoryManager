using System;

namespace InventoryManager.Application.Elements
{
    /// <summary>Esta clase permite la comunicaión de los datos del Elemento.</summary>
    public class ElementDto
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }

        public DateTime ExpirationDate { get; set; }

        public DateTime EntryDate { get; set; }

        public DateTime DeleteDate { get; set; }

        public string Type { get; set; }

    }
}
