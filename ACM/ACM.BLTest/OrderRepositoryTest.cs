using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod()]
        public void RetrieveOrderDisplayTest()
        {
            //Arrange
            var orderRepository = new OrderRepository();
            var expected = new OrderDisplay()
            {
                FirstName = "Tochukwu",
                LastName = "Ndefo",
                OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),
                ShippingAddress = new Address()
                {
                    AdressType = 1,
                    StreetLine1 = "Ajala",
                    StreetLine2 = "Alhaji",
                    City = "Lagos",
                    State = "Lagos",
                    Country = "Nigeria",
                    PostalCode = "10001"
                },
                orderDisplayItemList = new List<OrderDisplayItem>()
        {
                new OrderDisplayItem()
                {
                    orderQuantity = 2,
                    productName = "sunflowers",
                    PurchasePrice = 15.96M
                },
                new  OrderDisplayItem()
                {
                    orderQuantity = 1,
                    productName = "Rake",
                    PurchasePrice = 6M
                }
        }
            };
            //Act
            var actual = orderRepository.RetrieveOrderDisplay(10);

            //--Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
            Assert.AreEqual(expected.ShippingAddress.AddressId, actual.ShippingAddress.AddressId);
            Assert.AreEqual(expected.ShippingAddress.StreetLine1, actual.ShippingAddress.StreetLine1);
            Assert.AreEqual(expected.ShippingAddress.City, actual.ShippingAddress.City);
            Assert.AreEqual(expected.ShippingAddress.State, actual.ShippingAddress.State);
            Assert.AreEqual(expected.ShippingAddress.Country, actual.ShippingAddress.Country);
            Assert.AreEqual(expected.ShippingAddress.PostalCode, actual.ShippingAddress.PostalCode);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.orderDisplayItemList[i].orderQuantity, actual.orderDisplayItemList[i].orderQuantity);
                Assert.AreEqual(expected.orderDisplayItemList[i].productName, actual.orderDisplayItemList[i].productName);
                Assert.AreEqual(expected.orderDisplayItemList[i].PurchasePrice, actual.orderDisplayItemList[i].PurchasePrice);

            }
        }
    }
}

    