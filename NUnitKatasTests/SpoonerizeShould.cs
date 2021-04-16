using NUnit.Framework;
using Codewars.Katas;

namespace NUnitKatasTests
{
    [TestFixture]
    public class SpoonerizeShould
    {
        private SpoonerizeMe _spoonerizeMe;

        [SetUp]
        public void Setup()
        {
            _spoonerizeMe = new SpoonerizeMe();
        }

        [Test]
        public void SpoonerizeTheInputString()
        {
            var result = SpoonerizeMe.Spoonerize("not picking");

            Assert.AreEqual("pot nicking", result);
        }
    }
}
