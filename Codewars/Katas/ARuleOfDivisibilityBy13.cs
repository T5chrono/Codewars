using System;

namespace Codewars.Katas
{
    class ARuleOfDivisibilityBy13
    {
        private static readonly int[] Mods = { 1, 10, 9, 12, 3, 4};

        public static long Thirt(long n)
        {
            long remainder = n;
            Console.WriteLine(n);

            long newRemainder = 0;

            while (remainder != newRemainder)
            {
                var reversedNumber = ReverseTheNumber(remainder);
                for (int i = 0; i < reversedNumber.Length; i++)
                {
                    newRemainder += (int)char.GetNumericValue(reversedNumber[i]) * Mods[i%6];
                }

                if (remainder != newRemainder)
                {
                    remainder = newRemainder;
                    newRemainder = 0;
                }
            }

            return remainder;
        }

        private static string ReverseTheNumber(long number)
        {
            var stringNumber = Convert.ToString(number);
            char[] charArray = stringNumber.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private static long ReverseTheNumberByMath(long number)
        {
            long reversedLongNumber = 0;

            while (number > 0)
            {
                reversedLongNumber = reversedLongNumber * 10 + number % 10;
                number = number / 10;
            }

            return reversedLongNumber;
        }
    }
}
