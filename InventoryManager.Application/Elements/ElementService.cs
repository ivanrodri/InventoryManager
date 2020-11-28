using InventoryManager.Domain.Elements;
using InventoryManager.Infraestructura;
using System;
using System.Collections.Generic;
using InventoryManager.Domain.Specification;
using AutoMapper;

namespace InventoryManager.Application.Elements
{
    /// <summary>Clase del Servico del elemento.</summary>
    public class ElementService : IElementService
    {
        readonly IRepository<Element> elementRepository;
        readonly IMapper _mapper;

        public ElementService(IRepository<Element> elementRepository,
                                IMapper mapper)
        {
            this.elementRepository = elementRepository;
            _mapper = mapper;

        }

        /// <summary>Este método permite añadir un elemento nuevo al inventario mediante la utilización de elementDto.</summary>
        /// <param name="elementDto">el nuevo elemtento</param>
        public ElementDto Add(ElementDto elementDto)
        {
            Element element = Element.Create(elementDto.Name, elementDto.ExpirationDate, elementDto.EntryDate, elementDto.Type);
            this.elementRepository.Add(element);
            return elementDto;
        }

        /// <summary>Este método permite la eliminación logica de un elemento mediante el nombre del elemento.</summary>
        /// <param name="name">el nombre del elemtento</param>
        public ElementDto Extract(string name)
        {
            Element element = this.elementRepository.FindOne(new ElementFindByNameSpec(name));                                  
            this.elementRepository.Update(element);
            var elementDto = _mapper.Map<ElementDto>(element);
            return elementDto;
        }

        /// <summary>Este método obtiene todos los elementos del inventario.</summary>
        public IEnumerable<ElementDto> Get()
        {
            IEnumerable<Element> elements = this.elementRepository.Find(new ElementByDeleteDateSpec(null));
            var elementsDto = _mapper.Map<IEnumerable<ElementDto>>(elements);
            return elementsDto;
        }

        /// <summary>Este método permite modificar un elemento existente en el inventario./summary>
        /// <param name="elementDto">el nuevo elemtento</param>
        public ElementDto Update(ElementDto elementDto)
        {
            var element = _mapper.Map<Element>(elementDto);
            this.elementRepository.Update(element);
            return elementDto;
        }

        /// <summary>Este método permite modificar un elemento existente en el inventario./summary>
        /// <param name="elementDto">el nuevo elemtento</param>
        public ElementDto FindById(Guid id) {

            Element element = this.elementRepository.FindById(id);
            var elementDto = _mapper.Map<ElementDto>(element);
            return elementDto;

        }

    }
}
