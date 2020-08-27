using NUnit.Framework;
using System.Windows.Forms;

namespace CinemaApp.Tests
{
    [TestFixture]
    public class UnitTests
    {
        #region Adult_Before_5 Tests
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
            decimal expectedResult = -1;

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
            decimal expectedResult = -1;

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
            decimal expectedResult = -1;

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
            decimal expectedResult = -1;

            // Act
            decimal actualResult = sut.Adult_Before_5(quantity, person, day, time);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        #endregion

        #region Adult_After_5 Tests
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
            decimal expectedResult = -1;

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
            decimal expectedResult = -1;

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
            decimal expectedResult = -1;

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
            decimal expectedResult = -1;

            // Act
            decimal actualResult = sut.Adult_After_5(quantity, person, day, time);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        #endregion

        #region Adult_Tuesday Tests
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
            decimal expectedResult = -1;

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
            int quantity = 1;
            string person = "student";
            string day = "tuesday";
            decimal expectedResult = -1;

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
            int quantity = 1;
            string person = "adult";
            string day = "monday";
            decimal expectedResult = -1;

            // Act
            decimal actualResult = sut.Adult_Tuesday(quantity, person, day);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        #endregion

        #region Child_Under_16 Tests
        [Test]
        public void Child_Under_16_1()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 1;
            string person = "child";
            decimal expectedResult = 12.00M;

            // Act
            decimal actualResult = sut.Child_Under_16(quantity, person);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Child_Under_16_2()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 2;
            string person = "child";
            decimal expectedResult = 24.00M;

            // Act
            decimal actualResult = sut.Child_Under_16(quantity, person);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Child_Under_16_3()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 0;
            string person = "child";
            decimal expectedResult = -1;

            // Act
            decimal actualResult = sut.Child_Under_16(quantity, person);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Child_Under_16_4()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 1;
            string person = "adult";
            decimal expectedResult = -1;

            // Act
            decimal actualResult = sut.Child_Under_16(quantity, person);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        #endregion

        #region Senior Tests
        [Test]
        public void Senior1()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 1;
            string person = "senior";
            decimal expectedResult = 12.50M;

            // Act
            decimal actualResult = sut.Senior(quantity, person);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Senior2()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 2;
            string person = "senior";
            decimal expectedResult = 25.00M;

            // Act
            decimal actualResult = sut.Senior(quantity, person);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Senior3()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 0;
            string person = "senior";
            decimal expectedResult = -1;

            // Act
            decimal actualResult = sut.Senior(quantity, person);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Senior4()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 1;
            string person = "adult";
            decimal expectedResult = -1;

            // Act
            decimal actualResult = sut.Senior(quantity, person);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        #endregion

        #region Student Tests
        [Test]
        public void Student1()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 1;
            string person = "student";
            decimal expectedResult = 14.00M;

            // Act
            decimal actualResult = sut.Student(quantity, person);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Student2()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 2;
            string person = "student";
            decimal expectedResult = 28.00M;

            // Act
            decimal actualResult = sut.Student(quantity, person);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Student3()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 0;
            string person = "student";
            decimal expectedResult = -1;

            // Act
            decimal actualResult = sut.Student(quantity, person);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Student4()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 1;
            string person = "adult";
            decimal expectedResult = -1;

            // Act
            decimal actualResult = sut.Senior(quantity, person);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        #endregion

        #region Family_Pass Tests
        [Test]
        public void Family_Pass1()
        {
            // Arrange
            Form sut = new Form();
            int quantity_ticket = 1;
            int quantity_adult = 2;
            int quantity_child = 2;
            decimal expectedResult = 46.00M;

            // Act
            decimal actualResult = sut.Family_Pass(quantity_ticket, quantity_adult, quantity_child);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Family_Pass2()
        {
            // Arrange
            Form sut = new Form();
            int quantity_ticket = 2;
            int quantity_adult = 2;
            int quantity_child = 2;
            decimal expectedResult = 92.00M;

            // Act
            decimal actualResult = sut.Family_Pass(quantity_ticket, quantity_adult, quantity_child);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Family_Pass3()
        {
            // Arrange
            Form sut = new Form();
            int quantity_ticket = 1;
            int quantity_adult = 3;
            int quantity_child = 2;
            decimal expectedResult = -1;

            // Act
            decimal actualResult = sut.Family_Pass(quantity_ticket, quantity_adult, quantity_child);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Family_Pass4()
        {
            // Arrange
            Form sut = new Form();
            int quantity_ticket = 1;
            int quantity_adult = 3;
            int quantity_child = 2;
            decimal expectedResult = -1;

            // Act
            decimal actualResult = sut.Family_Pass(quantity_ticket, quantity_adult, quantity_child);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Family_Pass5()
        {
            // Arrange
            Form sut = new Form();
            int quantity_ticket = 1;
            int quantity_adult = 1;
            int quantity_child = 3;
            decimal expectedResult = 46.00M;

            // Act
            decimal actualResult = sut.Family_Pass(quantity_ticket, quantity_adult, quantity_child);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Family_Pass6()
        {
            // Arrange
            Form sut = new Form();
            int quantity_ticket = 2;
            int quantity_adult = 1;
            int quantity_child = 3;
            decimal expectedResult = 92.00M;

            // Act
            decimal actualResult = sut.Family_Pass(quantity_ticket, quantity_adult, quantity_child);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Family_Pass7()
        {
            // Arrange
            Form sut = new Form();
            int quantity_ticket = 0;
            int quantity_adult = 1;
            int quantity_child = 3;
            decimal expectedResult = -1;

            // Act
            decimal actualResult = sut.Family_Pass(quantity_ticket, quantity_adult, quantity_child);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Family_Pass8()
        {
            // Arrange
            Form sut = new Form();
            int quantity_ticket = 1;
            int quantity_adult = 0;
            int quantity_child = 4;
            decimal expectedResult = -1;

            // Act
            decimal actualResult = sut.Family_Pass(quantity_ticket, quantity_adult, quantity_child);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Family_Pass9()
        {
            // Arrange
            Form sut = new Form();
            int quantity_ticket = 1;
            int quantity_adult = 4;
            int quantity_child = 0;
            decimal expectedResult = -1;

            // Act
            decimal actualResult = sut.Family_Pass(quantity_ticket, quantity_adult, quantity_child);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        #endregion

        #region Chick_Flick_Thursday Tests
        [Test]
        public void Chick_Flick_Thursday1()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 1;
            string person = "adult";
            string day = "thursday";
            decimal expectedResult = 21.50M;

            // Act
            decimal actualResult = sut.Chick_Flick_Thursday(quantity, person, day);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Chick_Flick_Thursday2()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 2;
            string person = "adult";
            string day = "thursday";
            decimal expectedResult = 43.00M;

            // Act
            decimal actualResult = sut.Chick_Flick_Thursday(quantity, person, day);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Chick_Flick_Thursday3()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 0;
            string person = "adult";
            string day = "thursday";
            decimal expectedResult = -1;

            // Act
            decimal actualResult = sut.Chick_Flick_Thursday(quantity, person, day);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Chick_Flick_Thursday4()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 1;
            string person = "student";
            string day = "thursday";
            decimal expectedResult = -1;

            // Act
            decimal actualResult = sut.Chick_Flick_Thursday(quantity, person, day);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Chick_Flick_Thursday5()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 1;
            string person = "adult";
            string day = "wednesday";
            decimal expectedResult = -1;

            // Act
            decimal actualResult = sut.Chick_Flick_Thursday(quantity, person, day);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        #endregion

        #region Kids_Careers Tests
        [Test]
        public void Kids_Careers1()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 1;
            string day = "wednesday";
            bool holiday = false;
            decimal expectedResult = 12.00M;

            // Act
            decimal actualResult = sut.Kids_Careers(quantity, day, holiday);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Kids_Careers2()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 2;
            string day = "wednesday";
            bool holiday = false;
            decimal expectedResult = 24.00M;

            // Act
            decimal actualResult = sut.Kids_Careers(quantity, day, holiday);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Kids_Careers3()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 0;
            string day = "wednesday";
            bool holiday = false;
            decimal expectedResult = -1;

            // Act
            decimal actualResult = sut.Kids_Careers(quantity, day, holiday);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Kids_Careers4()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 1;
            string day = "tuesday";
            bool holiday = false;
            decimal expectedResult = -1;

            // Act
            decimal actualResult = sut.Kids_Careers(quantity, day, holiday);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Kids_Careers5()
        {
            // Arrange
            Form sut = new Form();
            int quantity = 1;
            string day = "wednesday";
            bool holiday = true;
            decimal expectedResult = -1;

            // Act
            decimal actualResult = sut.Kids_Careers(quantity, day, holiday);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        #endregion
    }
}
