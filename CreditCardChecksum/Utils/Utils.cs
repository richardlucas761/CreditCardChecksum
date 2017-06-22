using System.Collections.Generic;
using System.Linq;

namespace CreditCardChecksum.Utils
{
    /// <summary>
    /// Utility classes to support validation
    /// </summary>
    public class Utils
    {
        /// <summary>
        /// Digit extraction methods
        /// </summary>
        public enum ExtractMethods
        {
            Odd,
            Even
        }

        /// <summary>
        /// Convert a string into a list of integers
        /// </summary>
        /// <param name="inputString">A string to turn into integers</param>
        /// <returns>A list of integers</returns>
        public static List<int> ConvertStringIntoListofIntegers(string inputString)
        {
            if (inputString == null)
                return new List<int>(); // TODO throw exception because we weren't expecting a null value?

            var enumerable = inputString.ToArray();
            return enumerable.Select(character => (int)char.GetNumericValue(character)).ToList();
        }

        /// <summary>
        /// Reverse the characters in a passed string
        /// </summary>
        /// <param name="inputString">A string of digits</param>
        /// <returns>The string of digits in reverse order</returns>
        public static string ReverseDigits(string inputString)
        {
            if (inputString == null) return ""; // TODO throw exception because we weren't expecting a null value?

            var reverseList = inputString.ToList();
            reverseList.Reverse();

            return new string(reverseList.ToArray());
        }

        /// <summary>
        /// Get digits from a string using a specified method to determine which characters to return, odd or even
        /// </summary>
        /// <param name="inputString">A string to return digits from</param>
        /// <param name="method">Return the odd or even digits</param>
        /// <returns>The odd or even digits from the string</returns>
        public static string GetDigits(string inputString, ExtractMethods method)
        {
            if (inputString == null) return ""; // TODO throw exception because we weren't expecting a null value?

            var digits = inputString.ToList();

            if (digits.Count == 1) return new string(digits.ToArray());

            var extractedDigits = new List<char>();

            for (var i = 0; i < digits.Count; i++)
            {
                if (method == ExtractMethods.Odd && i % 2 == 0)         // Looks odd but it's a zero based array
                {
                    extractedDigits.Add(digits[i]);
                }

                if (method == ExtractMethods.Even && i % 2 != 0)         // Looks odd but it's a zero based array
                {
                    extractedDigits.Add(digits[i]);
                }
            }

            return string.Join("", extractedDigits);
        }
    }
}