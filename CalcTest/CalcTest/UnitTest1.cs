using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcTest
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestSum()
        {
            //Arranger
            var test = new CalcLibrary.Calc();

            //Act
            var result = test.Sum(1, 2);
            var result2 = test.Sum(1, 3);
            var result3 = test.Sum(1, 4);
            var result4 = test.Sum(1, 5);


            //Assert
            Assert.AreEqual(result, 3);
            Assert.AreEqual(result2, 4);
            Assert.AreEqual(result3, 5);
            Assert.AreEqual(result4, 6);
        }
    }
}
