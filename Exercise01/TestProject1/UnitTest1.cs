using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BigInteger bi = new BigInteger();
            string result = Exercise01.ExtensionMethod.ToWards(bi, 1000);
            Assert.AreEqual("one thousand", Exercise01.ExtensionMethod.ToWards(bi, 1000));
        }
    }
}
