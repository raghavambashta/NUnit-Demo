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
        public void Test1()
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
    }
}