using System;
using System.Text;

namespace MyFirstApp
{
    public class StringBuilderExercise
    {
        public static void Execute()
        {
            string text = "The quick brown fox jumped over the lazy dog! ";
            var sb = new StringBuilder(text);

            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(sb.ToString());

                // Erstes Zeichen ans Ende verschieben
                char first = sb[0];
                sb.Remove(0, 1);
                sb.Append(first);
            }
        }
    }
}
