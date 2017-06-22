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
            // Arrange
            var utils = new Utils.Utils();

            // Act
            var result = utils.ReverseDigits("ABC");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("CBA", result);
        }

        [TestMethod]
        public void ReverseDigitsOneCharacter()
        {
            // Arrange
            var utils = new Utils.Utils();

            // Act
            var result = utils.ReverseDigits("Z");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Z", result);
        }

        [TestMethod]
        public void ReverseDigitsOneDigit()
        {
            // Arrange
            var utils = new Utils.Utils();

            // Act
            var result = utils.ReverseDigits("7");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("7", result);
        }

        [TestMethod]
        public void ReverseDigitsThreeDigits()
        {
            // Arrange
            var utils = new Utils.Utils();

            // Act
            var result = utils.ReverseDigits("123");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("321", result);
        }

        [TestMethod]
        public void ReverseDigitsEmptyString()
        {
            // Arrange
            var utils = new Utils.Utils();

            // Act
            var result = utils.ReverseDigits("");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void ReverseDigitsNull()
        {
            // Arrange
            var utils = new Utils.Utils();

            // Act
            var result = utils.ReverseDigits(null);

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
            var result = Utils.Utils.GetDigits("ABC", Utils.Utils.ExtractMethods.Even);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("B", result);
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
            var result = Utils.Utils.GetDigits("ABC", Utils.Utils.ExtractMethods.Odd);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("AC", result);
        }

        [TestMethod]
        public void OddDigitsOneDigit()
        {
            // Act
            var result = Utils.Utils.GetDigits("F", Utils.Utils.ExtractMethods.Odd);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("F", result);
        }

        #endregion
    }
}
