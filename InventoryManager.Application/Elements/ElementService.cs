using InventoryManager.Domain.Elements;
using InventoryManager.Infraestructura;
using System;
using System.Collections.Generic;
using InventoryManager.Domain.Specification;

namespace InventoryManager.Application.Elements
{
    /// <summary>Clase del Servico del elemento.</summary>
    public class ElementService : IElementService
    {
        readonly IRepository<Element> elementRepository;


        public ElementService(IRepository<Element> elementRepository)
        {
            this.elementRepository = elementRepository;
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
        public void Extract(string name)
        {
            throw new NotImplementedException();
        }

        /// <summary>Este método obtiene todos los elementos del inventario.</summary>
        public IEnumerable<ElementDto> Get()
        {
            //new ElementSpec( Guid.NewGuid())

            IEnumerable<Element> elements = this.elementRepository.Find(new ElementFindByNameSpec(""));
            //IEnumerable<Purchase> customerPurchases =
            //       this.purchaseRepository.Find(new CustomerPurchasesSpec(customer.Id));

            return null;
        }
    }
}
