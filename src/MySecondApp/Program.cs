using System;
using ExampleOnionLib;

namespace MySecondApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DisplayMenu();
                RequestUserChoice(out string choice);
                MapChoiceToAction(choice, out Action action);
                Execute(action);
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("Bitte wählen Sie eine Option:");
            Console.WriteLine("1) AttributeExample");
            Console.WriteLine("2) PubSubExample");
            Console.WriteLine("3) DelegateDemo");
            Console.WriteLine("4) DelegateExample");
            Console.WriteLine("0) Beenden");
            Console.Write("Ihre Auswahl: ");
        }

        private static void RequestUserChoice(out string choice)
        {
            choice = Console.ReadLine() ?? "0";
            Console.WriteLine();
        }

        private static void MapChoiceToAction(string choice, out Action action)
        {
            action = choice switch
            {
                "1" => AttributeDemo.Execute,
                "2" => PubSubExample.Execute,
                "3" => DelegateDemo.Execute,
                "4" => DelegateExample.Execute,
                "0" => () =>
                {
                    Console.WriteLine("Programm wird beendet.");
                    Environment.Exit(0);
                },
                _ => () => Console.WriteLine("Ungültige Eingabe, bitte erneut versuchen.")
            };
            Console.WriteLine();
        }

        private static void Execute(Action action)
        {
            action();
            //action.Invoke();
        }
    }
}
