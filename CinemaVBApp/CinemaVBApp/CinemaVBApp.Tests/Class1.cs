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

        [Test]
        public void Adult_Before_5_Test5()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 1;
            string person = "adult";
            string day = "tuesday";
            decimal time = 4M;
            decimal expectedResult = 0M;

            // Act
            decimal actualResult = sut.Adult_Before_5(quantity, person, day, time);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Adult_Before_5_Test6()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 1;
            string person = "adult";
            string day = "monday";
            decimal time = 6M;
            decimal expectedResult = 0M;

            // Act
            decimal actualResult = sut.Adult_Before_5(quantity, person, day, time);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        #endregion

        #region Adult_After_5
        [Test]
        public void Adult_After_5_Test1()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 1;
            string person = "adult";
            string day = "monday";
            decimal time = 6M;
            decimal expectedResult = 17.50M;

            // Act
            decimal actualResult = sut.Adult_After_5(quantity, person, day, time);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Adult_After_5_Test2()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 2;
            string person = "adult";
            string day = "monday";
            decimal time = 6M;
            decimal expectedResult = 35.00M;

            // Act
            decimal actualResult = sut.Adult_After_5(quantity, person, day, time);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Adult_After_5_Test3()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 0;
            string person = "adult";
            string day = "monday";
            decimal time = 6M;
            decimal expectedResult = 0M;

            // Act
            decimal actualResult = sut.Adult_After_5(quantity, person, day, time);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Adult_After_5_Test4()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 1;
            string person = "student";
            string day = "monday";
            decimal time = 6M;
            decimal expectedResult = 0M;

            // Act
            decimal actualResult = sut.Adult_After_5(quantity, person, day, time);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Adult_After_5_Test5()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 1;
            string person = "adult";
            string day = "tuesday";
            decimal time = 6M;
            decimal expectedResult = 0M;

            // Act
            decimal actualResult = sut.Adult_After_5(quantity, person, day, time);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Adult_After_5_Test6()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 1;
            string person = "adult";
            string day = "monday";
            decimal time = 4M;
            decimal expectedResult = 0M;

            // Act
            decimal actualResult = sut.Adult_After_5(quantity, person, day, time);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        #endregion

        #region Adult_Tuesday
        [Test]
        public void Adult_Tuesday1()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 1;
            string person = "adult";
            string day = "tuesday";
            decimal expectedResult = 13.00M;

            // Act
            decimal actualResult = sut.Adult_Tuesday(quantity, person, day);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Adult_Tuesday2()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 2;
            string person = "adult";
            string day = "tuesday";
            decimal expectedResult = 26.00M;

            // Act
            decimal actualResult = sut.Adult_Tuesday(quantity, person, day);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Adult_Tuesday3()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 0;
            string person = "adult";
            string day = "tuesday";
            decimal expectedResult = 0M;

            // Act
            decimal actualResult = sut.Adult_Tuesday(quantity, person, day);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Adult_Tuesday4()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 0;
            string person = "student";
            string day = "tuesday";
            decimal expectedResult = 0M;

            // Act
            decimal actualResult = sut.Adult_Tuesday(quantity, person, day);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Adult_Tuesday5()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 0;
            string person = "adult";
            string day = "monday";
            decimal expectedResult = 0M;

            // Act
            decimal actualResult = sut.Adult_Tuesday(quantity, person, day);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        #endregion





    }
}
