using AutoFixture;
using Codewars.Katas;
using Xunit;

namespace XUnitKatasTests
{
    public class MoneyMoneyMoneyShould
    {
        private readonly Fixture _fixture;

        public MoneyMoneyMoneyShould()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void ReturnZeroWhenPrincipalAndDesiredPrincipalAreEqual()
        {
            var someNumber = _fixture.Create<double>();

            Assert.Equal(0, MoneyMoneyMoney.CalculateYears(someNumber, someNumber, someNumber, someNumber));
        }

        [Theory]
        [InlineData(100, 0.2, 0.5, 110, 1)]
        [InlineData(100, 0.2, 0.5, 111, 2)]
        public void ReturnProperAmountOfYearsToSaveDesiredPrincipal(double principal, double interest, double tax, double desiredPrincipal, int expectedYears)
        {
            Assert.Equal(expectedYears, MoneyMoneyMoney.CalculateYears(principal, interest, tax, desiredPrincipal));
        }

        [Theory]
        [InlineData(100, 0.2, 0.5, 110)]
        [InlineData(100, 0.05, 0.18, 104.1)]
        public void ReturnProperPrincipalAfterOneYear(double principal, double interest, double tax, double expectedPrincipal)
        {
            Assert.Equal(expectedPrincipal, MoneyMoneyMoney.CalculateOneYearPrincipal(principal, interest, tax));
        }
    }
}
