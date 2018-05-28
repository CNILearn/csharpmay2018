using BrightNewLib;
using System;

namespace LegacyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = new ThisIsnew().GetAString();
            string s2 = new ThisIsnew().GetNullString();
        }
    }
}
