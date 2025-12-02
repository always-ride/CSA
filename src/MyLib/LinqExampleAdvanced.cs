using System;
using System.Linq;

namespace MyFirstApp
{
    public class LinqExampleAdvanced
    {
        public static void Execute()
        {
            // Arrays zum Testen
            string[] names = { "Alice", "Bob", "Charlie", "Alice", "Eve", "Frank" };
            int[] numbers = { 5, 3, 9, 1, 4, 3, 7 };

            // 1. Where & OrderBy
            var longNames = names
                .Where(n => n.Length > 3)
                .OrderBy(n => n);
            Console.WriteLine("Where & OrderBy:");
            foreach (var n in longNames) Console.WriteLine(n);

            // 2. First, Last, ElementAt
            Console.WriteLine("\nFirst: " + numbers.First());
            Console.WriteLine("Last: " + numbers.Last());
            Console.WriteLine("ElementAt(2): " + numbers.ElementAt(2));

            // 3. Count, Min, Max, Average
            Console.WriteLine("\nCount: " + numbers.Count());
            Console.WriteLine("Min: " + numbers.Min());
            Console.WriteLine("Max: " + numbers.Max());
            Console.WriteLine("Average: " + numbers.Average());

            // 4. Any, Contains, Distinct, Concat, Union
            Console.WriteLine("\nAny > 5? " + numbers.Any(n => n > 5));
            Console.WriteLine("Contains 4? " + numbers.Contains(4));
            Console.WriteLine("Distinct numbers: " + string.Join(", ", numbers.Distinct()));

            var moreNumbers = new int[] { 7, 8, 9 };
            Console.WriteLine("Concat: " + string.Join(", ", numbers.Concat(moreNumbers)));
            Console.WriteLine("Union: " + string.Join(", ", numbers.Union(moreNumbers)));

            // 5. Take, Skip, TakeWhile, SkipWhile, Reverse
            Console.WriteLine("\nTake(3): " + string.Join(", ", numbers.Take(3)));
            Console.WriteLine("Skip(3): " + string.Join(", ", numbers.Skip(3)));
            Console.WriteLine("TakeWhile < 5: " + string.Join(", ", numbers.TakeWhile(n => n < 5)));
            Console.WriteLine("SkipWhile < 5: " + string.Join(", ", numbers.SkipWhile(n => n < 5)));
            Console.WriteLine("Reverse: " + string.Join(", ", numbers.Reverse()));

            // 6. ToList, ToArray, ToLookup, ToDictionary
            var nameList = names.ToList();
            Console.WriteLine("\nToList: " + string.Join(", ", nameList));

            var nameArray = names.ToArray();
            Console.WriteLine("ToArray: " + string.Join(", ", nameArray));

            var nameLookup = names.ToLookup(n => n.Length);
            Console.WriteLine("ToLookup (group by length):");
            foreach (var group in nameLookup)
            {
                Console.WriteLine($"Length {group.Key}: {string.Join(", ", group)}");
            }

            var numberDict = numbers.Distinct().ToDictionary(n => n, n => n * n);
            Console.WriteLine("ToDictionary (number -> square):");
            foreach (var kvp in numberDict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
