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
            var creditCardChecksum = new CreditCardChecksum.Controllers.CreditCardChecksum();

            // Act
            var result = creditCardChecksum.Get("1111111111111111");

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("No", result);
        }
    }
}
