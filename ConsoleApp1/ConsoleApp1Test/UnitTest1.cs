using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 5;
            int b = 6;
            int result = ConsoleApp1.Program.Example(a, b);
            Assert.AreEqual(11, result);
        }
    }
}
