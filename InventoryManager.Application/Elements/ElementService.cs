using InventoryManager.Domain.Elements;
using System;
using System.Collections.Generic;

namespace InventoryManager.Application.Elements
{
    public class ElementService : IElementService
    {

        public ElementDto Add(ElementDto elementDto)
        {

            //Element element = Element.Create(elementDto.Name, elementDto.ExpirationDate, elementDto.EntryDate, elementDto.Type);


            return elementDto;
        }

        public void Extract(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ElementDto> Get()
        {
            return new List<ElementDto>();
        }
    }
}
