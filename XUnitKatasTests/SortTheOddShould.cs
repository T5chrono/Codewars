using Codewars.Katas;
using Xunit;

namespace XUnitKatasTests
{
    public class SortTheOddShould
    {
        [Theory]
        [InlineData(new int[] { 7, 1 }, new int[] { 1, 7 })]
        [InlineData(new int[] { 7, 4, 1 }, new int[] { 1, 4, 7 })]
        [InlineData(new int[] { 5, 3, 1, 8, 0 }, new int[] { 1, 3, 5, 8, 0 })]
        public void ShouldSortOnlyOddNumbers(int[] arrayToSort, int[] expectedArray)
        {
            Assert.Equal(expectedArray, SortTheOdd.SortArray(arrayToSort));
        }
    }
}
