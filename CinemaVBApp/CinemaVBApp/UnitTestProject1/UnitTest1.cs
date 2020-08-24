using CinemaVBApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void Adult_Before_5_Test()
        {
            var form1 = new Form();
            decimal adult_before_5 = form1.Adult_Before_5(1, "person", "tuesday", 6);
            Assert.AreEqual(14.5, adult_before_5);
        }
    }
}