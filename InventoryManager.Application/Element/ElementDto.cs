using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Application.Element
{
    class ElementDto
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }

        public DateTime ExpirationDate { get; set; }

        public DateTime EntryDate { get; set; }

        public string Type { get; set; }

    }
}
