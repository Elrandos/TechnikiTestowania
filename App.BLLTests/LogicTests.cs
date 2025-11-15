using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL.Tests
{
    [TestClass()]
    public class LogicTests
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\AddTestData.xml", 
            "case", 
            DataAccessMethod.Sequential), 
            DeploymentItem("AddTestData.xml"), TestMethod()]
        public void AddTest()
        {
            //Arrange
            Logic logic = new Logic();
            int a = Convert.ToInt32(TestContext.DataRow["a"]);
            int b = Convert.ToInt32(TestContext.DataRow["b"]);
            int expected = Convert.ToInt32(TestContext.DataRow["result"]);

            //Act
            int actual = logic.Add(a, b);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetItemsTest()
        {
            //Arrange
            Logic logic = new Logic();
            var expected = new int []{ 1, 2, 3 };

            //Act
            var actual = logic.GetItems().ToArray();

            //Assert
            Assert.IsNotNull(actual);
            //CollectionAssert.AreEqual(expected, actual);
            CollectionAssert.AreEquivalent(expected, actual);
        }
    }
}