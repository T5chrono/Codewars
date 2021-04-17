using System.Linq;

namespace Codewars.Katas
{
    class MonkeysMath01
    {
        public static readonly char[] singleZeros = "abdegopq069DOPQR".ToCharArray();
        public static readonly char[] doubleZeros = "%&B8".ToCharArray();
        public static readonly string specialZero = "()";

        public static int CountZero(string s)
        {
            var zeroCount = 0;
            if (s.Contains(specialZero)) zeroCount += 1;
            foreach (var symbol in s)
            {
                if (singleZeros.Contains(symbol))
                    zeroCount += 1;
                if (doubleZeros.Contains(symbol))
                    zeroCount += 2;
            }
            return zeroCount;
        }
    }
}
