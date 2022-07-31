using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            //Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "tochind29@gmail.com",
                FirstName = "Tochukwu",
                LastName = "Ndefo"
        };

            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert
            // Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);


        }
        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "tochind29@gmail.com",
                FirstName = "Tochukwu",
                LastName = "Ndefo",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                         AdressType = 1,
                        StreetLine1 = "Alhaji Ajala",
                        StreetLine2 = "Alhaji jimoh",
                        City = "Lagos",
                        State = "Lagos",
                        Country = "Nigeria",
                        PostalCode = "10001"
                    },
                    new Address()
                    {
                        AdressType = 2,
                StreetLine1 = "Ajala",
                StreetLine2 = "Alhaji",
                City = "Lagos",
                State = "Lagos",
                Country = "Nigeria",
                PostalCode = "10001"
                    }
                }
            };
            //--Act
            var actual = customerRepository.Retrieve(1);

            //--Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for(int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AdressType, actual.AddressList[i].AdressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}
