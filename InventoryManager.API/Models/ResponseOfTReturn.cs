namespace InventoryManager.API.Models
{
    /// <summary>Esta clase permite incorporar los datos de respuesta de los servicios junto con los datos de los mensajes de error.</summary>
    public sealed class Response<TReturn> : Response
    {
        public TReturn Object { get; set; }
    }
}