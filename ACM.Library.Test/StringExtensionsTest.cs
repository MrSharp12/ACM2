using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM2.Library;
using ACM2.BL;

namespace ACM.Library.Test
{
    [TestClass]
    public class StringExtensionsTest
    {
        public TestContext TestContent { get; set; }

        [TestMethod]
        public void ConvertToTitleCase()
        {
            //arrange
            var source = "the return of the king";
            var expected = "The Return Of The King";

            //act
            //var result = StringExtensions.ConvertToTitleCase(source);
            var result = source.ConvertToTitleCase();//extension method

            //assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result);

        }

       
    }
}
