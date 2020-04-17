using System;

namespace TheOldLib
{
    public class Legacy
    {
        public string GetANullString() => null;
    }

    public interface ILegacyInterface
    {
        string Foo();
    }
}
