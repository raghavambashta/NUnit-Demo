using NUnit.Framework;
using System.Collections.Generic;
using MyAreas;
namespace TestMyAreas
{
    public class Tests
    {
        Areas areas;
        [SetUp]
        public void Setup()
        {
            areas = new Areas();
        }

        [TearDown]
        public void Close()
        {
            areas = null;
        }

        [Test]
        public void DemoTest()
        {
            Assert.Pass();
        }

        [Test]
        public void CircleTest()
        {
            //Arrange
            float expresult = 75;
            float actresult;

            //Act
            actresult = areas.Circle(5);

            //Assert
            Assert.AreEqual(expresult, actresult, 5, "Areas not matching");
        }

        [Test]
        public void TriangleTest()
        {
            float expresult = 12;
            float actresult;

            actresult = areas.Triangle(8, 4);

            Assert.AreEqual(expresult, actresult, 5, "Areas not matching");
        }

        [TestCase(30, 20, ExpectedResult = 600)]
        [TestCase(40, 10, ExpectedResult = 300)]
        [TestCase(25, 25, ExpectedResult = 630)]
        [TestCase(90, 90, ExpectedResult = 8100)]
        [TestCase(60, 60, ExpectedResult = 3600)]
        public int RectangleTest (int l, int b)
        {
            int actresult = areas.Rectangle(l, b);
            return actresult;
        }

        [Test]
        public void Login_Null_Message()
        {
            string expresult = "username or password is null";
            string actresult = areas.Login("Tom", null);
            Assert.AreEqual(expresult, actresult, "Messages not matching");
        }

        [Test]
        public void Login_Admin_Success_Message()
        {
            string expresult = "Welcome Admin !";
            string actresult = areas.Login("Admin", "admin");
            Assert.AreEqual(expresult, actresult, "Messages not proper");
        }

        [Test]
        public void Login_Invalid_Message()
        {
            //string expresult = "Welcome Admin !";
            string actresult = areas.Login("Tom", "tom123");
            Assert.AreEqual("Invalid", actresult);
        }

        [Test]
        public void Names_Contains_Null()
        {
            List<string> names = areas.GetNames();
            CollectionAssert.AllItemsAreNotNull(names, "Null values present");
        }

        [Test]
        public void Names_are_Unique()
        {
            List<string> names = areas.GetNames();
            CollectionAssert.AllItemsAreUnique(names, "Unique items are NOT present");
        }
    }
}