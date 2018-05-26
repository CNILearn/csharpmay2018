using NewAndGloryLib;
using System;
using TheOldLib;

namespace NullableReferenceTypesSamples
{
    class SomeClass : ILegacyInterface
    {
        public string? Foo() => null;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var miguel = new Person("Miguel", "de Icaza");
            int length = GetLengthOfMiddleName(miguel);
            Console.WriteLine(length);

            var old = new Legacy();
            string s1 = old.GetANullString();  // no error
           // Console.WriteLine(s1.ToUpper()); // legacy no error, runtime exception
            var newglory = new NewAndGlory();
            string? s2 = newglory.GetANullString();
            string s3 = newglory.GetAString();
            var sc = new SomeClass();
            string? s4 = sc.Foo();
            string s5 = sc.Foo()!;  // dammit

        }

        static int GetLengthOfMiddleName(Person p)
        {
            string? middleName = p.MiddleName;
            if (middleName == null)
            {
                middleName = string.Empty;
            }

            return middleName.Length;
        }

        static int GetLengthOfMiddleName2(Person p)
            => p.MiddleName?.Length ?? 0;
    }
}
