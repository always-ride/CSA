using System;
using MyLib;

// dot net framework
namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bitte wählen Sie eine Option:");
                Console.WriteLine("1) ExecuteSafely");
                Console.WriteLine("2) StringBuilderDemo");
                Console.WriteLine("3) HashTableExample");
                Console.WriteLine("4) StringBuilderExercise");
                Console.WriteLine("5) YieldExample");
                Console.WriteLine("6) LinqExample");
                Console.WriteLine("7) LinqExampleAdvanced");
                Console.WriteLine("0) Beenden");
                Console.Write("Ihre Auswahl: ");

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        ExecuteSafely(args);
                        break;

                    case "2":
                        StringBuilderDemo.Execute();
                        break;

                    case "3":
                        HashTableExample.Execute();
                        break;

                    case "4":
                        StringBuilderExercise.Execute();
                        break;

                    case "5":
                        YieldExample.Execute();
                        break;

                    case "6":
                        LinqExample.Execute();
                        break;

                    case "7":
                        LinqExampleAdvanced.Execute();
                        break;

                    case "0":
                        Console.WriteLine("Programm wird beendet.");
                        return;

                    default:
                        Console.WriteLine("Ungültige Eingabe, bitte erneut versuchen.");
                        break;
                }

                Console.WriteLine();
            }
        }


        static void ExecuteSafely(string[] args)
        {
            try
            {
                ExecuteHelloWorld(args);
            }
            catch (Exception e)
            {
                Console.WriteLine("Upsi, wir habe wohl eine Division mit 0 versucht auszuführen!!");
                Console.WriteLine(e.Message);
            }
        }

        static void ExecuteHelloWorld(string[] args)
        {
            string text = MyConsole.DefaultText;
            //int zero = 0;
            //int divisionResult = 20 / zero;

            switch (args.Length)
            {
                case 0:
                    // do nothing
                    break;
                default:
                    // Alle Argumente zu einem String zusammensetzen
                    text = string.Join(" ", args);
                    break;
            }

            IConsoleClient mc = MyConsole.Create();
            mc.PrintToConsole(text);
        }
    }
}
