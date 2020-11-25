using System.Collections.Generic;

namespace InventoryManager.Application.Elements
{
    /// <summary>interface de la del servicio de elemento.</summary>
    public interface IElementService
    {
        IEnumerable<ElementDto> Get();

        ElementDto Add(ElementDto elementDto);

        void Extract(string name);
    }
}
