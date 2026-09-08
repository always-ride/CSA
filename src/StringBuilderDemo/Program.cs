using System.Text;

namespace StringBuilderDemo
{
    public static class Program
    {
        public static void Main()
        {
            PrintToConsole(ExecuteWithStringBuilder);
            PrintToConsole(ExecuteWithString);
        }

        public record ActionResult(int Length, int Total, string Content);

        private static ActionResult ExecuteWithStringBuilder()
        {
            var sb = new StringBuilder(420, 500);
            for (int i = 0; i < 100; ++i)
            {
                sb.Append(i);
            }
            return new ActionResult(sb.Length, sb.Capacity, sb.ToString());
        }

        private static ActionResult ExecuteWithString()
        {
            var s = "";
            var total = 0;
            for (int i = 0; i < 100; ++i)
            {
                s += i;
                total += s.Length;
            }
            return new ActionResult(s.Length, total, s);
        }

        private static void PrintToConsole(Func<ActionResult> action)
        {
            ActionResult dto = action();

            Console.WriteLine($"Length of text: {dto.Length}");
            Console.WriteLine($"Allocated characters: {dto.Total}");
            Console.WriteLine($"Content: {dto.Content}");
        }
    }
}
