using System;

namespace RangesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 2, 4, 8, 11, 18, 33, 99, 127 };
            Span<int> span1 = data.AsSpan();
            Span<int> span2 = span1.Slice(3, 4);

            var span3 = data[2..5];
            foreach (var item in span3)
            {
                Console.WriteLine(item);
            }

            var span4 = data[3..];
            var span5 = data[0..^0];
            var span6 = data[..];

            string title = "\"The Mads and Dustin Show\"";
            PrintBanner(title);
        }

        static void PrintBanner(string text)
        {
            if (text?.Length >= 2 && text[0] == '"' && text[^1] == '"')
            {
                // text = text.Substring(1, text.Length - 2);
                text = text[1..^1];
            }
            Console.WriteLine(text);
        }
    }
}
