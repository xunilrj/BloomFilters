using System;
using System.Collections;

namespace MachinaAurum.CascadeBloomFilter
{
    public class BloomFilter
    {
        BitArray Array;

        public BloomFilter(int quantity, double failRate)
        {
            int length = (int)((quantity * Math.Log(failRate) * -1) / (Math.Pow(Math.Log(2), 2)));
            Array = new BitArray(length);
        }

        public void Add(object item)
        {
            var hash = item.GetHashCode();
            var h0 = hash % Array.Length;

            Array.Set(h0, true);
        }

        public bool Contains(object item)
        {
            var hash = item.GetHashCode();
            var h0 = hash % Array.Length;

            return Array.Get(h0);
        }
    }
}
