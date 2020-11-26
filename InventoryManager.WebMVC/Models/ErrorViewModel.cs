using System;

namespace InventoryManager.WebMVC.Models
{
    /// <summary>Esta es la clase de errores de la vista.</summary>
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
