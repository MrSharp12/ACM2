using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM2.Library;

namespace ACM.Library.Test
{
    [TestClass]
    public class BuilderTest
    {

        public TestContext TestContext { get; set; }

        [TestMethod]
        public void BuildIntegerSequenceTest()
        {
            //arrange
            Builder listBuilder = new Builder();

            //act
            var result = listBuilder.BuildIntegerSequence();

            //analyze
            foreach (var item in result)
            {
                TestContext.WriteLine(item.ToString());
            }
            //assert
            Assert.IsNotNull(result);
        }
    }
}
