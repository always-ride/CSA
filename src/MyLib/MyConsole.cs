using System;

namespace MyLib
{
    /// <summary>
    /// Summary description for MyConsole.
    /// </summar
    public class MyConsole : IConsoleClient, IConsoleTestClient
    {
        public const string DefaultText = "Hello World!";
        private string lastlyPritedText = "";

        // To avoid being used from outside
        private MyConsole() { }

        /// <summary>
        /// To print a <paramref name="text"/> to the console.
        /// </summary>
        /// <param name="text"></param>
        public void PrintToConsole(string text)
        {
            Console.WriteLine(text);
            lastlyPritedText = text;
        }

        public string LastlyPrintedText
        {
            // for testing only
            get { return lastlyPritedText; }
        }

        public static IConsoleTestClient Create() 
        {
            IConsoleTestClient mc = new MyConsole();
            return mc;
        }
    }
}
