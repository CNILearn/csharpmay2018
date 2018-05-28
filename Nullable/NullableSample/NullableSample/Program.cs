using BrightNewLib;
using LegacyLib;
using System;

namespace NullableSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abc";
            Console.WriteLine(s1.ToString());

            int? x = null;

            string s2 = new Legacy().GetNullString();  // no error!!
            string? s3 = new ThisIsnew().GetNullString();
            string s4 = new ThisIsnew().GetAString();

        }

        static void Foo1(string? s)
        {
            if (s == null) throw new ArgumentNullException(nameof(s));

            string s2 = s.ToUpper();
        }

        static void Foo2(string? s)
        {
            string s2 = s ?? string.Empty;


            string s3 = s2.ToUpper();
        }

        static void Foo3(string? s)
        {
            string s2 = s?.ToUpper() ?? string.Empty;

        }

        static void Foo4(string? s)
        {
            string s2 = s!.ToUpper(); // dammit operator
        }
    }
}
