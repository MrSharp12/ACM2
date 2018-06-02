using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ACM2.BL.Test
{
    [TestClass]
    public class CustomerRepositoryTest
    {

        public TestContext TestContext { get; set; }

        [TestMethod]
        public void FindTestExistingCustomer()
        {
            //arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            //act
            var result = repository.Find(customerList, 2);

            //assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.CustomerId);
            Assert.AreEqual("Baggins", result.LastName);
            Assert.AreEqual("Bilbo", result.FirstName);
        }

        [TestMethod]
        public void FindTestNotFound()
        {
            //arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            //act
            var result = repository.Find(customerList, 42);


            //assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void SortByNameTest()
        {
            //arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            //act
            var result = repository.SortByName(customerList);

            //assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.First().CustomerId);
            Assert.AreEqual("Baggins", result.First().LastName);
            Assert.AreEqual("Bilbo", result.First().FirstName);
        }

        [TestMethod]
        public void SortByNameInReverseTest()
        {
            //arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            //act
            var result = repository.SortByNameInReverse(customerList);

            //assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Last().CustomerId);
            Assert.AreEqual("Baggins", result.Last().LastName);
            Assert.AreEqual("Bilbo", result.Last().FirstName);
        }

        [TestMethod]
        public void SortByTypeTest()
        {
            //arrange
            CustomerRepository repository = new CustomerRepository();
            var customerList = repository.Retrieve();

            //act
            var result = repository.SortByType(customerList);

            //assert
            Assert.IsNotNull(result);
            Assert.AreEqual(null, result.Last().CustomerTypeId);
            
        }
    }
}
