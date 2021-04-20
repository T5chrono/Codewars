using System;
using System.Linq;

namespace Codewars.Katas
{
    public class TwistedSum
    {
        public static long Solution(long n)
        {
            var totalTwistedSum = 0;
            for (var i = 0; i <= n; i++)
            {
                var numberAsString = i.ToString();
                totalTwistedSum += numberAsString.Sum(digit => Convert.ToInt32(digit.ToString()));
            }

            return totalTwistedSum;
        }
    }
}
