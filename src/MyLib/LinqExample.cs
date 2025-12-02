using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstApp
{
    public class LinqExample
    {
        [Obsolete("Please use Execute of LinqExampleAdvanced instead", false)]
        public static void Execute()
        {
            var people = new List<Person>
            {
                new Person { FirstName = "Scott", LastName = "Guthrie", Age = 47 },
                new Person { FirstName = "Bill", LastName = "Gates", Age = 65 },
                new Person { FirstName = "Anders", LastName = "Hejlsberg", Age = 62 }
            };

            Console.WriteLine("Personen gefiltert:");
            IEnumerable<Person> filteredPeople = people
                .Where(p => p.LastName.StartsWith("G"));
                //.Where(p => p.LastName == "Guthrie")
                
            filteredPeople
                .ToList()
                .ForEach(p => Console.WriteLine(p));

            filteredPeople = people
                .Where(p => p.LastName.StartsWith("G"));

            double averageAge = filteredPeople
                //.Where(p => p.LastName.StartsWith("G"))
                .Average(p => p.Age);
            Console.WriteLine($"Durchschnittsalter: {averageAge}");
        }

        public class Person
        {
            public Person() {  }

            public Person(string lastName, string firstName, int age)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }

            public string FirstName { set; get; }

            public string LastName { set; get; }

            public int Age { set; get; }

            public override string ToString()
            {
                return $"{FirstName} {LastName}, {Age}";
            }
        }
    }
}
