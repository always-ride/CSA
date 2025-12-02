using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace MyThirdApp
{
    public class JsonSerializationDemo
    {
        public class Employee
        {
            public string Name { get; set; }
            public int Id { get; set; }

            [JsonIgnore] // ersetzt [NonSerialized]
            public int CacheValue { get; set; }

            public Employee(string name, int id)
            {
                Name = name;
                Id = id;
                CacheValue = 15;
            }

            public override string ToString()
            {
                return $"Name: {Name} Id:{Id} Cache:{CacheValue}";
            }
        }

        public static void CreateAndWriteToFile()
        {
            // Entitäten erzeugen
            var employees = new List<Employee>
            {
                new("Smith", 1),
                new("Braun", 2),
                new("Heller", 3)
            };

            // Entitäten anzeigen auf Konsole
            Console.WriteLine("Employees to be serialized to Employees.json");
            foreach (var emp in employees)
                Console.WriteLine(emp);

            // Entitäten serialisieren in JSON-Datei
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(employees, options);
            File.WriteAllText("Employees.json", json);
        }

        public static void ReadFromFileAndDisplay()
        {
            // Entitäten deserialisieren
            string jsonFromFile = File.ReadAllText("Employees.json");
            var loadedEmployees = JsonSerializer.Deserialize<List<Employee>>(jsonFromFile)!;

            // Entitäten anzeigen auf Konsole
            Console.WriteLine("\nDeserialized Employees:");
            foreach (var emp in loadedEmployees)
                Console.WriteLine(emp);
        }
    }
}
