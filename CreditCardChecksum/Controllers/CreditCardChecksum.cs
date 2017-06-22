using System.Web.Http;

namespace CreditCardChecksum.Controllers
{
    public class CreditCardChecksum : ApiController
    {
        // An implementation of the Luhn algorithm as a Web API method
        // https://en.wikipedia.org/wiki/Luhn_algorithm

        /// <summary>
        /// Return a "Yes" or "No" string indicating whether the credit card number passed into the method passes the Luhn check and is a valid number
        /// </summary>
        /// <param name="creditCardNumber">a 16 digit credit card number although there is no specific validation of the number of digits supplied</param>
        /// <returns></returns>
        public string Get(string creditCardNumber)
        {
            return "value";
        }
    }
}