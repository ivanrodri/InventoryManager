using NUnit.Framework;
using InventoryManager.Application.Elements;
using InventoryManager.Infraestructura;
using InventoryManager.Domain.Elements;
using System;
using Moq;


namespace InventoryManager.Application.Test
{
    public class ElementServiceTest
    {
       

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }



        //[Test]
        //public void ElementServiceAdd()
        //{
        //    DateTime now = DateTime.Now;
        //    var elementDto = new ElementDto();
        //    elementDto.Id = Guid.NewGuid();
        //    elementDto.Name = "Elemento 1";
        //    elementDto.ExpirationDate = now;
        //    elementDto.EntryDate = now;
        //    elementDto.Type = "Tipo A";
          
 
        //    Mock<IRepository<Element>> elementRepository = new Mock<IRepository<Element>>();

        //    var elementService = new ElementService(elementRepository.Object);

        //    var result = elementService.Add(elementDto);

        
        //    Assert.IsNotNull(result);
        //}


    }
}