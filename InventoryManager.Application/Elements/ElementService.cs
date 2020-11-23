using System;
using System.Collections.Generic;
using System.Text;
using InventoryManager.Domain.Elements;

namespace InventoryManager.Application.Elements
{
    public class ElementService : IElementService
    {
        //readonly IRepository<Element> elementRepository;
        //readonly IUnitOfWork unitOfWork;


        public ElementDto Add(ElementDto elementDto)
        {

            Element element = Element.Create(elementDto.Name, elementDto.ExpirationDate, elementDto.EntryDate, elementDto.Type);

            //this.productRepository.Add(element);

            //return AutoMapper.Mapper.Map<Element, ElementDto>(element);
            return elementDto;
        }

        public void Extract(string name)
        {
            throw new NotImplementedException();
        }

        public ElementDto Get(Guid elementId)
        {
            throw new NotImplementedException();
        }
    }
}
