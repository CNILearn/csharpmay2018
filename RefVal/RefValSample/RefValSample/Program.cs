using System;

namespace RefValSample
{
    struct MyStruct
    {
        public int Data;
    }

    readonly struct MyReadonlyStruct
    {
        public MyReadonlyStruct(int myData) => Data = myData;

        public int Data { get; }
    }

    ref struct OnlyOnTheStack
    {
        public int Data;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStruct m1 = new MyStruct();
            m1.Data = 42;

            object o1 = m1;  // boxing - object am heap!!!
            MyStruct m2 = (MyStruct)o1; // unboxing

            Foo(ref m1);
            Console.WriteLine(m1.Data);

            int[] data = { 1, 4, 6, 8, 11, 14 };
            ref int a1 = ref GetItem(data, 3);  // ref local, call GetItem by ref
            a1 = 42;
            Console.WriteLine(data[3]);

            Foo1(m1);

            OnlyOnTheStack os1 = new OnlyOnTheStack();
            os1.Data = 42;
            // Console.WriteLine(os1.ToString());  // no boxing allowed

            ref readonly int a2 = ref GetItem2(data, 2);
            // a2 = 42;  // cannot be changed, readonly guarantee
           
        }

        static void Foo(ref MyStruct mystruct)
        {
            mystruct.Data = 11;
        }

        static ref int GetItem(int[] data, int index)
        {
            ref int x = ref data[index];  // local ref
            return ref x;  // ref return
        }

        static ref readonly int GetItem2(int[] data, int index)
        {
            ref int x = ref data[index];  // local ref
            return ref x;  // ref return
        }

        static void Foo1(in MyStruct mystruct)
        {
            // mystruct.Data = 11;  readonly variable!!
        }
    }
}
