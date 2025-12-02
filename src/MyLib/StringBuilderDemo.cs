using System;
using System.Text;

namespace MyFirstApp
{
    public class StringBuilderDemo
    {
        public static void Execute()
        {
            var sb = new StringBuilder(420, 500);
            for (int i = 0; i < 100; ++i)
            {
                sb.Append(i.ToString());
            }
            Console.WriteLine("Length of text: {0}", sb.Length);
            Console.WriteLine("Capacity {0}: ", sb.Capacity);
        }
    }
}
