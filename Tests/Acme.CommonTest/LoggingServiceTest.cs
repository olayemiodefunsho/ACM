using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Acme.Common;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            // Arrange
            var changedItems = new List<Iloggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "fbaggins@obbiton.me",
                FirstName = "Bilbo",
                LastName = "Baggins",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Graden Rake with Steel Head",
                CurrentPrice = 6M
            };

            changedItems.Add(product);

            // Act
            LoggingService.WriteToFile(changedItems);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
