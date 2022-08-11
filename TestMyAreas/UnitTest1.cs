using NUnit.Framework;
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
    }
}