using System;
using System.Linq;

namespace Codewars.Katas
{
    class TheSupermarketQueue
    {
        public static long QueueTime(int[] customers, int nCheckout)
        {
            if (customers.Length == 0) return 0;

            var splitCheckouts = new int[nCheckout];
            foreach (var customerValue in customers)
            {
                var minIndex = Array.IndexOf(splitCheckouts, splitCheckouts.Min());
                splitCheckouts[minIndex] += customerValue;
            }

            return splitCheckouts.Max();
        }
    }
}
