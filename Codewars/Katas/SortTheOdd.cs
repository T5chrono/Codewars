using System.Collections.Generic;
using System.Linq;

namespace Codewars.Katas
{
    public class SortTheOdd
    {
        public static int[] SortArray(int[] array)
        {
            var onlyOddNumbers = new List<int>();
            var evenNumbersWithPosition = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    evenNumbersWithPosition.Add(i, array[i]);
                else
                    onlyOddNumbers.Add(array[i]);
            }

            var sortedOddNumbers = onlyOddNumbers.OrderBy(num => num).ToList();
            foreach (var number in evenNumbersWithPosition)
            {
                sortedOddNumbers.Insert(number.Key, number.Value);
            }
            return sortedOddNumbers.ToArray();
        }
    }
}
