using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // - Arrange
            Customer customer = new Customer();
            customer.FirstName = "Tochukwu";
            customer.LastName = "Ndefo";

            string expected = "Ndefo, Tochukwu";

            //- Act
            string actual = customer.FullName;
            //- Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // - Arrange
            Customer customer = new Customer();
            customer.FirstName = "Tochukwu";
            string expected = "Tochukwu";

            //- Act
            string actual = customer.FullName;
            //- Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            // - Arrange
            Customer customer = new Customer();
            customer.LastName = "Ndefo";
            string expected = "Ndefo";

            //- Act
            string actual = customer.FullName;
            //- Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void StatictTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Tome";
            Customer.Instancecount += 1;

            var c2 = new Customer();
            c2.FirstName = "Amaka";
            Customer.Instancecount += 1;

            var c3 = new Customer();
            c3.FirstName = "Tricia";
            Customer.Instancecount += 1;

            //Assert
            Assert.AreEqual(3, Customer.Instancecount);

        }

        [TestMethod]
        public void ValidateValid()
        {
            //Arrange
            var customer = new Customer();
            customer.LastName = "Ndefo";
            customer.EmailAddress = "tochind29@gmail.com";
            var expected = true;
            //Act
            var actual = customer.Validate();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingLastName()
        {
            //Arrange
            var customer = new Customer();
            customer.EmailAddress = "tochind29@gmail.com";
            var expected = false;
            //Act
            var actual = customer.Validate();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingEmail()
        {
            //Arrange
            var customer = new Customer();
            customer.LastName = "Ndefo";
            var expected = false;
            //Act
            var actual = customer.Validate();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingEmailAndLastNamel()
        {
            //Arrange
            var customer = new Customer();
            var expected = false;
            //Act
            var actual = customer.Validate();
            //Assert
            Assert.AreEqual(expected, actual);
        }




    }
}
