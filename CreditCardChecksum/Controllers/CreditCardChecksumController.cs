using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CreditCardChecksum.Controllers
{
    public class CreditCardChecksumController : ApiController
    {
        // An implementation of the Luhn algorithm as a Web API method
        // https://en.wikipedia.org/wiki/Luhn_algorithm

        // Constants
        private const string NoResponse = "No";
        private const string YesResponse = "Yes";

        /// <summary>
        /// Return a "Yes" or "No" string indicating whether the credit card number passed into the method passes the Luhn check and is a valid number
        /// </summary>
        /// <param name="creditCardNumber">a 16 digit credit card number although there is no specific validation of the number of digits supplied</param>
        /// <returns></returns>
        public string Get(string creditCardNumber)
        {
            // Validate the credit card number
            if (creditCardNumber == null) return NoResponse;                    // TODO throw exception because we weren't expecting a null value?
            if (creditCardNumber == string.Empty) return NoResponse;            // TODO throw exception because we weren't expecting an empty string?

            var reverseCreditCardNumber = Utils.Utils.ReverseDigits(creditCardNumber);

            // Calculate the first part of the checksum from the sum of the integer values of the reversed odd digits in the credit card number
            var oddDigits = Utils.Utils.GetDigits(reverseCreditCardNumber, Utils.Utils.ExtractMethods.Odd);
            var oddDigitsList = Utils.Utils.ConvertStringIntoListofIntegers(oddDigits);
            var oddDigitsSum = oddDigitsList.Sum();

            // Calculate the second part of the checksum from the reversed even digits in the credit card number
            var evenDigits = Utils.Utils.GetDigits(reverseCreditCardNumber, Utils.Utils.ExtractMethods.Even);
            var evenDigitsList = Utils.Utils.ConvertStringIntoListofIntegers(evenDigits);

            // Multiply each even digit by 2 and instead sum the two digits if the result is greater than 9
            var sumDigitsList = new List<int>();
            foreach (var evenDigit in evenDigitsList)
            {
                var sum = evenDigit * 2;

                if (sum > 9) sum = sum.ToString().Sum(digit => (int)char.GetNumericValue(digit));

                sumDigitsList.Add(sum);
            }

            var evenDigitsSum = sumDigitsList.Sum();

            // If the sum of the two sums(!) ends in zero this is a valid credit card number
            return (oddDigitsSum + evenDigitsSum) % 10 == 0 ? YesResponse : NoResponse;
        }
    }
}
