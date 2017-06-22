using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreditCardChecksum.Tests.Controllers
{
    [TestClass]
    public class UtilsTest
    {
        #region ReverseDigitsTests

        [TestMethod]
        public void ReverseDigitsThreeCharacters()
        {
            // Act
            var result = Utils.Utils.ReverseDigits("ABC");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("CBA", result);
        }

        [TestMethod]
        public void ReverseDigitsOneCharacter()
        {
            // Act
            var result = Utils.Utils.ReverseDigits("Z");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Z", result);
        }

        [TestMethod]
        public void ReverseDigitsOneDigit()
        {
            // Act
            var result = Utils.Utils.ReverseDigits("7");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("7", result);
        }

        [TestMethod]
        public void ReverseDigitsThreeDigits()
        {
            // Act
            var result = Utils.Utils.ReverseDigits("123");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("321", result);
        }

        [TestMethod]
        public void ReverseDigitsEmptyString()
        {
            // Act
            var result = Utils.Utils.ReverseDigits("");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void ReverseDigitsNull()
        {
            // Act
            var result = Utils.Utils.ReverseDigits(null);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("", result);
        }

        #endregion

        #region EvenDigitsTests

        [TestMethod]
        public void EvenDigitsEmptyString()
        {
            // Act
            var result = Utils.Utils.GetDigits("", Utils.Utils.ExtractMethods.Even);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void EvenDigitsNull()
        {
            // Act
            var result = Utils.Utils.GetDigits(null, Utils.Utils.ExtractMethods.Even);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void EvenDigitsThreeDigits()
        {
            // Act
            var result = Utils.Utils.GetDigits("355", Utils.Utils.ExtractMethods.Even);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("5", result);
        }

        [TestMethod]
        public void EvenDigitsSixDigits()
        {
            // Act
            var result = Utils.Utils.GetDigits("787878", Utils.Utils.ExtractMethods.Even);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("888", result);
        }

        [TestMethod]
        public void EvenDigitsOneDigit()
        {
            // Act
            var result = Utils.Utils.GetDigits("F", Utils.Utils.ExtractMethods.Even);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("F", result);
        }

        #endregion

        #region OddDigitsTests

        [TestMethod]
        public void OddDigitsEmptyString()
        {
            // Act
            var result = Utils.Utils.GetDigits("", Utils.Utils.ExtractMethods.Odd);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void OddDigitsNull()
        {
            // Act
            var result = Utils.Utils.GetDigits(null, Utils.Utils.ExtractMethods.Odd);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void OddDigitsThreeDigits()
        {
            // Act
            var result = Utils.Utils.GetDigits("123", Utils.Utils.ExtractMethods.Odd);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("13", result);
        }

        [TestMethod]
        public void OddDigitsOneDigit()
        {
            // Act
            var result = Utils.Utils.GetDigits("8", Utils.Utils.ExtractMethods.Odd);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("8", result);
        }

        #endregion

        #region ConvertStringIntoListOfIntegersTests

        [TestMethod]
        public void ConvertStringIntoListOfIntegersSingleDigit()
        {
            // Arrange
            var expected = new List<int> { 0 };

            // Act
            var result = Utils.Utils.ConvertStringIntoListofIntegers("0");

            // Assert
            Assert.IsNotNull(result);
            CollectionAssert.AreEqual(result, expected);
        }

        [TestMethod]
        public void ConvertStringIntoListOfIntegersThreeDigits()
        {
            // Arrange
            var expected = new List<int> { 5, 7, 4 };

            // Act
            var result = Utils.Utils.ConvertStringIntoListofIntegers("574");

            // Assert
            Assert.IsNotNull(result);
            CollectionAssert.AreEqual(result, expected);
        }

        [TestMethod]
        public void ConvertStringIntoListOfIntegersNull()
        {
            // Arrange
            var expected = new List<int>();

            // Act
            var result = Utils.Utils.ConvertStringIntoListofIntegers(null);

            // Assert
            Assert.IsNotNull(result);
            CollectionAssert.AreEqual(result, expected);
        }

        [TestMethod]
        public void ConvertStringIntoListOfIntegersEmptyString()
        {
            // Arrange
            var expected = new List<int>();

            // Act
            var result = Utils.Utils.ConvertStringIntoListofIntegers("");

            // Assert
            Assert.IsNotNull(result);
            CollectionAssert.AreEqual(result, expected);
        }

        #endregion
    }
}
