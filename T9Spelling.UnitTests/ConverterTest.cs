using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace T9Spelling.UnitTests
{
    [TestClass]
    public class ConverterTest
    {
        [TestMethod]
        public void ConvertStringToNumbersTest()
        {
            // arrange
            var inputString = "hello world";
            var converter = new StringConverter();
            // act
            var outputString = converter.Convert(inputString);
            // assert
            Assert.AreEqual(outputString.ToString(), "4433555 555666096667775553");
        }

        [TestMethod]
        public void CheckInputStringLengthTest()
        {
            // arrange
            var inputString = "h";
            var converter = new StringConverter();
            // act
            var outputString = converter.Convert(inputString);
            // assert
            Assert.AreEqual(outputString.ToString(), "The string length very short. It should be greater than 1 and less than 15 characters");
        }

        [TestMethod]
        public void ConvertIntToNumberTest()
        {
            // arrange
            var inputString = "4";
            var converter = new StringConverter();
            // act
            var outputString = converter.Convert(inputString);
            // assert
            Assert.AreEqual(outputString.ToString(), "Please, enter not numeric characters");
        }
    }
}
