using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreditCardChecksum.Tests.Controllers
{
    [TestClass]
    public class CreditCardChecksumTest
    {
        [TestMethod]
        public void InValidCreditCardNumber()
        {
            // Arrange
            var creditCardChecksum = new CreditCardChecksum.Controllers.CreditCardChecksumController();

            // Act
            var result = creditCardChecksum.Get("1111111111111111");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("No", result);
        }

        [TestMethod]
        public void ValidNumber()
        {
            // Arrange
            var creditCardChecksum = new CreditCardChecksum.Controllers.CreditCardChecksumController();

            // Act
            var result = creditCardChecksum.Get("49927398716");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Yes", result);
        }

        [TestMethod]
        public void ValidCreditCardNumber()
        {
            // Arrange
            var creditCardChecksum = new CreditCardChecksum.Controllers.CreditCardChecksumController();

            // Act
            var result = creditCardChecksum.Get("4227965113713229");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Yes", result);
        }

        [TestMethod]
        public void ValidCreditCardNumberAnother()
        {
            // Arrange
            var creditCardChecksum = new CreditCardChecksum.Controllers.CreditCardChecksumController();

            // Act
            var result = creditCardChecksum.Get("4628655213710895");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Yes", result);
        }

        [TestMethod]
        public void ValidCreditCardNumberNull()
        {
            // Arrange
            var creditCardChecksum = new CreditCardChecksum.Controllers.CreditCardChecksumController();

            // Act
            var result = creditCardChecksum.Get(null);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("No", result);
        }

        [TestMethod]
        public void ValidCreditCardNumberEmptyString()
        {
            // Arrange
            var creditCardChecksum = new CreditCardChecksum.Controllers.CreditCardChecksumController();

            // Act
            var result = creditCardChecksum.Get("");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("No", result);
        }
    }
}
