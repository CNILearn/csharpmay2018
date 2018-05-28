using System;

namespace PatternsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var professor = new Professor("Mads", "Torgersen", "C#");
            var people = new[]
            {
                professor,
                new Student("Phillip", "Carter", professor),
                new Person("Dustin", "Campbell")
            };

            foreach (var p in people)
            {
                Console.WriteLine(M3(p));
            }
        }

        static string M(Person person)
        {
            switch(person)
            {
                case Professor p:
                    return $"Dr. {p.LastName}, Professor of {p.Subject}";
                case Student s:
                    return $"{s.FirstName}, student of Dr. {s.Advisor.LastName}";
                case Person p when p.LastName == "Campbell":
                    return $"Please enroll {p.FirstName}";
                case _:
                    return "come back next year";
            }
        }

        static string M2(Person person) =>
            person switch
            {
                Professor p => $"Dr. {p.LastName}, Professor of {p.Subject}",
                Student s => $"{s.FirstName}, student of Dr. {s.Advisor.LastName}",
                Person p when p.LastName == "Campbell" => $"Please enroll {p.FirstName}",
                _ => "come back next year"
            };

        static string M3(Person person) =>
            person switch
            {
                Professor (_, var ln, var s) => $"Dr. {ln}, Professor of {s}",  // deconstructor of Professor, discard pattern
                Student (var fn, _, var (_, ln, _)) => $"{fn}, student of Dr. {ln}",  // recursive pattern
                { LastName: "Campbell", FirstName: var fn } => $"Please enroll {fn}",  // property pattern
                _ => "come back next year"
            };

    }
}
