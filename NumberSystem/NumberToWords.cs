using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystem
{
    public class NumberToWords
    {
        const long MILLION = 1000000;
        const long THOUSAND = 1000;
        const long HUNDRED = 100;

        static readonly string[] _smallNumbers = new string[]{ "Zero", "One", "Two", "Three", "Four", "Five",
                                                               "Six", "Seven", "Eight", "Nine", "Ten",
                                                               "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen",
                                                               "Sixteen", "Seventeen", "Eighteen", "Nineteen"
                                                             };

        static readonly string[] _tens = new string[] { "Zero", "Ten", "Twenty", "Thirty", "Forty",
                                                        "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        public static string Convert(long number)
        {
            if (number == 0)
            {
                return _smallNumbers[0];
            }

            // Negative numbers
            if (number < 0)
            {
                return "Minus " + Convert(Math.Abs(number));
            }

            StringBuilder words = new StringBuilder();
            if (number / MILLION > 0)
            {
                words.Append(Convert(number / MILLION) + " Million");
                number %= MILLION;

                if (number > 0)
                {
                    words.Append(", ");
                }
            }

            if (number / THOUSAND > 0)
            {
                words.Append(Convert(number / THOUSAND) + " Thousand");
                number %= THOUSAND;

                if (number > 0)
                {
                    words.Append(", ");
                }
            }

            if (number / HUNDRED > 0)
            {
                words.Append(Convert(number / HUNDRED) + " Hundred");
                number %= HUNDRED;

                if (number > 0)
                {
                    words.Append(" ");
                }
            }

            if (number > 0)
            {
                if (words.Length > 0)
                {
                    words.Append("and ");
                }

                if (number < 20)
                {
                    words.Append(_smallNumbers[number]);
                }
                else
                {
                    words.Append(_tens[number / 10]);
                    if (number % 10 > 0)
                    {
                        words.Append("-" + _smallNumbers[number % 10]);
                    }
                }
            }

            return words.ToString();
        }
    }
}
