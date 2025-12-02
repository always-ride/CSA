using System;
using System.Collections;

namespace MyFirstApp
{
    public class HashTableExample
    {
        public static void Execute()
        {
            // Hashtable anlegen
            Hashtable employees = new Hashtable();

            // EmployeeIDs anlegen
            EmployeeID id1 = new EmployeeID("ab123");
            EmployeeID id2 = new EmployeeID("cd456");
            EmployeeID id3 = new EmployeeID("ef789");

            // Hashtable befüllen
            employees.Add(id1, "Alice");
            employees.Add(id2, "Bob");
            employees.Add(id3, "Charlie");

            // Zugriff auf die Werte
            Console.WriteLine(employees[id1]); // Ausgabe: Alice
            Console.WriteLine(employees[id2]); // Ausgabe: Bob
            Console.WriteLine(employees[id3]); // Ausgabe: Charlie

            // Test: gleicher Key in anderer Schreibweise
            EmployeeID id1_lowercase = new EmployeeID("aB123");
            Console.WriteLine(employees[id1_lowercase]); // Ausgabe: Alice (weil Equals + HashCode passen)
        }

        class EmployeeID
        { 
            public EmployeeID(string id)
            {
                Id = id.ToUpperInvariant();
            }

            public string Id { get; }

            public override bool Equals(object obj)
            {
                return obj is EmployeeID empl && Id == empl.Id;
            }

            public override int GetHashCode()
            {
                // HashCode des normalisierten Strings verwenden
                return Id.GetHashCode();
            }

        }
    }
}
