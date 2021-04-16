using System;
using System.Linq;

namespace Codewars.Katas
{
    class BitCounting
    {
        public static int CountBits(int n)
        {
            var binaryRepresentation = Convert.ToString(n, 2);
            return binaryRepresentation.Count(digit => digit == '1');
        }
    }
}
