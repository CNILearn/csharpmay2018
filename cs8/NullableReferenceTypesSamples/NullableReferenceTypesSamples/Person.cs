namespace NullableReferenceTypesSamples
{
    class Person
    {
        public string FirstName { get; }
        public string? MiddleName { get; }
        public string LastName { get; }
        public Person(string firstName, string lastName)
            : this(firstName, null, lastName) { }

        public Person(string firstName, string? middleName, string lastName)
            => (FirstName, MiddleName, LastName) = (firstName, middleName, lastName);

        public void Deconstruct(out string firstName, out string middleName, out string lastName)
            => (firstName, middleName, lastName) = (FirstName, MiddleName, LastName);

    }
}
