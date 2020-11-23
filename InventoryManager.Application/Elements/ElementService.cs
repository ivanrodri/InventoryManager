using System;
using System.Collections.Generic;
using System.Text;
using InventoryManager.Domain.Elements;

namespace InventoryManager.Application.Element
{
    public class ElementService : IElementService
    {
        //readonly IRepository<Product> productRepository;
        //readonly IRepository<ProductCode> productCodeRepository;
        //readonly IUnitOfWork unitOfWork;


        public ElementDto Add(ElementDto element)
        {
            //ProductCode productCode =
            //    this.productCodeRepository.FindById(productDto.ProductCodeId);

            //if (productCode == null)
            //    throw new Exception("Product Code Is Not Valid");

          Element element = Element

            //this.productRepository.Add(product);

            return AutoMapper.Mapper.Map<Element, ElementDto>(element);
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
