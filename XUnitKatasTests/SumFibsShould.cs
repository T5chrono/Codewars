using Codewars.Katas;
using Xunit;

namespace XUnitKatasTests
{
    public class SumFibsShould
    {
        [Theory]
        [InlineData(-1, 0)]
        [InlineData(0, 0)]
        [InlineData(1, 0)]
        [InlineData(2, 0)]
        [InlineData(3, 2)]
        [InlineData(5, 2)]
        [InlineData(9, 44)]
        [InlineData(10, 44)]
        [InlineData(11, 44)]
        public void CalculateProperSumOfEvanFibNumbersUpToIndex(int index, int expectedResult)
        {
            Assert.Equal(expectedResult, SumFibs.SumEvenFibsUpTo(index));
        }
    }
}
