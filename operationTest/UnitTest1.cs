using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculation;

namespace operationTest
{
    [TestClass]
    public class UnitTest1
    {

        oprations op = new oprations();
        [TestMethod]
        public void TestMethodAdd()
        {
            int result = op.Add(2,3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestMethodSub()
        {
            int result = op.Sub(3, 2);
            Assert.AreEqual(1, result);
        }
    }
}
