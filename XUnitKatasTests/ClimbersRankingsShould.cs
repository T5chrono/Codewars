using Codewars.Katas;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace XUnitKatasTests
{
    public class ClimbersRankingsShould
    {
        public Dictionary<string, IEnumerable<int>> Rankings { get; set; }

        public ClimbersRankingsShould()
        {
            Rankings = new Dictionary<string, IEnumerable<int>>
            {
                {"SKOFIC Domen", new[] {55, 100, 100, 25, 100, 51, 80}}
            };
        }

        [Fact]
        public void ReturnProperSum()
        {
            var result = ClimbersRankings.GetRankings(Rankings);
            Assert.Equal(486, result["SKOFIC Domen"]);
        }

        [Fact]
        public void ReturnProperSumEvenForLessPointed()
        {
            Rankings = new Dictionary<string, IEnumerable<int>>
            {
                {"SKOFIC Domen", new[] {100, 100, 25}}
            };
            var result = ClimbersRankings.GetRankings(Rankings);
            Assert.Equal(225, result["SKOFIC Domen"]);
        }

        [Fact]
        public void ReturnProperlySortedClimbers()
        {
            Rankings.Add("WorseSKOFIC Domen", new[] { 100, 100, 26 });
            var result = ClimbersRankings.GetRankings(Rankings).OrderBy(pair => pair.Key).First();
            Assert.Equal(486, result.Value);
        }
    }
}
