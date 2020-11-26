using NUnit.Framework;
using InventoryManager.Application.Elements;

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



        [Test]
        public void ElementServiceAdd()
        {
            // Arrange
            var element = ElementService.Contact.CreateContact(-1, "Stephen", "Walther", "555-5555", "steve@somewhere.com");

            // Act
            var result = _service.CreateContact(contact);

            // Assert
            Assert.IsTrue(result);
        }


    }
}