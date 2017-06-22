﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CreditCardChecksum.Utils
{
    /// <summary>
    /// Utility classes to support validation
    /// </summary>
    public class Utils
    {
        public enum ExtractMethods
        {
            Odd,
            Even
        }

        /// <summary>
        /// Reverse the characters in a passed string
        /// </summary>
        /// <param name="inputString">A string of digits</param>
        /// <returns>The string of digits in reverse order</returns>
        public string ReverseDigits(string inputString)
        {
            if (inputString == null) return "";         // TODO throw exception because we weren't expecting a null value?

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
            if (inputString == null) return "";         // TODO throw exception because we weren't expecting a null value?

            var digits = inputString.ToList();

            if (digits.Count == 1) return new string(digits.ToArray());

            IEnumerable<char> extractedDigits = new List<char>();

            if (method == ExtractMethods.Odd) extractedDigits = digits.Where(DigitIsOdd);
            if (method == ExtractMethods.Even) extractedDigits = digits.Where(DigitIsEven);

            return string.Join("", extractedDigits);
        }

        private static bool DigitIsOdd(char x)
        {
            return Convert.ToInt32(x) % 2 != 0;
        }

        private static bool DigitIsEven(char x)
        {
            return Convert.ToInt32(x) % 2 == 0;
        }
    }
}