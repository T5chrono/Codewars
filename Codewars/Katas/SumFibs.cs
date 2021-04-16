using System.Collections.Generic;
using System.Linq;

namespace Codewars.Katas
{
    public class SumFibs
    {
        public static int SumEvenFibsUpTo(int fibIndex)
        {
            var fibSequence = CreateFibSequence(fibIndex);
            return fibSequence.Where(x => x % 2 == 0).Sum();
        }

        private static List<int> CreateFibSequence(int fibIndex)
        {
            var fibSequence = new List<int>();

            if (fibIndex < 0) return fibSequence;
            if (fibIndex == 0) return new List<int> { 0 };
            if (fibIndex == 1) return new List<int> { 0, 1 };

            fibSequence.Add(0);
            fibSequence.Add(1);

            for (int i = 2; i <= fibIndex; i++)
            {
                fibSequence.Add(fibSequence[i - 1] + fibSequence[i - 2]);
            }

            return fibSequence;
        }
    }
}
