global using Microsoft.VisualStudio.TestTools.UnitTesting;
global using AreaLib;

namespace AreaLibTests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Area_5_Return_78_54()
        {
            // arrange
            var circle = new Circle(5);
            double expected = 78.54;

            // act
            double result = circle.CalcArea();

            // assert
            Assert.AreEqual(expected, result);
        }

    }

    [TestClass]
    public class Triangletests
    {
        [TestMethod]
        public void Area_3_and_7_and_7_Return_10_25()
        {
            //arrange
            var triangle = new Triangle(3, 7, 7);
            double expected = 10.26;

            //act
            var result = triangle.CalcArea();

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsRectangular_Straight_ReturnTrue()
        {
            // arrange
            var triangle = new Triangle(3, 4, 5);

            // act
            var result = triangle.IsRectangular();

            // assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsRectangular_NotStraight_ReturnFalse()
        {
            // arrange
            var triangle = new Triangle(3, 5, 5);

            // act
            var result = triangle.IsRectangular();

            // assert
            Assert.IsFalse(result);
        }


    }

}