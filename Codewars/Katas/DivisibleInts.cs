using System;
using System.Collections.Generic;

namespace Codewars.Katas
{
    public static class DivisibleInts
    {
        public static int GetCount(int n)
        {
            var nAsString = n.ToString();
            var allSubstringsOfN = ProvideAllSubstrings(nAsString);

            var totalNumberOfFullDivisions = 0;
            foreach (var substring in allSubstringsOfN)
            {
                var numberToCheck = Convert.ToInt32(substring);
                if (numberToCheck!=0 && numberToCheck !=n && n % numberToCheck == 0)
                    totalNumberOfFullDivisions += 1;
            }

            return totalNumberOfFullDivisions;
        }

        private static List<string> ProvideAllSubstrings(string nAsString)
        {
            var allSubstringsOfN = new List<string>();
            for (int i = 0; i < nAsString.Length; i++)
                for (int j = i; j < nAsString.Length; j++)
                    allSubstringsOfN.Add(nAsString.Substring(i, j - i + 1));
            return allSubstringsOfN;
        }
    }
}
