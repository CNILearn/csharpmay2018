using System;
using System.Buffers;

namespace ArrayPoolSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = ArrayPool<int>.Shared.Rent(200);
            for (int i = 0; i < 200; i++)
            {
                arr1[i] = i;
            }
            Console.WriteLine(arr1.Length);
            int[] arr2 = ArrayPool<int>.Shared.Rent(200);

            ArrayPool<int>.Shared.Return(arr1, clearArray: false);
            int[] arr3 = ArrayPool<int>.Shared.Rent(200);
            foreach (var item in arr3)
            {
                Console.WriteLine(item);
            }

            ArrayPool<int> anotherPool = ArrayPool<int>.Create();


        }
    }
}
