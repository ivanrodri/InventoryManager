using System.Collections.Generic;

namespace InventoryManager.Application.Elements
{
    public interface IElementService
    {

        IEnumerable<ElementDto> Get();

        ElementDto Add(ElementDto elementDto);

        void Extract(string name);
    }
}
