using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
