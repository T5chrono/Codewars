using Codewars.Katas;
using NUnit.Framework;

namespace NUnitKatasTests
{
    [TestFixture]
    class CondiCipherShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("jx", "on", "cryptogam", 10)]
        [TestCase("cytgmdfmbk", "cryptogram", "cryptogam", 0)]
        [TestCase("jx wnz xrkvz jnd l ufd vwcz.", "on the first day i got lost.", "cryptogam", 10)]
        [TestCase("n ggka cvssb bfe esz omgdyr bqqva", "i will never eat any grapes again", "superkey", 4)]
        [TestCase(" zwn,t", " xyo,r",  "vtgbbpngocctffhjsjhhdmqsc", 28)]
        public void ProperlyEncodeMessage(string result, string message, string key, int initShift)
        {
            Assert.AreEqual(result, CondiCipher.Encode(message, key, initShift));
        }

        [TestCase("on", "jx", "cryptogam", 10)]
        [TestCase("....", "....", "cryptogam", 10)]
        [TestCase("sit", "abc", "keykeykeykey", 10)]
        [TestCase(",sit", ",abc", "keykeykeykey", 10)]
        [TestCase("on the first day i got lost.", "jx wnz xrkvz jnd l ufd vwcz.", "cryptogam", 10)]
        [TestCase("i will never eat any grapes again", "n ggka cvssb bfe esz omgdyr bqqva", "superkey", 30)]
        [TestCase("zva nguhbmmgydx.s,ok se,rmafz vpedgbua", "qvf cmnxmdkjfca.p,ab mf,byokf vjhwpcyb", "nqhbfgmi", 28)]
        public void ProperlyDecodeMessage(string result, string message, string key, int initShift)
        {
            Assert.AreEqual(result, CondiCipher.Decode(message, key, initShift));
        }

        [TestCase(15, 15)]
        [TestCase(0, 26)]
        [TestCase(1, 27)]
        [TestCase(2, 28)]
        [TestCase(3, 29)]
        [TestCase(0, 52)]
        [TestCase(1, 53)]

        public void EqualizePropelyPositiveOverestimation(int result, int overflow)
        {
            Assert.AreEqual(result, CondiCipher.EqualizePositive(overflow));
        }

        [TestCase(25, -1)]
        [TestCase(24, -2)]
        [TestCase(1, -25)]
        [TestCase(0, -26)]
        [TestCase(25, -27)]
        [TestCase(24, -28)]
        [TestCase(23, -29)]
        [TestCase(0, -52)]
        [TestCase(25, -53)]

        public void EqualizePropelyNegativeeOverestimation(int result, int overflow)
        {
            Assert.AreEqual(result, CondiCipher.EqualizeNegative(overflow));
        }
    }
}
