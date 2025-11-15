using AppCore.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections;
using System.Collections.Generic;

namespace AppCore.BLLTests
{
    [TestClass]
    public class UnitTest1
    {
        public static IEnumerable<object[]> AddTestData =>
            new List<object[]>
            {
                new object[]{ 1, 2, 3 },
                new object[]{ 10, -2, 8 },
            };

        [DataTestMethod]
        //[DataRow(1, 2, 3)]
        //[DataRow(10, -2, 18)]
        [DynamicData(nameof(AddTestDataClass.GetAddTestData), 
            typeof(AddTestDataClass), 
            DynamicDataSourceType.Method)]
        public void AddTest(int a, int b, int expected)
        {
            //Arrange
            Logic logic = new Logic();

            //Act
            var actualt = logic.Add(a, b);

            //Assert
            Assert.AreEqual(expected, actualt);
        }

        [TestMethod]
        public void GetRandomWordTest()
        {
            //Arrange
            Logic logic = new Logic();
            var words = new string[] { "ATH", "C#", "Tests" };
            string expected = "ATH";
           
            //Act
            var actual = logic.GetRandomWord(words);

            //Assert
            //Assert.AreEqual(expected, actual);
            CollectionAssert.Contains(words, actual);
        }

        [TestMethod]
        public void GetRandomWordTestWithMock()
        {
            //Arrange
            Mock<Logic> mock = new Mock<Logic>();
            mock.Setup(n => n.GetRandom(It.IsAny<int>())).Returns(0);

            var words = new string[] { "ATH", "C#", "Tests" };
            string expected = "ATH";

            //Act
            var actual = mock.Object.GetRandomWord(words);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
