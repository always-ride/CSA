using System;
using System.Text;

namespace MyFirstApp
{
    public class StringBuilderDemo
    {
        public static void Execute()
        {
            PrintToConsole(ExecuteWithStringBuilder());
            PrintToConsole(ExecuteWithString());
        }

        private static (int Length, int Total, string Content) ExecuteWithStringBuilder()
        {
            var sb = new StringBuilder(420, 500);
            for (int i = 0; i < 100; ++i)
            {
                sb.Append(i.ToString());
            }
            return (sb.Length, sb.Capacity, sb.ToString());
        }

        private static (int Length, int Total, string Content) ExecuteWithString()
        {
            var s = "";
            var total = 0;
            for (int i = 0; i < 100; ++i)
            {
                s += i;
                total += s.Length;
            }
            return (s.Length, total, s);
        }

        private static void PrintToConsole((int Length, int Total, string Content) dto)
        {
            Console.WriteLine($"Length of text: {dto.Length}");
            Console.WriteLine($"Allocated characters: {dto.Total}");
            Console.WriteLine($"Content: {dto.Content}");
        }
    }
}
