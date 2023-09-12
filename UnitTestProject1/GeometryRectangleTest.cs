using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleAreaLibrary;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class GeometryRectangleTest
    {
        [TestMethod]
        public void RectangleArea_GivedPositiveNumberStrings_ReturnSuccessResult()
        {
            // arrange
            double width = 6;
            double height = 6;

            string widthString =width.ToString();
            string heightString =height.ToString();

            double exprected = 36;

            // act
            double result = new GeometryRectangle().RectangleArea(widthString,heightString);

            // assert
            Assert.AreEqual(exprected, result);
        }

        [TestMethod]
        public void RectangleArea_GivedStringsWithLetters_ThrowsException()
        {
            // arrange
            string widthString = "asd";
            string heightString = "23";

            var geometry = new GeometryRectangle();

            // act
            Action result = () => geometry.RectangleArea(widthString, heightString);

            // assert
            Assert.ThrowsException<Exception>(result);
        }

        [TestMethod]
        public void RectangleArea_GivedPositiveDoubleNumberStrings_ReturnSuccessResult()
        {
            // arrange
            string widthString = "1.5";
            string heightString = "1,5";

            double exprected = 2.25;

            // act
            double result = new GeometryRectangle().RectangleArea(widthString, heightString);

            // assert
            Assert.AreEqual(exprected, result);
        }
        [TestMethod]
        public void RectangleArea_GivedPositiveDoubleNumberAndNumberStrings_ReturnSuccessResult()
        {
            // arrange
            string widthString = "1,5";
            string heightString = "6";

            double exprected = 9;

            // act
            double result = new GeometryRectangle().RectangleArea(widthString, heightString);

            // assert
            Assert.AreEqual(exprected, result);
        }
        [TestMethod]
        public void RectangleArea_GivedPositiveNumberAndDoubleNumberStrings_ReturnSuccessResult()
        {
            // arrange
            string widthString = "6";
            string heightString = "1.5";

            double exprected = 9;

            // act
            double result = new GeometryRectangle().RectangleArea(widthString, heightString);

            // assert
            Assert.AreEqual(exprected, result);
        }
        [TestMethod]
        public void RectangleArea_GivedStringsWithZero_ThrowsException()
        {
            // arrange
            string widthString = "0";
            string heightString = "0";

            var geometry = new GeometryRectangle();

            // act
            Action result = () => geometry.RectangleArea(widthString, heightString);

            // assert
            Assert.ThrowsException<Exception>(result);
        }
        [TestMethod]
        public void RectangleArea_GivedStringsWithNumberAndEmptyString_ThrowsException()
        {
            // arrange
            string widthString = "";
            string heightString = "5";

            var geometry = new GeometryRectangle();

            // act
            Action result = () => geometry.RectangleArea(widthString, heightString);

            // assert
            Assert.ThrowsException<Exception>(result);
        }
        [TestMethod]
        public void RectangleArea_GivedStringsWithEmptyStringAndNumber_ThrowsException()
        {
            // arrange
            string widthString = "5";
            string heightString = "";

            var geometry = new GeometryRectangle();

            // act
            Action result = () => geometry.RectangleArea(widthString, heightString);

            // assert
            Assert.ThrowsException<Exception>(result);
        }
        [TestMethod]
        public void RectangleArea_GivedStringsWithNegativeNumberAndDoubleNumber_ThrowsException()
        {
            // arrange
            string widthString = "-5";
            string heightString = "2,5";

            var geometry = new GeometryRectangle();

            // act
            Action result = () => geometry.RectangleArea(widthString, heightString);

            // assert
            Assert.ThrowsException<Exception>(result);
        }
        [TestMethod]
        public void RectangleArea_GivedStringsWithZeroAndPositiveDoubleNumber_ThrowsException()
        {
            // arrange
            string widthString = "0";
            string heightString = "2,5";

            var geometry = new GeometryRectangle();

            // act
            Action result = () => geometry.RectangleArea(widthString, heightString);

            // assert
            Assert.ThrowsException<Exception>(result);
        }
        [TestMethod]
        public void RectangleArea_GivedStringsWithNigativeDuobleNumber1AndNegativeDoubleNumber2_ThrowsException()
        {
            // arrange
            string widthString = "-1,5";
            string heightString = "-1.5";

            var geometry = new GeometryRectangle();

            // act
            Action result = () => geometry.RectangleArea(widthString, heightString);

            // assert
            Assert.ThrowsException<Exception>(result);
        }
        [TestMethod]
        public void RectangleArea_GivedStringsWithSringandNumberAndPositiveNumber_ThrowsException()
        {
            // arrange
            string widthString = "abc123";
            string heightString = "5";

            var geometry = new GeometryRectangle();

            // act
            Action result = () => geometry.RectangleArea(widthString, heightString);

            // assert
            Assert.ThrowsException<Exception>(result);
        }
        [TestMethod]
        public void RectangleArea_GivedStringsWithPositiveNumberAndNumberandSpecialSymbol_ThrowsException()
        {
            // arrange
            string widthString = "1,5";
            string heightString = "5$%";

            var geometry = new GeometryRectangle();

            // act
            Action result = () => geometry.RectangleArea(widthString, heightString);

            // assert
            Assert.ThrowsException<Exception>(result);
        }
        [TestMethod]
        public void RectangleArea_GivedStringsWithPositiveLongDuobleNumberAndNumber_ReturnSuccessfulResult()
        {
            // arrange
            string widthString = "1,1111111111111111111";
            string heightString = "5";

            double expected = double.Parse(widthString) * double.Parse(heightString);

            var geometry = new GeometryRectangle();

            // act
            var result = geometry.RectangleArea(widthString, heightString);

            // assert
            Assert.AreEqual(expected, result);
        }

    }
}
