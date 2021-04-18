using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars.Katas
{
    public class GroupingConsecutiveNumbers
    {
        public static string GenerateGroupings(int[] input)
        {
            if (input.Length == 1) return $"{input[0]}";

            var sortedInput = input.OrderBy(n => n).ToArray();

            var firstDigit = sortedInput[0];
            var lastDigit = 0;

            var listOfRanges = new List<string>();
            for (int i = 0; i < sortedInput.Length - 1; i++)
            {
                if (sortedInput[i + 1] - sortedInput[i] <= 1)
                {
                    lastDigit = sortedInput[i + 1];
                    if (sortedInput.Length == i + 2)
                        AddRange(sortedInput, ref firstDigit, ref lastDigit, listOfRanges, i);
                }
                else
                {
                    if (lastDigit != 0)
                    {
                        AddRange(sortedInput, ref firstDigit, ref lastDigit, listOfRanges, i);
                        if (sortedInput.Length == i + 2)
                            listOfRanges.Add($"{sortedInput[i + 1]}");
                    }
                    else
                    {
                        listOfRanges.Add($"{sortedInput[i]}");
                        firstDigit = sortedInput[i + 1];
                        if (sortedInput.Length == i + 2)
                            listOfRanges.Add($"{sortedInput[i+1]}");
                    }
                }
            }
            
            return String.Join(", ", listOfRanges); 
        }

        private static void AddRange(int[] sortedInput, ref int firstDigit, ref int lastDigit, List<string> listOfRanges, int i)
        {
            listOfRanges.Add($"{firstDigit}-{lastDigit}");
            firstDigit = sortedInput[i + 1];
            lastDigit = 0;
        }
    }
}
