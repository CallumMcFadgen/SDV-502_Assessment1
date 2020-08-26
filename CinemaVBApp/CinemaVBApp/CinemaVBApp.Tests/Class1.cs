using NUnit.Framework;
using System.Windows.Forms;

namespace CinemaApp.Tests
{
    [TestFixture]
    public class UnitTests
    {
        #region Adult_Before_5
        [Test]
        public void Adult_Before_5_Test1()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 1;
            string person = "adult";
            string day = "monday";
            decimal time = 4M;
            decimal expectedResult = 14.50M;

            // Act
            decimal actualResult = sut.Adult_Before_5(quantity, person, day, time);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Adult_Before_5_Test2()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 2;
            string person = "adult";
            string day = "monday";
            decimal time = 4M;
            decimal expectedResult = 29.00M;

            // Act
            decimal actualResult = sut.Adult_Before_5(quantity, person, day, time);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Adult_Before_5_Test3()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 0;
            string person = "adult";
            string day = "monday";
            decimal time = 4M;
            decimal expectedResult = 0M;

            // Act
            decimal actualResult = sut.Adult_Before_5(quantity, person, day, time);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Adult_Before_5_Test4()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 1;
            string person = "student";
            string day = "monday";
            decimal time = 4M;
            decimal expectedResult = 0M;

            // Act
            decimal actualResult = sut.Adult_Before_5(quantity, person, day, time);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //[Test]
        //public void Adult_Before_5_Test4()
        //{
        //    var sut = new Form();
        //    decimal adult_before_5 = sut.Adult_Before_5(0, "adult", "monday", 4);
        //    Assert.AreEqual(14.5, adult_before_5);
        //}

        //[Test]
        //public void Adult_Before_5_Test5()
        //{
        //    var sut = new Form();
        //    decimal adult_before_5 = sut.Adult_Before_5(1, "adult", "tuesday", 4);
        //    Assert.AreEqual(14.5, adult_before_5);
        //}
        #endregion

        #region Adult_After_5
        [Test]
        public void Adult_After_5_Test1()
        {
            var sut = new Form();
            decimal adult_after_5 = sut.Adult_After_5(1, "adult", "monday", 6);
            Assert.AreEqual(17.5, adult_after_5);
        }

        [Test]
        public void Adult_After_5_Test2()
        {
            var sut = new Form();
            decimal adult_after_5 = sut.Adult_After_5(1, "adult", "monday", 4);
            Assert.AreEqual(17.5, adult_after_5);
        }

        [Test]
        public void Adult_After_5_Test3()
        {
            var sut = new Form();
            decimal adult_after_5 = sut.Adult_After_5(1, "student", "monday", 6);
            Assert.AreEqual(17.5, adult_after_5);
        }

        [Test]
        public void Adult_After_5_Test4()
        {
            var sut = new Form();
            decimal adult_after_5 = sut.Adult_After_5(0, "adult", "monday", 6);
            Assert.AreEqual(17.5, adult_after_5);
        }

        [Test]
        public void Adult_After_5_Test5()
        {
            var sut = new Form();
            decimal adult_after_5 = sut.Adult_After_5(1, "adult", "tuesday", 4);
            Assert.AreEqual(17.5, adult_after_5);
        }
        #endregion

        #region Adult_Tuesday
        /*
        [Test]
        public void Adult_Tuesday1()
        {
            var sut = new Form();
            decimal adult_tuesday = sut.Adult_Tuesday(1, "adult", "tuesday");
            Assert.AreEqual(13.00, adult_tuesday);
        }

        [Test]
        public void Adult_Tuesday2()
        {
            var sut = new Form();
            decimal adult_tuesday = sut.Adult_Tuesday(1, "adult", "monday");
            Assert.AreEqual(13.00, adult_tuesday);
        }

        [Test]
        public void Adult_Tuesday3()
        {
            var sut = new Form();
            decimal adult_tuesday = sut.Adult_Tuesday(1, "student", "tuesday");
            Assert.AreEqual(13.00, adult_tuesday);
        }

        [Test]
        public void Adult_Tuesday4()
        {
            var sut = new Form();
            decimal adult_tuesday = sut.Adult_Tuesday(0, "adult", "tuesday");
            Assert.AreEqual(13.00, adult_tuesday);
        }
        */ 
        #endregion
    }
}
