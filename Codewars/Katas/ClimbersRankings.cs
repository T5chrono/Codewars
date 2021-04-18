using System.Collections.Generic;
using System.Linq;

namespace Codewars.Katas
{
    public class ClimbersRankings
    {
        public static Dictionary<string, int> GetRankings(Dictionary<string, IEnumerable<int>> pointsByClimber)
        {
            // todo:   should return rankings by climber, where best 6 results for climber count... 
            // todo:   return them in descending order (the one with most points is first)
            // todo:   returned collection format: string Name Surname, int Sum of counting points
            var rankings = new Dictionary<string, int>();
            foreach (var entry in pointsByClimber)
            {
                var top6PointsSum = entry.Value.OrderByDescending(p => p).Take(6).Sum();
                rankings.Add(entry.Key, top6PointsSum);
            }
            var sortedRankings = rankings.OrderByDescending(x => x.Value).ToDictionary(pair => pair.Key, pair => pair.Value);

            return sortedRankings;
        }
    }
}
