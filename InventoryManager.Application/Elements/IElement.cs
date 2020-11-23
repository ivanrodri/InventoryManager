using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Application.Elements
{
    public interface IElementService
    {

        ElementDto Get(Guid elementId);


        ElementDto Add(ElementDto element);

        void Extract(string name);
    }
}
