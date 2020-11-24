using InventoryManager.Domain.Elements;
using InventoryManager.Infraestructura;
using System;
using System.Collections.Generic;

namespace InventoryManager.Application.Elements
{
    public class ElementService : IElementService
    {
        readonly IRepository<Element> elementRepository;

        public ElementService(IRepository<Element> elementRepository)
        {
            this.elementRepository = elementRepository;
        }

        public ElementDto Add(ElementDto elementDto)
        {

            Element element = Element.Create(elementDto.Name, elementDto.ExpirationDate, elementDto.EntryDate, elementDto.Type);

            this.elementRepository.Add(element);

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
