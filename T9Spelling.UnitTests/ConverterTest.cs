using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace T9Spelling.UnitTests
{
    [TestClass]
    public class ConverterTest
    {
        private readonly IUnitOfWork _unitOfWork;

        public ConverterTest()
        {
            _unitOfWork = new UnitOfWork();
        }

        [TestMethod]
        public void ConvertStringToNumbersTest()
        {
            // arrange
            var inputString = "Hello world";
            // act
            var outputString = _unitOfWork.Converter.Convert(inputString.ToLower());
            // assert
            Assert.AreEqual(outputString.ToString(), "4433555 555666096667775553");
        }

        [TestMethod]
        public void CheckInputStringLengthTest()
        {
            // arrange
            var inputString = "h";
            // act
            var outputString = _unitOfWork.Converter.Convert(inputString);
            // assert
            Assert.AreEqual(outputString.ToString(), "The string length very short. It should be greater than 1 and less than 15 characters");
        }

        [TestMethod]
        public void ConvertIntToNumberTest()
        {
            // arrange
            var inputString = "4";
            // act
            var outputString = _unitOfWork.Converter.Convert(inputString);
            // assert
            Assert.AreEqual(outputString.ToString(), "Please, enter not numeric characters");
        }
    }
}
