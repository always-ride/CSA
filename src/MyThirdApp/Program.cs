using MyThirdApp;

class Program
{
    /// <summary>
    /// Hier wird dem Benutzer eine Menge von Optionen angeboten, die er ausführen kann.
    /// </summary>
    /// <param name="args">Das sind die Argumente, die via Kommandozeile übergeben werden können</param>
    static void Main()
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
        Console.WriteLine("\n\nBitte wählen Sie eine Option:");
        Console.WriteLine("1) FileIODemo");
        Console.WriteLine("2) JsonSerializationDemo -> Write | Serialize");
        Console.WriteLine("3) JsonSerializationDemo -> Read | Deserialize");
        Console.WriteLine("4) LoggingDemo");
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
            "1" => FileIODemo.Execute,
            "2" => JsonSerializationDemo.CreateAndWriteToFile,
            "3" => JsonSerializationDemo.ReadFromFileAndDisplay,
            "4" => LoggingDemo.Execute,
            "0" => () =>
            {
                Console.WriteLine("Programm wird beendet.");
                Environment.Exit(0);
            }
            ,
            _ => () => Console.WriteLine("Ungültige Eingabe, bitte erneut versuchen.")
        };
        Console.WriteLine();
    }

    private static void Execute(Action action)
    {
        action.Invoke();
    }
}
