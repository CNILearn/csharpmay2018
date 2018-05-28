using System;

namespace SpanSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] somedata = { 1, 4, 6, 8, 11, 19, 22, 44, 88 };
            Span<int> span1 = somedata.AsSpan();
            Span<int> slice1 = span1.Slice(4, 3);
            foreach (int item in slice1)
            {
                Console.WriteLine(item);
            }

            string s1 = "the quick brown fox jumped over the lazy dogs";
            ReadOnlySpan<char> stringspan = s1.AsSpan();
            var slice2 = stringspan.Slice(5, 5);
            
        }
    }
}
