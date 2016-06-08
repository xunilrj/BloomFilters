using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MachinaAurum.CascadeBloomFilter.Tests
{
    [TestClass]
    public class BloomFilterTests
    {
        [TestMethod]
        public void MustBePossibleToAddAndTestANumber()
        {
            var filter = new BloomFilter(100, 0.95);
            filter.Add(47);

            Assert.IsTrue(filter.Contains(47));
            Assert.IsFalse(filter.Contains(48));
        }
    }    
}
