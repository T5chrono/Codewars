using Codewars.Katas;
using Xunit;

namespace XUnitKatasTests
{
    public class GroupingConsecutiveNumbersShould
    {
        [Theory]
        [InlineData(new int[] { 1 }, "1")]
        [InlineData(new int[] { 1, 3 }, "1, 3")]
        [InlineData(new int[] { 1, 2, 3 }, "1-3")]
        [InlineData(new int[] { 1, 2, 3, 5 }, "1-3, 5")]
        [InlineData(new int[] { 1, 2, 3, 5, 9, 10}, "1-3, 5, 9-10")]
        public void ReturnProperConcatenatedString(int[] array, string expectedString)
        {
            Assert.Equal(expectedString, GroupingConsecutiveNumbers.GenerateGroupings(array));
        }
    }
}
