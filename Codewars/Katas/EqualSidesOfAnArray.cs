using System.Linq;

namespace Codewars.Katas
{
    class EqualSidesOfAnArray
    {
        public static int FindEvenIndex(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                for (int j = 0; j < i; j++)
                    leftSum += array[j];

                int rightSum = 0;
                for (int j = i + 1; j < array.Length; j++)
                    rightSum += array[j];

                if (leftSum == rightSum) return i;
            }
            return -1;
        }

        public static int FindEvenIndexClever(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                if (array.Take(i).Sum() == array.Skip(i + 1).Sum()) 
                    return i;
            }
            return -1;
        }
    }
}
