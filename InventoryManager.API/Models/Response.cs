namespace InventoryManager.API.Models
{
    /// <summary>Esta clase permite incorporar a la respuesta de la Api los datos de los errores.</summary>
    public class Response
    {
        public bool Errored { get; set; }
        public string ErrorMessage { get; set; }
    }
}