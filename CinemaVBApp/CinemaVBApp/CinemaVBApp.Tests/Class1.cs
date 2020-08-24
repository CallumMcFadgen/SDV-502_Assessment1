using NUnit.Framework;

namespace CinemaVBApp.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Adult_Before_5_Test()
        {
            var form1 = new Form();
            decimal adult_before_5 = form1.Adult_Before_5(1, "person", "tuesday", 6);
            Assert.AreEqual(14.5, adult_before_5);
        }
    }
}
