using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;
using System.Collections.Generic;
using ACM.BL;

namespace Acme.CommonTest
{
    [TestClass]
    public class LogginServiceTest
    {
        [TestMethod]
        public void WriteToFilesTest()
        {
            //Arrange
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "tochund29@gmail.com",
                FirstName = "Tochukwu",
                LastName = "Ndefo",
                AddressList = null

            };
            changedItems.Add(customer as ILoggable);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 6M
            };
            changedItems.Add(product as ILoggable);

            //Act
            LoggingService.WriteToFile(changedItems);
            //Assert
        }
    }
}
