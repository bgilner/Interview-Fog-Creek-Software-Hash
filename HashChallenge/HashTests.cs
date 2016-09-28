using NUnit.Framework;

namespace HashChallenge
{
    [TestFixture]
    public class HashTests
    {
        [TestCase(680131659347, "leepadg")]
        [TestCase(910897038977002, "asparagus")]
        public void ToHash_Matches_Expectation(long hash, string source)
        {
            Assert.That(Hash.ToHash(source), Is.EqualTo(hash));
        }

        [TestCase(680131659347, 7)]
        [TestCase(910897038977002, 9)]
        public void ToSource_Matches_ToHash(long hash, int length)
        {
            var source = Hash.ToSource(hash, length);
            Assert.That(Hash.ToHash(source), Is.EqualTo(hash));
        }
    }
}
