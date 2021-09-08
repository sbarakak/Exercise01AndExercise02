using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise02;
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
            string result = Exercise02.Program.ConvertNumberToWords(bi, 1000);
            Assert.AreEqual("one thousand", Exercise02.Program.ConvertNumberToWords(bi, 1000));
        }
    }
}
