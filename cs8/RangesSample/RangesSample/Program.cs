using System;

namespace RangesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintBanner('"' + "The Mads and Dustin Show" + '"');
            //int[] arr1 = new int[100];
            //for (int i = 0; i < 100; i++)
            //{
            //    arr1[i] = i;
            //}

            //Span<int> span1 = arr1.AsSpan();
            //Span<int> span2 = arr1[..];
            //Span<int> 

            //Span<int> arr2 = arr1[3..30];
            //foreach (var item in arr2)
            //{
            //    Console.WriteLine(item);
            //}

            //Span<int> span30 = stackalloc int[10];

        }

        static void PrintBanner(string text)
        {
            var last = ^1;
            if (text?.Length >= 2 && text[0] == '"' && text[last] == '"')
            {
                text = text.Substring(1, text.Length - 2);
            }
            Console.WriteLine(text);
        }

        static void PrintBanner2(string text)
        {
            var last = ^1;
            if (text?.Length >= 2 && text[0] == '"' && text[last] == '"')
            {
                // text = text.Substring(1..^1);
                text = text[1..^1];
            }
            Console.WriteLine(text);
        }

        static void PrintNumbers()
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            foreach (var v in array)
            {
                Console.WriteLine(v);
            }
        }

        static void PrintNumbers2()
        {
            int[] array = new int[10];
            Span<int> slice = array[4..8];
            Span<int> slice2 = array[..8];
            Span<int> slice3 = array[4..^0];
            Span<int> slice4 = array[4..];
            Span<int> slice5 = array[..];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            foreach (var v in slice)
            {
                Console.WriteLine(v);
            }
        }
    }
}
