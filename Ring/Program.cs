using System;

namespace Ring
{
    class Program
    {
        static void Main()
        {
            var ring = RingProvider.LoadFromFile();
            new RingProvider(ring).SaveToFile();
        }
    }
}